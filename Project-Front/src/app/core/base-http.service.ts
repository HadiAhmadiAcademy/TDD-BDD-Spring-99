import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Injectable } from "@angular/core";
import { environment } from 'src/environments/environment';

@Injectable()
export abstract class BaseHttpService<T> {
    private url = environment.apiEndpoint;

    constructor(private httpClient: HttpClient, private resourceName:string){ }

    public getAll(): Observable<Array<T>> {
        var curl = `${this.url}/${this.resourceName}`;
       return this.httpClient.get<Array<T>>(curl);
    }

    public delete(id:number): Observable<object> {
        let deleteUrl = `${this.url}/${this.resourceName}/${id}`;
        return this.httpClient.delete(deleteUrl);
    }

    public post(model: T): Observable<any> {
        var curl = `${this.url}/${this.resourceName}`;
        return this.httpClient.post(curl,model);
    }
    public put(model: T, id: any): Observable<any> {
        var curl = `${this.url}/${this.resourceName}/${id}`;
        return this.httpClient.put(curl,model);
    }
}