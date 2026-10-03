/* global document navigator */
'use strict';
// Both sharing pages use the same browser-to-store selection.
(() => {
  const ua = navigator.userAgent || '';
  const brands = (navigator.userAgentData?.brands || []).map(item => item.brand);
  let url;
  // Edge also identifies as Chrome, so its store must take precedence.
  if (/\b(?:Edg|Edge|EdgA|EdgiOS)\//.test(ua) || brands.includes('Microsoft Edge')) url = 'https://microsoftedge.microsoft.com/addons/detail/uivision/goapmjinbaeomoemgdcnnhoedopjnddd';
  else if (/\b(?:Firefox|FxiOS)\//.test(ua)) url = 'https://addons.mozilla.org/en-US/firefox/addon/rpa/';
  else if (/\b(?:Chrome|Chromium|CriOS)\//.test(ua) || brands.some(brand => ['Google Chrome', 'Chromium'].includes(brand))) url = 'https://chromewebstore.google.com/detail/uivision/gcbalfbdmfieckjlnblleoemohcganoc';
  // Unknown browsers and disabled JavaScript keep the page's fallback link.
  if (url) for (const link of document.querySelectorAll('a[data-browser-install]')) link.href = url;
})();
