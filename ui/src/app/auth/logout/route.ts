export async function POST() {
  const path = `${process.env.AUTH_KEYCLOAK_ISSUER}/protocol/openid-connect/logout\
?post_logout_redirect_uri=${process.env.NEXTAUTH_URL!}\
&client_id=${process.env.AUTH_KEYCLOAK_ID}`;

  return Response.json({ path });
};