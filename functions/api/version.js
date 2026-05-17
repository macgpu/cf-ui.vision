export function onRequestGet({ env }) {
  const sha = env.CF_PAGES_COMMIT_SHA ?? "dev";
  return new Response(JSON.stringify({ version: sha.slice(0, 7) }), {
    headers: { "Content-Type": "application/json", "Cache-Control": "public, max-age=3600" },
  });
}
