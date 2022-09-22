import { Course } from "./course.model";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class CourseService {
    private url = "http://localhost:5550/api/courses";
    
    constructor(private httpClient: HttpClient) {
    }

    getById(id:number): Observable<Course> {
        var getUrl = `${this.url}/${id}`
       return this.httpClient.get<Course>(getUrl);
    }
}