import { Component, OnInit } from '@angular/core';
import { Course } from '../shared/course.model';
import { Observable } from 'rxjs';
import { State } from '@progress/kendo-data-query';
import { DataStateChangeEvent, GridDataResult } from '@progress/kendo-angular-grid';
import { Router } from '@angular/router';
import { CourseGridService } from '../shared/course-grid.service';

@Component({
    selector: 'course-list',
    templateUrl: './course-list.component.html',
})
export class CourseListComponent implements OnInit {

    courses: Observable<GridDataResult>;
    public state: State = {
        skip: 0,
        take: 5
    };
    constructor(private courseService: CourseGridService, 
                private router: Router) {
       this.courses = this.courseService;
    }

    public dataStateChange(state: DataStateChangeEvent): void {
        this.state = state;
        this.courseService.reload(this.state);
    }

    ngOnInit(): void {
        this.courseService.reload(this.state);
    }

    edit(item:Course):void {
        this.router.navigate([`/course/${item.id}`]);
    }

    delete(item:Course):void {

    }
}
