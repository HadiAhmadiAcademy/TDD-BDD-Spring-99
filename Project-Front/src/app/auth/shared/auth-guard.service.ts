import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";

@Injectable()
export class AuthGuard implements CanActivate {

    constructor(private authService: AuthService) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):  boolean {
        if (this.authService.isUserLoggedIn()){
            return true;
        }
        else {
            var returnUrl = state.url;
            this.authService.redirectToSts(returnUrl);
            return false;
        }
    }
}