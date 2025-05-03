import React from 'react';
import { auth } from '@/auth';
import { SessionProvider } from 'next-auth/react';
import ProjectCreatePage from '@/app/(authorized)/projects/create/ProjectCreatePage';

interface ProjectCreateProps {

}

const ProjectCreate: React.FC<ProjectCreateProps> = async ({}) => {
  const session = await auth();

  return (
    <SessionProvider basePath={"/auth"} session={session}>
      <ProjectCreatePage/>
    </SessionProvider>
  );
};

export default ProjectCreate;