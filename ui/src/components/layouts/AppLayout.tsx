import * as React from 'react';
import CssBaseline from '@mui/material/CssBaseline';
import Box from '@mui/material/Box';
import Stack from '@mui/material/Stack';
import { AppNavbar, Header, SideMenu } from '@/components/layouts/index';

interface AppLayoutProps {
  children: React.ReactNode;
}

const AppLayout: React.FC<AppLayoutProps> = ({ children }) => {
  return (
    <React.Fragment>
      <CssBaseline enableColorScheme/>
      <Box sx={{ display: 'flex' }}>
        <SideMenu/>
        <AppNavbar/>
        {/* Main content */}
        <Box
          component="main"
          sx={() => ({
            flexGrow: 1,
            overflow: 'auto',
          })}
        >
          <Stack
            spacing={2}
            sx={{
              alignItems: 'center',
              mx: 3,
              pb: 5,
              mt: { xs: 8, md: 0 },
            }}
          >
            <Header/>
            {children}
          </Stack>
        </Box>
      </Box>
    </React.Fragment>
  );
};

export default AppLayout;