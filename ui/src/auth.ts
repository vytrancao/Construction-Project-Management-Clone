import NextAuth from "next-auth";
import Keycloak from "next-auth/providers/keycloak";
import "next-auth/jwt";

export const { handlers, auth, signIn } = NextAuth({
  debug: !!process.env.AUTH_DEBUG,
  providers: [
    Keycloak,
  ],
  basePath: "/auth",
  session: { strategy: "jwt" },
  callbacks: {
    authorized({ request, auth }) {
      const { pathname } = request.nextUrl;
      if (pathname === "/middleware-example") return !!auth;
      return true;
    },
    async jwt({ token, account }) {
      if (account && account?.provider === "keycloak") {
        // First-time login, save the `access_token`, its expiry and the `refresh_token`
        return {
          ...token,
          accessToken: account.access_token,
          expiresAt: account.expires_at,
          refreshToken: account.refresh_token,
        };
      } else {
        // @ts-expect-error authjs
        if (Date.now() < token.expires_at * 1000) {
          // Subsequent logins, but the `access_token` is still valid
          return token;
        } else {
          // Subsequent logins, but the `access_token` has expired, try to refresh it
          try {
            const response = await fetch(`${process.env.AUTH_KEYCLOAK_ISSUER}/protocol/openid-connect/token`, {
              method: "POST",
              body: new URLSearchParams(
                {
                  client_id: process.env.AUTH_KEYCLOAK_ID!,
                  client_secret: process.env.AUTH_KEYCLOAK_SECRET!,
                  grant_type: "refresh_token",
                  refresh_token: token.refreshToken!,
                }),
            });

            const tokensOrError = await response.json();

            if (!response.ok) throw tokensOrError;

            const newTokens = tokensOrError as {
              access_token: string
              expires_in: number
              refresh_token?: string
            };

            return {
              ...token,
              accessToken: newTokens.access_token,
              expiresAt: Math.floor(Date.now() / 1000 + newTokens.expires_in),
              // Some providers only issue refresh tokens once, so preserve if we did not get a new one
              refreshToken: newTokens.refresh_token
                ? newTokens.refresh_token
                : token.refreshToken,
            };
          } catch (error) {
            console.error("Error refreshing access_token", error);
            // If we fail to refresh the token, return an error so we can handle it on the page
            token.error = "RefreshTokenError";
            return token;
          }
        }
      }
    },
    async session({ session, token }) {
      if (token?.accessToken) {
        session.accessToken = token.accessToken;
        session.expiresAt = token.expiresAt;
        session.refreshToken = token.refreshToken;
      }

      return session;
    },
  },
  experimental: { enableWebAuthn: true },
  trustHost: true,
  secret: process.env.AUTH_SECRET,
});

declare module "next-auth" {
  interface Session {
    accessToken?: string,
    expiresAt?: number,
    refreshToken?: string
  }
}

declare module "next-auth/jwt" {
  interface JWT {
    accessToken?: string,
    expiresAt?: number,
    refreshToken?: string
  }
}