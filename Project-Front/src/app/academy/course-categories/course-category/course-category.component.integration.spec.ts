import { TestBed, ComponentFixture, fakeAsync, tick } from "@angular/core/testing";
import { CourseCategoryComponent } from "./course-category.component";
import { DialogRef } from "@progress/kendo-angular-dialog";
import { CourseCategoryService } from "../shared/course-category.service";
import { FormsModule } from "@angular/forms";
import { Dimension } from "../shared/course-category.model";
import { By } from "@angular/platform-browser";
import { of } from "rxjs";
import { OK } from "../../dialog-response.enum";

describe('CourseCategory component', () => {

    let service;
    let dialog;
    let fixture: ComponentFixture<CourseCategoryComponent>;

    beforeEach(() => {
        service = jasmine.createSpyObj(['save']);
        dialog = jasmine.createSpyObj(['close']);

        TestBed.configureTestingModule({
            imports: [
                FormsModule
            ],
            declarations:[
                CourseCategoryComponent
            ],
            providers:[
                { provide: DialogRef, useValue: dialog },
                { provide: CourseCategoryService, useValue: service },
            ]
        });
        fixture = TestBed.createComponent(CourseCategoryComponent);
        fixture.detectChanges();    //triggers onInit
    });

    it('should bind #title to input properly', () => {
        fixture.componentInstance.model.title = "test";
        fixture.detectChanges();
        fixture.whenStable().then(a=> {
            expect(fixture.debugElement.query(By.css('#title')).nativeElement.value).toBe("test");
        });
    });

    describe('when #saveButton clicked', () => {
        it('should save the model via service', () => {
            service.save.and.returnValue(of(true));
    
            fixture.componentInstance.model.title = "test";
            fixture.detectChanges();
            fixture.whenStable().then(a=> {
                fixture.debugElement.query(By.css('#saveButton')).nativeElement.click();
                expect(service.save).toHaveBeenCalledTimes(1);
                expect(service.save).toHaveBeenCalledWith(fixture.componentInstance.model);
            });
        });

        fit('should close the dialog after successful save', fakeAsync(()=>{
            service.save.and.returnValue(of(true));
            fixture.componentInstance.model.title = "test";
            fixture.detectChanges();
            tick();
            fixture.debugElement.query(By.css('#saveButton')).nativeElement.click();
            expect(dialog.close).toHaveBeenCalledWith(OK);

            // fixture.whenStable().then(a=> {
            //     fixture.debugElement.query(By.css('#saveButton')).nativeElement.click();
            //     expect(dialog.close).toHaveBeenCalledWith(OK);
            // });
        }))
    });

});