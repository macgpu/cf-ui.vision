// Run from the repository root: node scripts/update-seo.mjs
// Curates public product/docs URLs; leaves demos, archives and test fixtures alone.
import fs from 'node:fs';
import { execFileSync } from 'node:child_process';

const files = execFileSync('git', ['ls-files', '*.html'], { encoding: 'utf8' }).trim().split(/\r?\n/);
const origin = 'https://ui.vision';
const routeFor = file => file === 'index.html' ? '/' : '/' + file.replace(/\/index\.html$/, '').replace(/\.html$/, '');
const redirects = new Map(fs.readFileSync('_redirects', 'utf8').trim().split(/\r?\n/).map(line => line.split(/\s+/).slice(0, 2)));
const core = new Set(['index.html', 'rpa.html', 'ai.html', 'mcp.html', 'about.html', 'contact.html', 'rpa/home/welcome.html', 'rpa/home/whatsnew.html', 'rpa/x.html']);
const articles = new Set(['blog/index.html', 'blog/imacros-alternatives/index.html', 'blog/computer-use/index.html', 'blog/computer-use-in-browser/index.html']);
const selected = files.filter(file => file !== 'rpa/x/pricing2.html' && (core.has(file) || articles.has(file) || /^(ai|rpa\/docs|rpa\/x)\//.test(file)));
const metadata = {
  'index.html': ['Ui.Vision V10 - AI Browser Automation, Desktop App & MCP', 'Build reusable browser and desktop macros with Ui.Vision V10. Use AI, connect an assistant through MCP, or record classic workflows with vision and OCR.'],
  'rpa.html': ['Ui.Vision V10 - AI, MCP & Classic Browser Automation', 'Automate forms, CSV tasks, scraping and downloads. Use AI-created macros, MCP assistants or classic recording with open-source Ui.Vision for browser and desktop.'],
  'ai.html': ['Ui.Vision AI - Create and Repair Browser Automation Macros', 'Describe a browser task and let Ui.Vision AI build and help repair a reusable macro. Choose built-in AI, your own provider or a local model.'],
  'mcp.html': ['Ui.Vision MCP Server - Browser Automation for AI Assistants', 'Connect an MCP-compatible AI assistant to Ui.Vision. Inspect pages, create reusable macros, run browser workflows and read logs to help fix failures.'],
  'rpa/docs/index.html': ['Ui.Vision Docs - JavaScript, AI, MCP & Classic Macros', 'Learn Ui.Vision browser and desktop automation: the uiv JavaScript API, AI macro creation, MCP setup, classic commands, CSV workflows, vision and OCR.'],
  'rpa/x.html': ['Ui.Vision Desktop App / XModules - Desktop Automation', 'Go beyond the browser with Ui.Vision Desktop App / XModules. Automate desktop apps, access local files and combine browser and desktop steps.'],
  'rpa/x/pricing.html': ['Ui.Vision Pricing - RPA PRO & Enterprise XModules', 'Compare Ui.Vision RPA PRO and Enterprise XModule plans for browser and desktop automation. Review included features and choose a plan for your workflows.']
};
const escape = value => value.replaceAll('&', '&amp;').replaceAll('"', '&quot;').replaceAll('<', '&lt;');
function write(file, content) {
  const previous = fs.readFileSync(file, 'utf8');
  const eol = previous.includes('\r\n') ? '\r\n' : '\n';
  content = content.replace(/\r?\n/g, eol);
  if (content !== previous) {
    fs.writeFileSync(file + '.seo-tmp', content);
    fs.renameSync(file + '.seo-tmp', file);
  }
}
const urls = new Set();
for (const file of selected) {
  let html = fs.readFileSync(file, 'utf8');
  const route = routeFor(file);
  if (redirects.has(route) || /<meta[^>]+content=["'][^"']*noindex/i.test(html)) continue;
  if (metadata[file]) {
    const [title, description] = metadata[file];
    html = html.replace(/<title>[\s\S]*?<\/title>/i, `<title>${escape(title)}</title>`);
    const tag = `<meta name="description" content="${escape(description)}">`;
    html = /<meta\s+name="description"[^>]*>/i.test(html) ? html.replace(/<meta\s+name="description"[^>]*>/i, tag) : html.replace('</title>', `</title>\n    ${tag}`);
  }
  let canonical = html.match(/<link\s+rel="canonical"\s+href="([^"]+)"[^>]*>/i)?.[1];
  if (!canonical) {
    canonical = origin + route;
    html = html.replace('</title>', `</title>\n    <link rel="canonical" href="${canonical}">`);
  }
  if (canonical.startsWith(origin + '/')) urls.add(canonical);
  write(file, html);
}
const sitemap = '<?xml version="1.0" encoding="UTF-8"?>\n<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">\n' + [...urls].sort().map(url => `  <url><loc>${escape(url)}</loc></url>`).join('\n') + '\n</urlset>\n';
fs.writeFileSync('sitemap.xml', sitemap);

const summary = fs.readFileSync('content/seo-product-summary.md', 'utf8').trim();
for (const [file, heading, marker] of [
  ['llms.txt', '# Ui.Vision - AI browser and desktop automation', '## Start here'],
  ['llms-full.txt', '# Ui.Vision - AI browser and desktop automation: full text for LLMs', '## Key concepts']
]) {
  const text = fs.readFileSync(file, 'utf8');
  const index = text.indexOf(marker);
  if (index < 0) throw new Error(`Missing summary boundary in ${file}`);
  write(file, `${heading}\n\n${summary}\n\n${text.slice(index)}`);
}
console.log(`Updated SEO metadata and ${urls.size} sitemap URLs; synchronized AI product summaries.`);
