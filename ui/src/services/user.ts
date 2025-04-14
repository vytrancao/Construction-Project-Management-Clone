import { UserModel } from '@/domain/models/user/user.model';
import httpClient from '@/services/httpClient';
import * as api from '@/api';
import { SearchModel } from '@/domain/models/common/search/search.model';
import { SearchResponseModel } from '@/domain/models/common/search/searchResponse.model';

export default class UserService {
  public static async searchUser(request: SearchModel): Promise<SearchResponseModel<UserModel>> {
    const response = await httpClient.post(api.idp.user.search.url, request);
    return response.data.message;
  }
}