import { useMemo, useState } from 'react';
import { ColumnDef, ColumnFiltersState, getCoreRowModel, SortingState, useReactTable } from '@tanstack/react-table';
import { Identifiable } from '@/hooks/useDataTable';
import { PaginationModel } from '@/domain/models/pagination/pagination.model';
import { DEFAULT_PAGE_SIZE } from '@/domain/constants/paging';

const useServerSideDataTable = <T extends Identifiable>(
  tableData: T[],
  columns: ColumnDef<T, any>[],
  initialPageCount?: number,
  initialState?: any
) => {
  const [ pageIndex, setPageIndex ] = useState(1);
  const [ pageCount, setPageCount ] = useState(initialPageCount ?? -1);
  const [ sorting, setSorting ] = useState<SortingState>(initialState?.sorting ?? []);

  if (!initialState)
    initialState = { sorting: [ { id: "createdAt", desc: true } ] };

  const table = useReactTable({
    data: tableData,
    columns: columns,
    getRowId: (row) => row.id!,
    getCoreRowModel: getCoreRowModel(),
    pageCount: pageCount,
    manualPagination: true,
    manualFiltering: true,
    manualSorting: true,
    initialState: {
      ...initialState,
    },
    state: {
      pagination: {
        pageIndex: pageIndex,
        pageSize: DEFAULT_PAGE_SIZE,
      },
      sorting,
    },
    onSortingChange: setSorting,
  });

  const pages: number[] = useMemo(() => {
    const pages = [];
    for (let i = 0; i < pageCount; i++) {
      pages.push(i);
    }
    return pages;
  }, [ pageCount ]);

  const pagination: PaginationModel = {
    pageIndex,
    pages,
    pageCount,
    setPage: setPageIndex,
    setPageCount,
  };

  return { table, pagination, sorting, filtering: table.getState().columnFilters };
};

export default useServerSideDataTable;