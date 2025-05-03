import React from 'react';
import * as MuiTable from '@mui/material';
import { Table } from "@tanstack/react-table";
import { DataTableBody, DataTableRowNav } from '@/components/table/DataTableBody';
import { DataTableHead } from '@/components/table/DataTableHead';
import DataTablePaginationFoot from '@/components/table/DataTablePaginationFoot';
import { PaginatedResponse } from '@/domain/models/pagination/paginatedResponse';

interface DataTableProps<T> {
  table: Table<T>,
  rowNav?: DataTableRowNav,
  pagination: PaginatedResponse
}

const DataTable = <T, >({ table, rowNav, pagination }: DataTableProps<T>) => {
  return (
    <MuiTable.TableContainer>
      <MuiTable.Table>
        <DataTableHead table={table}/>
        <DataTableBody table={table} rowNav={rowNav}/>
        <DataTablePaginationFoot pagination={pagination} />
      </MuiTable.Table>
    </MuiTable.TableContainer>
  );
};

export default DataTable;