import { Injectable } from "@angular/core";
import { UserManagerSettings, UserManager, User } from "oidc-client"
import { Router } from "@angular/router";

@Injectable()
export class AuthService {

    private userManager = new UserManager(this.getSettings());
    private user:User;

    constructor(private router: Router){}

    isUserLoggedIn() : boolean{
        return true;
        // return this.user != null;
    }
    redirectToSts(returnUrl:string) {
        var redirectConfig = {
            state: returnUrl
        };
        this.userManager.signinRedirect(redirectConfig);
    }

    redirectCallback() {
        this.userManager.signinRedirectCallback().then(user=>{
            debugger;
            this.user = user;
            this.router.navigate([user.state]);
        })
    }

    getToken(): string {
        return `${this.user.token_type} ${this.user.access_token}`;
    }

    getSettings() : UserManagerSettings{
        return {
            authority: 'http://localhost:5000/',
            client_id: 'academy',
            redirect_uri: 'http://localhost:4200/auth-callback',
            post_logout_redirect_uri: 'http://localhost:4200/',
            response_type: "id_token token",
            scope: "openid profile academy-api",
            filterProtocolClaims: true,
            loadUserInfo: true,
            automaticSilentRenew: true,
            silent_redirect_uri: 'http://localhost:4200/silent-refresh.html'
          };
    }
}