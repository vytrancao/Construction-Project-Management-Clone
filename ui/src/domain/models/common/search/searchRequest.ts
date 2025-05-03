import { SortCriterion } from '@/domain/models/common/search/sortCriterion';
import { SearchCriterion } from '@/domain/models/common/search/searchCriterion';

export interface SearchRequest {
  searchCriteria: SearchCriterion[];
  sortCriteria: SortCriterion[];
  pageIndex: number;
  pageSize: number;
}

export const defaultBaseSearchModel: SearchRequest = {
  searchCriteria: [],
  sortCriteria: [],
  pageIndex: 1,
  pageSize: 10,
};