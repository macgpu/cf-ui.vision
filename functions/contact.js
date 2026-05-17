export async function onRequestPost({ request, env }) {
  const formData = await request.formData();

  const name     = (formData.get("ContactName") ?? "").trim();
  const email    = (formData.get("Email")        ?? "").trim();
  const software = (formData.get("WhatSoftware") ?? "").trim();
  const antispam = (formData.get("antispam")     ?? "").trim();
  const subject  = (formData.get("Subject")      ?? "").trim();
  const message  = (formData.get("Message")      ?? "").trim();

  const base = new URL(request.url).origin + "/contact";
  const err  = (msg) => Response.redirect(`${base}?error=${encodeURIComponent(msg)}`, 303);

  if (!name)                                      return err("Your contact name is required");
  if (!email || !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email))
                                                  return err("A valid email address is required");
  if (!software)                                  return err("Please select a topic in the dropdown");
  if (antispam !== "899")                         return err("Anti-spam check failed — please enter 899");
  if (subject.length < 5 || subject.length > 300) return err("Subject must be 5–300 characters");
  if (message.length < 10 || message.length > 10000) return err("Message must be 10–10 000 characters");

  const html = [
    `<p><b>Name:</b> ${name}</p>`,
    `<p><b>Email:</b> ${email}</p>`,
    `<p><b>Topic:</b> ${software}</p>`,
    `<p><b>Message:</b><br>${message.replace(/\r?\n/g, "<br>")}</p>`,
  ].join("\n");

  const res = await fetch("https://api.resend.com/emails", {
    method: "POST",
    headers: {
      Authorization: `Bearer ${env.RESEND_API_KEY}`,
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      from: "contact-form@ui.vision",
      to: env.CONTACT_TO_EMAIL ?? "team@ui.vision",
      reply_to: email,
      subject: `Contact form: ${subject}`,
      html,
    }),
  });

  if (!res.ok) return err("Unable to send — please try again later");

  return Response.redirect(`${base}?success=1`, 303);
}
