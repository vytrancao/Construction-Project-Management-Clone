'use client';
import React, { useEffect } from 'react';
import { useSession } from 'next-auth/react';
import { useSearchUsersQuery } from '@/services/user';
import { defaultBaseSearchModel } from '@/domain/models/common/search/BaseSearchModel';

// interface DashboardPageProps {
//
// }

const DashboardPage: React.FC = ({}) => {
  const { data: session, status } = useSession();
  const { data, error, isLoading } = useSearchUsersQuery(defaultBaseSearchModel);

  useEffect(() => {
    console.log(session);
    console.log(status);
    console.log(data);
    console.log(error);
    console.log(isLoading);
  }, [isLoading]);

  return (
    <>

    </>
  );
};

export default DashboardPage;