export async function onRequest({ request, next, env }) {
  const url = new URL(request.url);
  const lower = url.pathname.toLowerCase();

  if (lower !== url.pathname) {
    url.pathname = lower;
    return Response.redirect(url.toString(), 301);
  }

  const response = await next();

  const contentType = response.headers.get("content-type") || "";
  if (!contentType.includes("text/html")) return response;

  const version = (env.CF_PAGES_COMMIT_SHA || "dev").slice(0, 7);
  const body = await response.text();
  const modified = body.replace(
    'id="site-version"></span>',
    `id="site-version">${version}</span>`
  );

  return new Response(modified, {
    status: response.status,
    statusText: response.statusText,
    headers: response.headers,
  });
}
