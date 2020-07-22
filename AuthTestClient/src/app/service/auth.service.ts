import { Injectable } from '@angular/core';
    import { HttpClient } from '@angular/common/http';
    @Injectable({
      providedIn: 'root'
    })
    export class LoginService {
    url;
      constructor(private http: HttpClient) { }
      Savesresponse(responce)
      {
        this.url =  'http://localhost:58529/Api/Login/Savesresponse';
        return this.http.post(this.url,responce);
      }
    }