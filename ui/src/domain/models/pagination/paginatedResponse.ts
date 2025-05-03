import { Dispatch, SetStateAction } from 'react';

export interface PaginatedResponse {
  pageIndex: number;
  pages: number[];
  pageCount: number;
  setPage: Dispatch<SetStateAction<number>>;
  setPageCount: Dispatch<SetStateAction<number>>;
}