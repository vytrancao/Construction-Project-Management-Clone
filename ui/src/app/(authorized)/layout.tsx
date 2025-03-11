"use client";

import { AppLayout } from '@/components/layouts';
import * as React from 'react';
import { NextAuthProvider } from '@/components/auth';

interface DashboardLayoutProps {
  children: React.ReactNode;
}

const DashboardLayout: React.FC<DashboardLayoutProps> = ({ children }) => {
  return (
    <NextAuthProvider>
      <AppLayout>
        {children}
      </AppLayout>
    </NextAuthProvider>
  );
};

export default DashboardLayout;