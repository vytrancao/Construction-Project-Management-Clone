import { SortOrder } from '@/domain/enums';

export interface SortCriterion {
  propertyPath: string;
  order: SortOrder;
}