import { PaginatedResponse } from '@/domain/models/pagination/paginatedResponse';
import { ColumnDef, getCoreRowModel, getFilteredRowModel, getPaginationRowModel, getSortedRowModel, useReactTable } from '@tanstack/react-table';
import { useMemo, useState } from 'react';

export interface Identifiable {
  id?: string;
}

const useDataTable = <T extends Identifiable>(
  tableData: T[],
  columns: ColumnDef<T, any>[],
  paginate?: boolean,
  initialState?: any
) => {
  const [ pageIndex, setPageIndex ] = useState(0);
  const pageSize = process.env.NEXT_PUBLIC_PAGE_SIZE ? parseInt(process.env.NEXT_PUBLIC_PAGE_SIZE) : 10;

  if (!initialState)
    initialState = { sorting: [ { id: "createdAt", desc: true } ] };

  const table = useReactTable({
    data: tableData,
    columns: columns,
    getRowId: (row) => row.id!,
    getCoreRowModel: getCoreRowModel(),
    getSortedRowModel: getSortedRowModel(),
    getFilteredRowModel: getFilteredRowModel(),
    getPaginationRowModel: paginate ? getPaginationRowModel() : undefined,
    initialState: {
      ...initialState,
    },
    state: {
      pagination: {
        pageIndex: pageIndex,
        pageSize: pageSize, //custom default page size
      },
    }
  });

  const pageCount = tableData?.length > pageSize ? table.getPageCount() : 1;
  const pages: number[] = useMemo(() => {
    const pages = [];
    for (let i = 0; i < pageCount; i++) {
      pages.push(i);
    }
    return pages;
  }, [ pageCount ]);

  const pagination: PaginatedResponse = {
    pageIndex,
    pages,
    pageCount,
    setPage: setPageIndex,
    setPageCount: () => {}
  };

  return { table, pagination };
};

export default useDataTable;