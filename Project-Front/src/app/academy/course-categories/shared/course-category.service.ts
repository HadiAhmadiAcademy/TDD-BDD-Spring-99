import { Dimension } from './course-category.model';
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { BaseHttpService } from "@core/base-http.service";
import { GridComponent } from '@progress/kendo-angular-grid';

@Injectable()
export class CourseCategoryService extends BaseHttpService<Dimension> {
    constructor(httpClient: HttpClient) {
        super(httpClient, "Dimensions")
    }

    save(model: Dimension): Observable<any> {
        if (model.id) {
            return this.put(model, model.id);
        }
        else
            return this.post(model);
    }
}