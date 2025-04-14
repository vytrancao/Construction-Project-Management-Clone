import { UserRole } from '@/domain/enums/userRole';
import { Dictionary } from '@/domain/models/common/dictionary';


export const USER_ROLES: Dictionary<string, number> = {
  data: [
    { key: "Admin", value: UserRole.Admin, },
    { key: "Employee", value: UserRole.Employee, },
    { key: "Client", value: UserRole.Client, },
  ]
};