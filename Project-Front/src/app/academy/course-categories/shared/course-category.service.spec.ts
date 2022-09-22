import { CourseCategoryService } from "./course-category.service";
import { Dimension } from "./course-category.model";
import { environment } from "src/environments/environment";

describe('CourseCategory Service', () => {

    let httpClient;
    let sut: CourseCategoryService;
    let model: Dimension;

    beforeEach(()=>{
        httpClient = jasmine.createSpyObj(['put','post']);
        sut = new CourseCategoryService(httpClient);
        model = new Dimension();
    });

    it('should send put request when model has id', () => {
        //arrange
        model.id = 1;
        const expectedUrl = environment.apiEndpoint + '/CourseCategories/1';

        //act
        debugger;
        sut.save(model);

        //assert
        expect(httpClient.put).toHaveBeenCalledTimes(1);
        expect(httpClient.put).toHaveBeenCalledWith(expectedUrl, model);
    });

    it('should send post request when model has not id', () => {
        //arrange
        const expectedUrl = environment.apiEndpoint + '/CourseCategories';

        //act
        sut.save(model);

        //assert
        expect(httpClient.post).toHaveBeenCalledTimes(1);
        expect(httpClient.post).toHaveBeenCalledWith(expectedUrl, model);
    });

});