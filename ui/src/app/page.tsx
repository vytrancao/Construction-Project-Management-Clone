import { signIn } from "@/auth";

export default function SignIn() {
  return (
    <form
      action={async () => {
        "use server";
        await signIn("keycloak", { redirect: true, redirectTo: "/dashboard" });
      }}
    >
      <button type="submit">Signin with Keycloak</button>
    </form>
  );
}