import axios from 'axios';
import { Session } from 'next-auth';
import { getSession } from 'next-auth/react';

const httpClient = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_BASE_URL,
});

httpClient.interceptors.request.use(
  async (config) => {
    // Retrieve the token from local storage
    const session: Session | null = await getSession();

    // If the token exists, add it to the headers
    if (session?.accessToken && config.headers) {
      console.log(session.accessToken);
      config.headers.Authorization = `Bearer ${session.accessToken}`;
    }

    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

export default httpClient;