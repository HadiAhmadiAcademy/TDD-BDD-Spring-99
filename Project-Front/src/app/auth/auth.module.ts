import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS }    from '@angular/common/http';
import { FormsModule } from '@angular/forms'
import { AuthService } from './shared/auth.service';
import { AuthGuard } from './shared/auth-guard.service';
import { AuthCallbackComponent } from './auth-callback/auth-callback.component';
import { AuthInterceptor } from './shared/auth-interceptor';

const authRoutes: Routes = [
  { path: 'auth-callback', component: AuthCallbackComponent },
];

export const httpInterceptorProviders = [
  { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
];

@NgModule({
    imports:      [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      RouterModule.forChild(authRoutes)
     ],
    providers:    [ 
      AuthService,
      AuthGuard,
      httpInterceptorProviders
    ],
    declarations: [
      AuthCallbackComponent
     ],
    entryComponents:[],
    exports:      [ ],
    bootstrap:    [ ]
  })
export class AuthModule { }
