import React from "react";
import { Column } from "@tanstack/react-table";
import ArrowCircleDownIcon from '@mui/icons-material/ArrowCircleDown';
import ArrowCircleRightIcon from '@mui/icons-material/ArrowCircleRight';
import ArrowCircleUpIcon from '@mui/icons-material/ArrowCircleUp';

interface DataTableSortIconProps<T> {
  column: Column<T>,
}

export const DataTableSortIcon = <T, >(props: DataTableSortIconProps<T>) => {
  const sortStatus = props.column.getIsSorted();
  const sortingHandler = props.column.getToggleSortingHandler();

  if (!props.column.getCanSort()) {
    return <></>;
  }

  if (!sortStatus) {
    return <ArrowCircleRightIcon onClick={sortingHandler}/>;
  } else if (sortStatus === "asc") {
    return <ArrowCircleDownIcon onClick={sortingHandler}/>;
  } else if (sortStatus === "desc") {
    return <ArrowCircleUpIcon onClick={sortingHandler}/>;
  }
};