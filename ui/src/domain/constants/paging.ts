const pageSizeConfig = process.env.NEXT_PUBLIC_PAGE_SIZE;
export const DEFAULT_PAGE_SIZE = pageSizeConfig ? parseInt(pageSizeConfig) : 10;