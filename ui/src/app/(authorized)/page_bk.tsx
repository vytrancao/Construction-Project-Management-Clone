import React from 'react';
import { Metadata } from 'next';
import { auth } from '@/auth';

export const metadata: Metadata = {
  title: 'Home',
};

const HomeDashboard: React.FC = async () => {
  const session = await auth();

  if (!session) {
    return null;
  }

  return (
    <>Hello World</>
  );
};

// import { signIn } from "@/auth"
//
// export default function SignIn() {
//   return (
//     <form
//       action={async () => {
//         "use server"
//         await signIn("keycloak")
//       }}
//     >
//       <button type="submit">Signin with Keycloak</button>
//     </form>
//   )
// }


export default HomeDashboard;