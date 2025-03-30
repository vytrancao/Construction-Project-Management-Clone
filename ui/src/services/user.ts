import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { UserModel } from '@/domain/models/user/UserModel';
import { BaseSearchModel } from '@/domain/models/common/search/BaseSearchModel';
import { getSession } from 'next-auth/react';
import { Session } from 'next-auth';

const addTokenToRequest = async (headers: Headers) => {
  const session: Session | null = await getSession();
  if (session?.accessToken) {
    headers.set("Authorization", `Bearer ${session.accessToken}`);
  }
  return headers;
};

// Define a service using a base URL and expected endpoints
export const userApi = createApi({
  reducerPath: 'userApi',
  baseQuery: fetchBaseQuery({
    baseUrl: 'http://localhost:3003/idp/',
    prepareHeaders: (headers) => {
      return addTokenToRequest(headers);
    },
  }),
  endpoints: (builder) => ({
    searchUsers: builder.query<UserModel, BaseSearchModel>({
      query: (request: BaseSearchModel) => ({
        url: 'Users/Search',
        method: 'POST',
        body: request,
      }),
    }),
  }),
});

export const { useSearchUsersQuery } = userApi;