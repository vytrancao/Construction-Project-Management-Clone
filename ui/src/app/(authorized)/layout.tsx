"use client";

import { AppLayout } from '@/components/layouts';
import * as React from 'react';
import { Provider } from 'react-redux';
import { store } from '@/store';

interface DashboardLayoutProps {
  children: React.ReactNode;
}

const DashboardLayout: React.FC<DashboardLayoutProps> = ({ children }) => {
  return (
    <Provider store={store}>
      <AppLayout>
        {children}
      </AppLayout>
    </Provider>
  );
};

export default DashboardLayout;