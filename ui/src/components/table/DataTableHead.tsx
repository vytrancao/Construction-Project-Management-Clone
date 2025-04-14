import React, { Fragment } from "react";
import { flexRender, Table } from "@tanstack/react-table";
import { DataTableSortIcon } from "./DataTableSortIcon";
import { TableCell, TableHead, TableRow } from '@mui/material';

interface DataTableHeadProps<T> {
  table: Table<T>,
}

export const DataTableHead = <T, >({ table }: DataTableHeadProps<T>) => (
  <TableHead>
    {table.getHeaderGroups().map(headerGroup => (
      <Fragment key={headerGroup.id}>
        <TableRow>
          {headerGroup.headers.map(header => (
            <TableCell className={`bg-body-tertiary ${header.column.columnDef.meta?.regionEnd ? 'border-end' : ''}`} key={header.id}>
              {header.isPlaceholder
                ? null
                : flexRender(
                  header.column.columnDef.header,
                  header.getContext()
                )}
              <DataTableSortIcon column={header.column}/>
            </TableCell>
          ))}
        </TableRow>
        <TableRow>
          {headerGroup.headers.map((header, index) => (
            <TableCell className={`${header.column.columnDef.meta?.regionEnd ? 'border-end' : ''}`} key={index}>
              {header.column.columnDef.meta?.filterHeader
                ? header.column.columnDef.meta?.filterHeader!(header)
                : null
              }
            </TableCell>
          ))}
        </TableRow>
      </Fragment>
    ))}
  </TableHead>
);