'use client';
import React, { useEffect } from 'react';
import UserService from '@/services/user';
import { keepPreviousData, useQuery } from '@tanstack/react-query';
import { idp } from '@/api';
import { Paper } from '@mui/material';
import { defaultBaseSearchModel } from '@/domain/models/common/search/search.model';
import UserTable from '@/components/table/UserTable';
import useServerSideDataTable from '@/hooks/useServerSideDataTable';
import { DataTable } from '@/components/table';
import { SortOrder } from '@/domain/enums';
import { SearchCriterionModel } from '@/domain/models/common/search/searchCriterion.model';

const DashboardPage: React.FC = ({}) => {
  const [ userSearchRequest, setUserSearchRequest ] = React.useState(defaultBaseSearchModel);

  const { data: userResult, isFetched } = useQuery({
    queryKey: idp.user.search.key(userSearchRequest),
    queryFn: async () => await UserService.searchUser(userSearchRequest),
    placeholderData: keepPreviousData,
  });

  const { table, pagination, sorting, filtering } = useServerSideDataTable(userResult?.items || [], UserTable());

  useEffect(() => {
    pagination.setPageCount(userResult?.totalPage ?? 0);
  }, [ isFetched ]);

  useEffect(() => {
    setUserSearchRequest({
      ...userSearchRequest,
      pageIndex: pagination.pageIndex - 1,
      sortCriteria: sorting.map(x => {
        return {
          propertyPath: x.id,
          order: x.desc ? SortOrder.Desc : SortOrder.Asc,
        };
      }),
      searchCriteria: filtering.filter(x => !!(x.value as SearchCriterionModel).searchValue).map(x => {
        const searchCriterion = x.value as SearchCriterionModel;
        return {
          propertyPath: x.id,
          searchValue: searchCriterion.searchValue,
          compareOperator: searchCriterion.compareOperator,
        };
      }),
    });
  }, [ pagination.pageIndex, sorting, filtering ]);

  useEffect(() => {
    console.log(filtering);
  }, [ filtering ]);

  return (
    <>
      <Paper sx={{ width: '100%' }}>
        <DataTable table={table} pagination={pagination}/>
      </Paper>
    </>
  );
};

export default DashboardPage;