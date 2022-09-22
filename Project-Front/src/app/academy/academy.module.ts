import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule }    from '@angular/common/http';
import { FormsModule } from '@angular/forms'

import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { DialogsModule } from '@progress/kendo-angular-dialog';
import { GridModule } from '@progress/kendo-angular-grid';

import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryService } from './course-categories/shared/course-category.service';
import { CourseListComponent } from './courses/course-list/course-list.component'
import { CourseGridService } from './courses/shared/course-grid.service';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';
import { CourseComponent } from './courses/course/course.component';
import { CourseService } from './courses/shared/course.service';
import { AuthModule } from '@auth/auth.module';
import { AuthGuard } from '@auth/shared/auth-guard.service';
import { CourseCategoryGridService } from './course-categories/shared/course-category-grid.service';

// move to a seperate file
const appRoutes: Routes = [
  { path: 'dimension-list', component: CourseCategoryListComponent, canActivate:[AuthGuard] },
  { path: 'course-list', component: CourseListComponent,canActivate:[AuthGuard] },
  { path: 'course/:id', component: CourseComponent,canActivate:[AuthGuard] },
];

@NgModule({
    imports:      [
      BrowserModule,
      TreeViewModule,
      ButtonsModule,
      DialogsModule,
      HttpClientModule,
      FormsModule,
      GridModule,
      RouterModule.forRoot(appRoutes),
      AuthModule,
     ],
    providers:    [ 
      CourseCategoryService,
      CourseCategoryGridService,
      CourseGridService,
      CourseService
    ],
    declarations: [
      CourseCategoryListComponent,
      CourseCategoryComponent,
      CourseListComponent,
      CourseComponent
     ],
    entryComponents:[CourseCategoryComponent],
    exports:      [ ],
    bootstrap:    [ ]
  })
export class AcademyModule { }
