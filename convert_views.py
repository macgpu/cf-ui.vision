#!/usr/bin/env python3
"""
Converts all ASP.NET MVC cshtml views to static HTML for Cloudflare Pages.
Reads views from git history (commit 4fec2c7), applies the layout, and
writes files to the correct paths based on controller [Route] attributes.
"""

import subprocess, os, re, sys

REPO      = r"C:\3github_onmac\cf-ui.vision"
GIT_REF   = "4fec2c7"
OUT_DIR   = REPO

LAYOUT_HEAD = """\
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <meta name="description" content="{description}">
    <title>{title}</title>
    <link rel="icon" href="/content/images/ui.vision.favicon32.webp" />
    <link href="/Content/themes/basic/bootstrap.css" rel="stylesheet" />
    <link href="/Content/fontawesome/css/font-awesome.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,300,300i,400,400i,500,500i,700,700i,900" rel="stylesheet">
    <link href="/Content/Main/base.css" rel="stylesheet" />
    <link href="/Content/Main/elements.css" rel="stylesheet" />
    <link href="/Content/Main/grid.css" rel="stylesheet" />
    <link href="/Content/Main/layout.css" rel="stylesheet" />
    <link href="/Content/Main/style.css" rel="stylesheet" />
    <style>ul {{ list-style: none outside none; padding-left: 0; margin: 0; }}</style>
    <script async src="https://www.googletagmanager.com/gtag/js?id=G-VJNCDYRXBP"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() {{ dataLayer.push(arguments); }}
        gtag('js', new Date());
        gtag('config', 'G-VJNCDYRXBP');
    </script>
</head>
<body>
    <div id="header">
        <div class="row">
            <div class="span2">
                <a href="/" id="logo">
                    <img src="/Content/Images/ui.vision.logo2.webp" alt="Ui.Vision RPA" class="responsive-img">
                </a>
            </div>
            <div class="span10">
                <a class="toggleMenu" id="mobile-menu-trigger" href="#"><i class="fa fa-bars"></i></a>
                <ul class="nav" style="display:block;">
                    <li>
                        <a href="/#get"><span class="highlight">1. Get Ui.Vision (free)</span></a>
                        <ul class="children-menu">
                            <li><a href="/rpa">Open-Source RPA</a></li>
                            <li><a href="/rpa/x">Ui.Vision XModules</a></li>
                            <li><a href="/rpa/docs/selenium-ide">Classic Browser Automation</a></li>
                            <li><a href="/rpa/x/desktop-automation">Desktop Automation</a></li>
                            <li><a href="/ai/computeruse">AI Computer Use</a></li>
                            <li><a href="/rpa/x/pricing">Buy RPA PRO and Enterprise</a></li>
                            <li><a href="https://forum.ocr.space/">Visit Our User Forum</a></li>
                        </ul>
                    </li>
                    <li><a href="/rpa/x"><span class="highlight">2. Install XModules</span></a></li>
                    <li>
                        <a href="https://ocr.space">OCR</a>
                        <ul class="children-menu">
                            <li><a href="https://ocr.space/ocrapi">Free PDF OCR API</a></li>
                            <li><a href="https://ocr.space">Free Online OCR</a></li>
                            <li><a href="https://ocr.space/searchablepdf">Create Searchable PDF</a></li>
                            <li><a href="https://ocr.space/copyfish">Copyfish OCR</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="/contact">Support</a>
                        <ul class="children-menu">
                            <li><a href="/rpa/docs">RPA Docs</a></li>
                            <li><a href="/ai">AI Integration Docs</a></li>
                            <li><a href="https://forum.ocr.space">RPA, OCR, AI Forum</a></li>
                            <li><a href="/contact">Contact Us</a></li>
                            <li><a href="/about">About Us</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </div>
"""

