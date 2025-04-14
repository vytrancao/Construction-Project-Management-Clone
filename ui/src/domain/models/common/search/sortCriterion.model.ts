import { SortOrder } from '@/domain/enums';

export interface SortCriterionModel {
  propertyPath: string;
  order: SortOrder;
}