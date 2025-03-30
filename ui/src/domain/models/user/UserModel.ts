import { UserRole } from '@/domain/enums/UserRole';

export interface UserModel {
  id: string;
  email: string;
  firstName: string;
  lastName: string;
  role: UserRole;
  identityUserId?: string;
}