import { Component, Inject } from '@angular/core';
import { AuthService } from './auth/shared/auth.service';
import { Router, ActivatedRoute } from '@angular/router';
import { DOCUMENT } from '@angular/platform-browser';
import { TEST_INJECTION_TOKEN } from './shared';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(authService:AuthService){

    debugger;
    if (location.pathname != "/auth-callback" && !authService.isUserLoggedIn()){
      authService.redirectToSts("/");
    }
  }
}
