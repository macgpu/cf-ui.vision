# Handover: hand-written additions to `/ai/ai-system-prompt`

**To:** whoever owns the generator that produces `ai/ai-system-prompt.html`
**From:** website repo (`macgpu/cf-ui.vision`), commit `6456763`, 2026-07-24
**Action needed:** fold the four blocks below into the page template, or the next
release will silently delete them.

---

## 1. Why you are reading this

The page states: *"This page is regenerated at every release — the copy below is
always the shipping prompt."* There is no generator in the website repo, so it
lives on your side.

On 2026-07-24 three things were added **by hand** to the published page:

1. A **"Copy prompt to clipboard" button** — the prompt is 39,837 characters, so
   selecting it by hand is genuinely painful.
2. A section **"Use the prompt with Claude Code, Codex and other AI tools"** —
   explains that pasting the prompt into any AI coding tool lets it write
   Ui.Vision macros without ever having seen Ui.Vision.
3. The **CSS** those two need.

Regenerating the page from the current template will drop all three. Nobody will
notice until a user asks where the copy button went.

Only the contents of `<pre id="system-prompt">` is machine-generated. Everything
else on that page is editorial and should survive regeneration.

---

## 2. Insertion points

Anchors refer to the file as published at commit `6456763`. Each block is
positioned relative to existing markup rather than to a line number, so the
placement still holds if the surrounding copy is edited.

| Block | Goes | Anchor |
|---|---|---|
| 1 — CSS | inside the existing `<style>` in `<head>` | after the `#system-prompt { ... }` rule |
| 2 — external-AI section | in the body | after the `id="customize"` section, immediately **before** `<h3 id="prompt">` |
| 3 — the button | in the body | after the "Auto-generated from the extension source…" paragraph, immediately **before** `<pre id="system-prompt">` |
| 4 — the script | in the body | immediately **after** `</pre>`, before the "Anything wrong or missing" heading |

---

## 3. The blocks, verbatim

### Block 1 — CSS (into the `<head>` `<style>`)

```html
        ul.bullets { list-style: disc outside none; padding-left: 1.6em; margin: 0 0 1em; }
        ul.bullets li { margin-bottom: .5em; }
        #copy-prompt {
            display: inline-block;
            padding: 9px 16px;
            font-size: 14px;
            font-weight: 500;
            color: #fff;
            background: #037455;
            border: 1px solid #026046;
            border-radius: 5px;
            cursor: pointer;
        }
        #copy-prompt:hover { background: #026046; }
        #copy-prompt[data-state="done"] { background: #1b60a3; border-color: #164e85; }
        #copy-prompt[data-state="fail"] { background: #c7254e; border-color: #a71f42; }
        #copy-prompt .fa { margin-right: 7px; }
```

### Block 2 — the external-AI section (before `<h3 id="prompt">`)

```html
            <h3 id="othertools">Use the prompt with Claude Code, Codex and other AI tools</h3>
            <p>
                The prompt is not only useful inside Ui.Vision. Copy it, paste it into any AI coding tool as context, and that tool can write
                Ui.Vision macros for you — even though it has never seen Ui.Vision before. The prompt documents every command, the exact macro
                JSON format and the locator tricks that matter, which is precisely what a general-purpose AI is missing. Then just ask for what
                you need: <em>"write a Ui.Vision macro that logs into our intranet and downloads yesterday's report"</em>. Paste the resulting
                JSON into the extension (or save it as a .json file in your macro folder) and run it.
            </p>
            <p>
                This works with any tool that accepts a long piece of context, for example:
            </p>
            <p>
                <ul class="bullets">
                    <li><strong>AI coding agents in the terminal:</strong> Claude Code, OpenAI Codex, Gemini CLI, Aider.</li>
                    <li><strong>AI code editors:</strong> Cursor, Windsurf, Cline, GitHub Copilot in VS Code and Visual Studio.</li>
                    <li><strong>Plain chat:</strong> Claude, ChatGPT, Gemini and friends — paste the prompt into the first message, or store it
                        as a project instruction / custom GPT so you only paste it once.</li>
                </ul>
            </p>
            <p>
                For the agents that read files, it is often easiest to save the prompt as <span class="hired">uivision-system-prompt.txt</span>
                in your project and point the tool at it. Two more context files help these tools understand Ui.Vision:
                <a href="/llms.txt">llms.txt</a> (a short index of our documentation) and <a href="/llms-full.txt">llms-full.txt</a> (the full text).
            </p>
```

### Block 3 — the button (immediately before `<pre id="system-prompt">`)

```html
            <p>
                <button type="button" id="copy-prompt" data-label="Copy prompt to clipboard">
                    <i class="fa fa-clipboard"></i><span id="copy-prompt-label">Copy prompt to clipboard</span>
                </button>
            </p>
```

### Block 4 — the script (immediately after `</pre>`)

