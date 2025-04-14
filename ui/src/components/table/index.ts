import { Cell, Header } from "@tanstack/react-table";
import DataTable from "./DataTable";
import { ReactElement } from 'react';
import { Property } from 'csstype';

interface AppColumnMetaData<TData, TValue> {
  filterHeader?: (header: Header<TData, TValue>) => ReactElement,
  cellNavLink?: (cell: Cell<TData, unknown>) => string,
  allowNav?: boolean,
  regionEnd?: boolean,
  getColor?: (cell: Cell<TData, unknown>) => Property.Color
}

declare module '@tanstack/react-table' {
  interface ColumnMeta<TData, TValue> extends AppColumnMetaData<TData, TValue> {
  }
}

export {
  DataTable
};