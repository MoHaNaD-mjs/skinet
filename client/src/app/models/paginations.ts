import { IProduct } from './product';

 // import {IProduct} from './product';

export interface IPagination {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: IProduct[];
  }
