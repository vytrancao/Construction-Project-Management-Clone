import { SortCriterion } from '@/domain/models/common/search/sortCriterion';
import { SearchCriterion } from '@/domain/models/common/search/searchCriterion';

export interface BaseSearchModel {
  searchCriteria: SearchCriterion[];
  sortCriteria: SortCriterion[];
  pageIndex: number;
  pageSize: number;
}

export const defaultBaseSearchModel: BaseSearchModel = {
  searchCriteria: [],
  sortCriteria: [],
  pageIndex: 1,
  pageSize: 10,
};