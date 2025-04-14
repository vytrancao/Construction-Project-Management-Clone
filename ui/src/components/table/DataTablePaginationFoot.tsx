import React from 'react';
import { PaginationModel } from '@/domain/models/pagination/pagination.model';
import { Pagination, TableCell, TableFooter, TableRow } from '@mui/material';

interface DataTablePaginationFootProps {
  pagination: PaginationModel
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