import { signIn } from "@/auth";

export default function SignIn() {
  return (
    <form
      action={async () => {
        "use server";
        await signIn("keycloak", { callbackUrl: "http://localhost:3001/dashboard" });
      }}
    >
      <button type="submit">Signin with Keycloak</button>
    </form>
  );
}