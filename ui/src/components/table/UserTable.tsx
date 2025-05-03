import { createColumnHelper } from '@tanstack/react-table';
import { User } from '@/domain/models/user/user';
import { USER_ROLES } from '@/domain/constants/choices';
import { TextFilter } from '@/components/table/filter/TextFilter';

const UserTable = (
  // router: AppRouterInstance, onDeleteClick: (id: string) => void
) => {
  const columnHelper = createColumnHelper<User>();

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