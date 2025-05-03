'use client';
import React, { useEffect } from 'react';
import UserService from '@/services/user';
import { keepPreviousData, useQuery } from '@tanstack/react-query';
import { idp } from '@/api';
import { Paper } from '@mui/material';
import { defaultBaseSearchModel } from '@/domain/models/common/search/searchRequest';
import UserTable from '@/components/table/UserTable';
import useServerSideDataTable from '@/hooks/useServerSideDataTable';
import { DataTable } from '@/components/table';
import { SortOrder } from '@/domain/enums';
import { SearchCriterion } from '@/domain/models/common/search/searchCriterion';
import Button from '@mui/material/Button';
import { Grid } from '@mui/system';
import { useRouter } from 'next/navigation';

const DashboardPage: React.FC = ({}) => {
  const [ userSearchRequest, setUserSearchRequest ] = React.useState(defaultBaseSearchModel);

  const { data: userResult, isFetched } = useQuery({
    queryKey: idp.user.search.key(userSearchRequest),
    queryFn: async () => await UserService.searchUser(userSearchRequest),
    placeholderData: keepPreviousData,
  });

  const router = useRouter();
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
      searchCriteria: filtering.filter(x => !!(x.value as SearchCriterion).searchValue).map(x => {
        const searchCriterion = x.value as SearchCriterion;
        return {
          propertyPath: x.id,
          searchValue: searchCriterion.searchValue,
          compareOperator: searchCriterion.compareOperator,
        };
      }),
    });
  }, [ pagination.pageIndex, sorting, filtering ]);

  return (
    <>
      <Grid container style={{ width: '100%' }} className="d-flex justify-content-between">
        <Grid offset={11} size={1}>
          <Button
            color="primary"
            style={{ width: '100%' }}
            variant="contained"
            className="float-end"
            onClick={() => router.push('/projects/create')}
          >
            Create
          </Button>
        </Grid>
      </Grid>
      <Paper sx={{ width: '100%' }}>
        <DataTable table={table} pagination={pagination}/>
      </Paper>
    </>
  );
};

export default DashboardPage;