import React from "react";
import { Cell, flexRender, Table } from "@tanstack/react-table";
import { useRouter } from "next/navigation";
import { TableBody, TableCell, TableRow } from '@mui/material';

export interface DataTableRowNav {
  navPath: string,
  getNavInfo?: (id: string) => string
}

interface DataTableBodyProps<T> {
  table: Table<T>,
  rowNav?: DataTableRowNav,
}

export const DataTableBody = <T, >({ table, rowNav }: DataTableBodyProps<T>) => {
  const router = useRouter();
  const getNav = (cell: Cell<T, unknown>) => {
    const colMeta = cell.column.columnDef.meta;
    if (!rowNav) {
      return null;
    }

    if (colMeta?.allowNav === false) {
      return null;
    }

    const cellNavLink = colMeta?.cellNavLink;
    const navInfo = rowNav.getNavInfo ? rowNav.getNavInfo(cell.row.id) : cell.row.id;
    return router.push((cellNavLink ? cellNavLink(cell) : `${rowNav.navPath}/${navInfo}`));
  };

  return (
    <TableBody>
      {table.getRowModel().rows.map(row => (
        <TableRow
          style={rowNav ? { cursor: 'pointer' } : {}}
          v-for="item in tableItems" key={row.id}>
          {row.getVisibleCells().map(cell =>
            <TableCell
              style={{ backgroundColor: cell.column.columnDef.meta?.getColor ? cell.column.columnDef.meta?.getColor!(cell) : '' }}
              className={`${cell.column.columnDef.meta?.regionEnd ? 'border-end' : ''}`}
              onClick={() => getNav(cell)} key={cell.id}>
              <div className="ps-2">
                {flexRender(cell.column.columnDef.cell, cell.getContext())}
              </div>
            </TableCell>
          )}
        </TableRow>
      ))}
    </TableBody>
  );
};