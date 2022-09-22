import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from "@angular/common/http";
import { Observable } from "rxjs";
import { AuthService } from "./auth.service";
import { Injectable } from "@angular/core";

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

    constructor(private authService:AuthService){}

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>>{
        // var token = this.authService.getToken();
        // const authReq = req.clone({
        //     headers: req.headers.set('Authorization', token)
        // });
        // return next.handle(authReq);
        return next.handle(req);
    }
}