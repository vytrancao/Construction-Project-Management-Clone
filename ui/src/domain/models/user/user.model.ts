import { UserRole } from '@/domain/enums/userRole';

export class UserModel {
  id!: string;
  email!: string;
  firstName!: string;
  lastName!: string;
  role!: UserRole;
  identityUserId?: string;
  name: string = `${this.firstName} ${this.lastName}`;
}