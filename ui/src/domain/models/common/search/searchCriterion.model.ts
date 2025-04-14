import { CompareOperator } from '@/domain/enums';

export interface SearchCriterionModel {
  propertyPath: string;
  searchValue: string;
  compareOperator: CompareOperator;
}