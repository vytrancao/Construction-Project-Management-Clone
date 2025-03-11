import React from 'react';
import { auth } from '@/auth';

const HomeDashboard: React.FC = async () => {
  const session = await auth();

  if (!session) {
    return null;
  }

  return (
    <>Hello World</>
  );
};

export default HomeDashboard;