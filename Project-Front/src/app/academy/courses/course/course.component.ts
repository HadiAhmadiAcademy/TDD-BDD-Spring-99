import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { CourseGridService } from "../shared/course-grid.service";
import { CourseService } from "../shared/course.service";
import { Course } from "../shared/course.model";

@Component({
    selector: 'course',
    templateUrl: './course.component.html',
})
export class CourseComponent implements OnInit {

    model: Course;    
    constructor(private route: ActivatedRoute, 
        private service: CourseService) {
        
    }

    ngOnInit(): void {
        // this.route.params.subscribe((params)=> {
        //     var id = params.id;
        // });
        this.model = new Course(1,"Title !");
    }

    save():void {

    }
}