LAYOUT_FOOT = """\

    <div class="bigborder"></div>
    <div class="row">
        <script src="https://forum.ocr.space/javascripts/embed-topics.js"></script>
        <style>d-topics-list iframe {{ width: 80% !important; }}</style>
        <div>
            <h2>Fresh from the Ui.Vision Forum: The Latest 3 Topics.</h2>
            <d-topics-list discourse-url="https://forum.ocr.space/" allow-create=true template="complete" per-page="3"></d-topics-list>
        </div>
        <div class="span3 foot-links">
            <a href="https://forum.ocr.space/"><i class="fa fa-gear"></i> RPA, OCR, AI Forums</a><br />
            <a href="/rpa/x/desktop-automation"><i class="fa fa-download"></i> Desktop Automation</a><br />
            <a href="/rpa/#selenium-ide"><i class="fa fa-gear"></i> Selenium IDE</a><br />
            <a href="/ai/computeruse"><i class="fa fa-gear"></i> AI Claude Computer Use</a><br />
            <a href="https://github.com/A9T9/RPA"><i class="fa fa-gear"></i> Ui.Vision Source Code</a>
        </div>
        <script async defer src="https://buttons.github.io/buttons.js"></script>
        <div class="span9 nomargin">
            ← Meet the Ui.Vision team and users in our <a href="https://forum.ocr.space">forums</a>.
        </div>
    </div>
    <div class="bigborder2"></div>
    <div id="footer">
        <div id="footer-bottom">
            <div class="row">
                <div class="span12">
                    <p class="last">Copyright &#169; 2016-2026 by a9t9 software GmbH. <a href="/privacypolicy">Our Privacy Policy</a>.</p>
                </div>
            </div>
        </div>
    </div>

    <script src="/Scripts/jquery-2.1.3.min.js"></script>
    <script src="/Scripts/modernizr-2.6.2.js"></script>
    <script src="/Scripts/Basic/bootstrap.min.js"></script>
    <script src="/Scripts/a9t9scripts.js"></script>
    <script src="/Scripts/Layout/plugins.js"></script>
    <script src="/Scripts/Layout/script.js"></script>
    {extra_scripts}
</body>
</html>
"""


def git_show(path):
    """Get file content from git history."""
    result = subprocess.run(
        ["git", "show", f"{GIT_REF}:{path}"],
        capture_output=True, text=True, encoding="utf-8", errors="replace", cwd=REPO
    )
    return result.stdout if result.returncode == 0 else None


def extract_title(content):
    """Pull ViewBag.Title value out of @{ ... } block."""
    m = re.search(r'ViewBag\.Title\s*=\s*"([^"]*)"', content)
    return m.group(1) if m else "Ui.Vision RPA"


def extract_section_scripts(content):
    """Remove @section scripts { ... } and return (cleaned_content, scripts_html)."""
    idx = content.find("@section scripts")
    if idx == -1:
        return content, ""
    # Find the opening brace
    brace_idx = content.index("{", idx)
    depth = 0
    end = brace_idx
    for i, ch in enumerate(content[brace_idx:], brace_idx):
        if ch == "{":
            depth += 1
        elif ch == "}":
            depth -= 1
            if depth == 0:
                end = i
                break
    scripts = content[brace_idx + 1:end].strip()
    cleaned = content[:idx] + content[end + 1:]
    return cleaned, scripts


def clean_razor(content):
    """Remove common Razor syntax from cshtml content."""
    # Remove @{ ... } code blocks
    content = re.sub(r'@\{[^}]*\}', '', content, flags=re.DOTALL)
    # Replace ~/path refs
    content = content.replace('src="~/', 'src="/')
    content = content.replace('href="~/', 'href="/')
    content = re.sub(r'@Url\.Content\("~/([^"]+)"\)', r'/\1', content)
    # Remove @Html.* helpers (validation summaries, antiforgery tokens, etc.)
    content = re.sub(r'@Html\.\w+\([^)]*\)', '', content)
    content = re.sub(r'@using\s+\([^)]*\)\s*\{', '', content)
    # Remove standalone @ expressions that weren't caught above
    content = re.sub(r'@[A-Z]\w*\.\w+', '', content)
    # Remove @* comments *@
    content = re.sub(r'@\*.*?\*@', '', content, flags=re.DOTALL)
    # Remove Razor @model line
    content = re.sub(r'^@model\s+.*$', '', content, flags=re.MULTILINE)
    return content.strip()


