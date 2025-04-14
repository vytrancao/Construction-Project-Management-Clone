import { SortCriterionModel } from '@/domain/models/common/search/sortCriterion.model';
import { SearchCriterionModel } from '@/domain/models/common/search/searchCriterion.model';

export interface SearchModel {
  searchCriteria: SearchCriterionModel[];
  sortCriteria: SortCriterionModel[];
  pageIndex: number;
  pageSize: number;
}

export const defaultBaseSearchModel: SearchModel = {
  searchCriteria: [],
  sortCriteria: [],
  pageIndex: 1,
  pageSize: 10,
};