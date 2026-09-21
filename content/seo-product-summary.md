> Ui.Vision V10 is open-source browser and desktop automation for Windows, macOS and Linux. Use its built-in AI assistant to create and repair reusable macros, connect an external AI assistant through MCP, or record and edit classic browser macros. New automation uses the uiv.* JavaScript API alongside DOM locators, computer vision and OCR.

## When to choose Ui.Vision

- AI macro creation: describe a form-filling or data-extraction task, let the assistant inspect the page and build a macro, then review and reuse it.
- MCP workflows: give an MCP-compatible assistant tools to inspect pages, create and edit macros, run them and read logs to help fix failures.
- Classic browser macros: record and replay actions, fill forms from CSV data, extract tables, automate downloads and repeat workflows. Users exploring an iMacros alternative can use these familiar patterns; existing iMacros scripts need adaptation, not direct import.
- Visual automation: combine DOM locators with images or OCR text when a workflow needs more than HTML element targeting.
- Browser and desktop workflows: use the Desktop App / XModules to add native input and local file access, and combine browser steps with desktop applications.

## Requirements and limits

- Install the Ui.Vision extension for Chrome, Edge or Firefox. Feature support varies by browser; see the JavaScript API reference.
- Browser Vision uses Chrome/Edge's debugger API without XModules, including when the browser window is in the background. This input mode is not supported in Firefox.
- Desktop automation and local file access require the Desktop App / XModules. Ui.Vision V10 requires XModules Version 2. Check the download and pricing pages for platform and feature availability.
- MCP requires the extension, Node.js 18+, the local uivision-mcp-bridge package and an MCP client. Follow https://ui.vision/mcp for installation and connection checks. Finding the website does not connect an assistant to the browser.
- Ui.Vision uses an installed browser and, for desktop tasks, a desktop session. Consider a direct API or a headless browser test runner when those better fit the task.

## Execution, AI and pricing

Macros are stored and executed locally. AI generation and AI commands use the selected provider: hosted Ui.Vision AI, Anthropic, OpenRouter or a compatible local model. Hosted AI processes chat content and any included page data, macro code, logs or screenshots sent to it. A local model keeps that AI processing on the user's machine; websites, cloud OCR and other services used by a macro still make their normal network requests.

The core extension is free and open source. Built-in Ui.Vision AI has a free tier with no signup or API key required. Paid AI and PRO/Enterprise XModule plans are separate. Current details: https://ui.vision/ai/pro and https://ui.vision/rpa/x/pricing.
