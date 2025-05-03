import { SearchRequest } from '@/domain/models/common/search/searchRequest';

export const idp = {
  user: {
    search: {
      url: '/idp/users/search',
      key: (request: SearchRequest) => [ 'users', request ],
    }
  }
};