def route_to_filepath(route):
    """Convert a route like 'rpa/docs/selenium-ide/' to the output file path."""
    route = route.strip("/")
    if not route:
        return "index.html"
    # If the original route had a trailing slash, make it an index page
    # (we check this from the source)
    return route + ".html"


def parse_routes(controller):
    """
    Extract all (route_path, action_name) pairs from the controller.
    Skips HttpPost actions.
    """
    # Split into blocks by finding each [Route(...)] + public ActionResult pair
    results = []
    # Find all [Route("~/...")] occurrences
    for m in re.finditer(r'\[Route\("~/([^"]*?)"\)\]\s*(?:public\s+ActionResult\s+(\w+))', controller):
        route_path = m.group(1)
        action     = m.group(2)
        results.append((route_path, action))
    return results


def build_view_index():
    """Build a lowercase→actual-path map of all Views/OCR/*.cshtml in git."""
    result = subprocess.run(
        ["git", "show", f"{GIT_REF}", "--name-only", "--format="],
        capture_output=True, text=True, encoding="utf-8", errors="replace", cwd=REPO
    )
    index = {}
    for line in result.stdout.splitlines():
        if line.startswith("Views/OCR/") and line.endswith(".cshtml"):
            basename = line[len("Views/OCR/"):-len(".cshtml")]
            index[basename.lower()] = line
    return index

VIEW_INDEX = None

def find_view_in_git(action_name):
    """Find the cshtml for an action (case-insensitive) in Views/OCR/."""
    global VIEW_INDEX
    if VIEW_INDEX is None:
        VIEW_INDEX = build_view_index()
    git_path = VIEW_INDEX.get(action_name.lower())
    if git_path:
        return git_show(git_path)
    return None


def build_html(body, title, description, extra_scripts):
    head = LAYOUT_HEAD.format(title=title, description=description)
    foot = LAYOUT_FOOT.format(extra_scripts=extra_scripts)
    return head + body + foot


def write_file(rel_path, content):
    full_path = os.path.join(OUT_DIR, rel_path.replace("/", os.sep))
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content)


def main():
    print("Reading controller from git history...")
    controller = git_show("Controllers/OCRController.cs")
    if not controller:
        print("ERROR: Could not read controller from git history")
        sys.exit(1)

    routes = parse_routes(controller)
    print(f"Found {len(routes)} routes")

    done, skipped = 0, []

    for route_path, action in routes:
        # Skip already-converted pages
        if action.lower() in ("index", "contact"):
            continue

        raw = find_view_in_git(action)
        if not raw:
            skipped.append((route_path, action))
            continue

        title       = extract_title(raw)
        raw, scripts = extract_section_scripts(raw)
        body        = clean_razor(raw)

        # Wrap scripts block: strip outer <script> if already present
        extra = ""
        if scripts.strip():
            if scripts.strip().startswith("<script"):
                extra = scripts.strip()
            else:
                extra = f"<script>\n{scripts}\n</script>"

        html = build_html(body, title, title, extra)

        # Determine output path
        trailing_slash = route_path.endswith("/")
        clean = route_path.strip("/")
        if not clean:
            out_path = "index.html"
        elif trailing_slash:
            out_path = clean + "/index.html"
        else:
            out_path = clean + ".html"

        write_file(out_path, html)
        print(f"  OK  /{route_path}  ->  {out_path}")
        done += 1

    print(f"\nDone: {done} pages converted.")
    if skipped:
        print(f"Skipped ({len(skipped)} — view not found in git):")
        for r, a in skipped:
            print(f"  /{r}  (action: {a})")


if __name__ == "__main__":
    main()
