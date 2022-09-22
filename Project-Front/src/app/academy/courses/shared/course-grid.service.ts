import { Course } from "./course.model";
import { Injectable } from "@angular/core";
import { Observable, of, BehaviorSubject } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { State, toDataSourceRequestString } from "@progress/kendo-data-query";
import { GridDataResult } from "@progress/kendo-angular-grid";

@Injectable()
export class CourseGridService extends BehaviorSubject<GridDataResult> {
    private url = "http://localhost:5550/api/courses";
    
    constructor(private httpClient: HttpClient) {
        super(null);
    }

    reload(state:State){
        this.getAll(state).subscribe(x => super.next(x))
    }

    getAll(state: State): Observable<GridDataResult> {
       var serializedRequest = toDataSourceRequestString(state);
       const getUrl = `${this.url}?${serializedRequest}`;
       debugger;
       return this.httpClient.get<GridDataResult>(getUrl);
    }
}