import { UserRole } from '@/domain/enums/userRole';

export interface User {
  id: string;
  email: string;
  firstName: string;
  lastName: string;
  phone: string;
  address: string;
  role: UserRole;
  identityUserId?: string;
}