```html
            <script>
                (function () {
                    var btn = document.getElementById('copy-prompt');
                    var label = document.getElementById('copy-prompt-label');
                    var pre = document.getElementById('system-prompt');
                    if (!btn || !pre) return;
                    var icon = btn.querySelector('.fa');
                    var resetTimer;

                    function feedback(state, text) {
                        btn.setAttribute('data-state', state);
                        label.textContent = text;
                        icon.className = 'fa ' + (state === 'done' ? 'fa-check' : 'fa-clipboard');
                        clearTimeout(resetTimer);
                        resetTimer = setTimeout(function () {
                            btn.removeAttribute('data-state');
                            label.textContent = btn.getAttribute('data-label');
                            icon.className = 'fa fa-clipboard';
                        }, 2500);
                    }

                    // Fallback for browsers without the async clipboard API, and for
                    // any non-secure context, where navigator.clipboard is undefined.
                    function legacyCopy(text) {
                        var ta = document.createElement('textarea');
                        ta.value = text;
                        ta.setAttribute('readonly', '');
                        ta.style.position = 'fixed';
                        ta.style.left = '-9999px';
                        document.body.appendChild(ta);
                        ta.select();
                        var ok = false;
                        try { ok = document.execCommand('copy'); } catch (e) { ok = false; }
                        document.body.removeChild(ta);
                        return ok;
                    }

                    btn.addEventListener('click', function () {
                        var text = pre.textContent;
                        if (navigator.clipboard && navigator.clipboard.writeText) {
                            navigator.clipboard.writeText(text).then(function () {
                                feedback('done', 'Copied!');
                            }, function () {
                                var ok = legacyCopy(text);
                                feedback(ok ? 'done' : 'fail', ok ? 'Copied!' : 'Press Ctrl+C to copy');
                            });
                        } else if (legacyCopy(text)) {
                            feedback('done', 'Copied!');
                        } else {
                            feedback('fail', 'Press Ctrl+C to copy');
                        }
                    });
                }());
            </script>
```

---

## 4. Design notes — please preserve these, they are not arbitrary

1. **Copy from `textContent`, never `innerHTML`.** The generator HTML-escapes the
   prompt (`&lt;select&gt;`, `&amp;`, …). `innerHTML` would put the *escaped*
   text on the clipboard, which is subtly wrong and would poison every prompt
   pasted into another AI tool. `textContent` reverses the escaping. Verified:
   the clipboard receives `<select>`, not `&lt;select&gt;`.
2. **No jQuery.** The site loads jQuery at the very bottom of `<body>`, *after*
   this script runs. The script is a vanilla IIFE with no dependencies, so it can
   sit anywhere after the `<pre>`.
3. **The CSS is class-scoped (`ul.bullets`), not `#content`-scoped, on purpose.**
   The content wrapper is `<div id="content download-content">` — an `id`
   containing a space, which no `#content` selector can ever match. This bites on
   every page of the site; do not "fix" the selector to `#content ul.bullets`.
4. **`ul.bullets` exists because the page sets `ul { list-style: none }`
   globally** (needed by the nav menu), which otherwise strips bullets from
   content lists too.
5. **Font Awesome 4 is already loaded**; `fa-clipboard` and `fa-check` are both
   present in the bundled CSS. No new asset needed.
6. **The fallback chain is deliberate:** async Clipboard API → `execCommand`
   → visible "Press Ctrl+C to copy". `navigator.clipboard` requires *both* a
   secure context and a focused document, so real failures do happen. The button
   must never fail silently.
7. **Feedback resets after 2.5 s**, and the timer is cleared on repeat clicks so
   rapid clicking cannot strand the button in the "Copied!" state.

---

## 5. Verification already done

Tested against the real page served locally:

- Copies **39,837 characters**, byte-identical to `pre.textContent`.
- Escaping correct — clipboard contains real angle brackets.
- Success state: label → "Copied!", icon → `fa-check`, blue; auto-resets to the
  original label/icon after 2.5 s.
- Failure path exercised for real (the test browser could not hold focus) and
  degrades correctly to "Press Ctrl+C to copy".

**Not verified, please check once after porting:** an actual clipboard write in a
focused browser. The test environment reported `document.hasFocus() === false`,
so the OS clipboard could never be written; the success path was confirmed with a
stubbed `writeText`. One manual click in a real browser closes this gap.

Nothing needs updating when the prompt changes length or content — the button
reads whatever is inside `#system-prompt`.

---

## 6. ⚠ Separate but important: the `/ai#key` anchor is gone

Unrelated to the generator, but it can break links you own.

The `/ai` page was rewritten for V10. The step-by-step "How to get an Anthropic
API key" section — anchor **`#key`** — was **removed**, because the new free
Ui.Vision AI tier makes it the wrong emphasis. Inbound links in the website were
repointed to `/ai#providers`.

**If the extension UI, its settings page, any error message, or your docs link to
`https://ui.vision/ai#key`, update it to `https://ui.vision/ai#providers`.**
The page still loads — the anchor simply no longer scrolls anywhere.

Current stable anchors on `/ai`: `#assistant`, `#free`, `#providers`,
`#commands`, `#docs`.

---

## 7. Editorial content that will drift

The tool list in Block 2 names Claude Code, OpenAI Codex, Gemini CLI, Aider,
Cursor, Windsurf, Cline and GitHub Copilot. That is prose with a shelf life —
treat it as website-owned copy to be refreshed, not as generated content.
