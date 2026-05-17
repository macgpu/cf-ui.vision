export async function onRequest({ request, next }) {
  const url = new URL(request.url);
  const lower = url.pathname.toLowerCase();

  if (lower !== url.pathname) {
    // Skip static assets — only redirect page URLs
    const isAsset = /\.(css|js|png|jpg|jpeg|gif|webp|woff2?|ttf|otf|svg|ico|map|json|xml|txt)$/i.test(url.pathname);
    if (!isAsset) {
      url.pathname = lower;
      return Response.redirect(url.toString(), 301);
    }
  }

  return next();
}
