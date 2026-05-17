export async function onRequest({ request, next }) {
  const url = new URL(request.url);
  const lower = url.pathname.toLowerCase();

  if (lower !== url.pathname) {
    url.pathname = lower;
    return Response.redirect(url.toString(), 301);
  }

  return next();
}
