import { Component, OnInit } from '@angular/core';
import { AuthService } from '../shared/auth.service';

@Component({
  selector: 'auth-callback',
  template: '<h2>Auth callback</h2>',
})
export class AuthCallbackComponent implements OnInit{
  

  constructor(private authService: AuthService){
  }

  ngOnInit(): void {
    this.authService.redirectCallback();
  }
}
