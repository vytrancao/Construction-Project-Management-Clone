import React from 'react';
import { auth } from '@/auth';
import { SessionProvider } from 'next-auth/react';
import DashboardPage from '@/app/(authorized)/dashboard/DashboardPage';

const HomeDashboard: React.FC = async () => {
  const session = await auth();

  if (!session) {
    return null;
  }

  return (
    <SessionProvider basePath={"/auth"} session={session}>
      <DashboardPage/>
    </SessionProvider>
  );
};

export default HomeDashboard;