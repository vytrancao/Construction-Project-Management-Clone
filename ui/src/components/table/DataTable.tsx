import React from 'react';
import * as MuiTable from '@mui/material';
import { Table } from "@tanstack/react-table";
import { DataTableBody, DataTableRowNav } from '@/components/table/DataTableBody';
import { DataTableHead } from '@/components/table/DataTableHead';
import DataTablePaginationFoot from '@/components/table/DataTablePaginationFoot';
import { PaginationModel } from '@/domain/models/pagination/pagination.model';

interface DataTableProps<T> {
  table: Table<T>,
  rowNav?: DataTableRowNav,
  pagination: PaginationModel
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