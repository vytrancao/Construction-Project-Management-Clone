import { CompareOperator } from '@/domain/enums';

export interface SearchCriterion {
  propertyPath: string;
  searchValue: string;
  compareOperator: CompareOperator;
}