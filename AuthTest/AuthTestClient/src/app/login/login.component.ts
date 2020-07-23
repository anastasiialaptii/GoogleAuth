import { Component, OnInit } from '@angular/core';
import {
  AuthService,
  GoogleLoginProvider
} from 'angular-6-social-login';
import{ LoginService } from '../service/auth.service';
import { User } from '../model/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})


export class LoginComponent implements OnInit {  
  response;  
    users=new User();  
  constructor(  
    public OAuth: AuthService,  
    public LoginService: LoginService
  ) { }  
  ngOnInit() {  
  }  
  
  public socialSignIn(socialProvider: string) {  
    let socialPlatformProvider;  
if (socialProvider === 'google') {  
      socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;  
    }  

    this.OAuth.signIn(socialPlatformProvider).then(users => {  
      console.log(socialProvider, users);  
      console.log(users);  
      this.Savesresponse(users);  
    });  
  }  

  Savesresponse(users: User) {  
    this.LoginService.Savesresponse(users).subscribe((res: any) => {  
      debugger;  
      console.log(res);  
      this.users=res;  
      this.response = res.userDetail;  
      localStorage.setItem('socialusers', JSON.stringify( this.users));  
      console.log(localStorage.setItem('socialusers', JSON.stringify(this.users)));   
    })  
  }  
}
