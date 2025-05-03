export class SearchResponse<T> {
  pageIndex: number;
  pageSize: number;
  totalPage: number;
  items: T[];

  constructor(
    pageIndex: number = 0,
    pageSize: number = 0,
    totalPage: number = 0,
    items: T[] = []
  ) {
    this.pageIndex = pageIndex;
    this.pageSize = pageSize;
    this.totalPage = totalPage;
    this.items = items;
  }
}