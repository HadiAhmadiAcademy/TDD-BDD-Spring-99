import { Component, OnInit } from '@angular/core';
import { Dimension } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';
import { Observable, of, BehaviorSubject } from 'rxjs';
import { DialogService, DialogCloseResult } from '@progress/kendo-angular-dialog';
import { OK } from '../../dialog-response.enum';
import { CourseCategoryComponent } from '../course-category/course-category.component';
import { CourseCategoryGridService } from '../shared/course-category-grid.service';
import { GridDataResult } from '@progress/kendo-angular-grid';
import { State } from '@progress/kendo-data-query';

@Component({
    selector: 'course-category-list',
    templateUrl: './course-category-list.component.html',
})
export class CourseCategoryListComponent implements OnInit {
   
    loading: Boolean;
    dimensions: Dimension[];
    public state: State = {
        skip: 0,
        take: 10
    };
     
    constructor(private service: CourseCategoryGridService,
                private dialogService: DialogService) {
    }

    ngOnInit(): void {
        this.loadCourseCategories();
    }

    private loadCourseCategories() {
        this.loading = true;
        this.service.getAll()
        .subscribe(a=> {
            this.dimensions = a;
            this.loading = false;
        });
    }

    public delete(item: Dimension):void {
        
    }

    public edit(item: Dimension):void {
        this.openCourseCategoryDialog(item);
    }

    public addDimension():void {
        this.openCourseCategoryDialog(null);
    }

    private openCourseCategoryDialog(model: Dimension) {
        const dialogRef = this.dialogService.open({
            title: 'Add Dimension',
            content: CourseCategoryComponent
        });

        (dialogRef.content.instance as CourseCategoryComponent).model = model;

        dialogRef.result.subscribe((result: any) => {
            if (result == OK) {
                this.loadCourseCategories();
            }
        });
    }

    public addChild(item: Dimension) : void {
        alert(item.id);
    }
}
