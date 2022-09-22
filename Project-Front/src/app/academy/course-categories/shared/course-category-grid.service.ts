import { Injectable } from "@angular/core";
import { Observable, of, BehaviorSubject } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { State, toDataSourceRequestString } from "@progress/kendo-data-query";
import { GridDataResult } from "@progress/kendo-angular-grid";
import { Dimension } from "./course-category.model";
import { environment } from 'src/environments/environment';

@Injectable()
export class CourseCategoryGridService extends BehaviorSubject<GridDataResult> {
    private url = environment.apiEndpoint + "/Dimensions";
    
    constructor(private httpClient: HttpClient) {
        super(null);
    }

    getAll(): Observable<Array<Dimension>> {
       return this.httpClient.get<Array<Dimension>>(this.url);
    }
}