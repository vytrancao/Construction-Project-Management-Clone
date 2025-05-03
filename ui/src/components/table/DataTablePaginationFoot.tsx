import React from 'react';
import { PaginatedResponse } from '@/domain/models/pagination/paginatedResponse';
import { Pagination, TableCell, TableFooter, TableRow } from '@mui/material';

interface DataTablePaginationFootProps {
  pagination: PaginatedResponse
}

const DataTablePaginationFoot: React.FC<DataTablePaginationFootProps> = ({ pagination }) => {
  const handleChange = (event: React.ChangeEvent<unknown>, value: number) => {
    pagination.setPage(value);
  };

  return (
    <TableFooter>
      <TableRow>
        <TableCell colSpan={0}>
          <Pagination
            count={pagination.pageCount}
            page={pagination.pageIndex}
            onChange={handleChange}
          />
        </TableCell>
      </TableRow>
    </TableFooter>
  );
};

export default DataTablePaginationFoot;