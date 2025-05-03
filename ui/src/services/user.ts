import { User } from '@/domain/models/user/user';
import httpClient from '@/services/httpClient';
import * as api from '@/api';
import { SearchRequest } from '@/domain/models/common/search/searchRequest';
import { SearchResponse } from '@/domain/models/common/search/searchResponse';

export default class UserService {
  public static async searchUser(request: SearchRequest): Promise<SearchResponse<User>> {
    const response = await httpClient.post(api.idp.user.search.url, request);
    return response.data;
  }
}