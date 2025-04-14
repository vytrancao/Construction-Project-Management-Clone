import { Dispatch, SetStateAction } from 'react';

export interface PaginationModel {
  pageIndex: number;
  pages: number[];
  pageCount: number;
  setPage: Dispatch<SetStateAction<number>>;
}