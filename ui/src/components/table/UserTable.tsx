import { createColumnHelper } from '@tanstack/react-table';
import { UserModel } from '@/domain/models/user/user.model';
import { USER_ROLES } from '@/domain/constants/choices';
import { TextFilter } from '@/components/table/filter/TextFilter';

const UserTable = (
  // router: AppRouterInstance, onDeleteClick: (id: string) => void
) => {
  const columnHelper = createColumnHelper<UserModel>();

  const getUserDisplayRole = (role: number) => USER_ROLES.data.find(x => x.value === role)?.key;

  return [
    columnHelper.display({
      header: "Name",
      cell: ({ row: { original } }) => original.firstName + ' ' + original.lastName
    }),
    columnHelper.accessor('email', {
      header: "Email",
      meta: {
        filterHeader: header => <TextFilter column={header.column} isServerSide/>,
      }
    }),
    columnHelper.accessor('role', {
      header: "Role",
      cell: cell => getUserDisplayRole(cell.getValue()),
    }),
  ];
};

export default UserTable;