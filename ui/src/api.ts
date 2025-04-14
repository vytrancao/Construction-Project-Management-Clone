import { SearchModel } from '@/domain/models/common/search/search.model';

export const idp = {
  user: {
    search: {
      url: '/idp/users/search',
      key: (request: SearchModel) => [ 'users', request ],
    }
  }
};