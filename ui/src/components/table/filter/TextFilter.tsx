import React from 'react';
import { Column } from '@tanstack/react-table';
import { CompareOperator } from '@/domain/enums';
import { SearchCriterionModel } from '@/domain/models/common/search/searchCriterion.model';
import { TextField } from '@mui/material';

interface TextFilterProps<T> {
  column: Column<T>,
  isServerSide?: boolean;
}

export const TextFilter = <T, >({ column, isServerSide }: TextFilterProps<T>) => {
  const setFilterValue = (value: string) => {
    if (isServerSide) {
      const searchCriterion: SearchCriterionModel = {
        propertyPath: column.id,
        searchValue: value,
        compareOperator: CompareOperator.Contains
      };
      column?.setFilterValue(searchCriterion);
    } else {
      column?.setFilterValue(value);
    }
  };

  const getFilterValue = (): string => {
    if (isServerSide) {
      return ((column?.getFilterValue() ?? '') as SearchCriterionModel).searchValue as string;
    } else {
      return (column?.getFilterValue() ?? '') as string;
    }
  };

  return <TextField
    value={getFilterValue()}
    onChange={e => setFilterValue(e.target.value)}
    placeholder="Search ..." autoComplete="new-password"/>;
};