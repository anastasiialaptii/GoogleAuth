import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class LoginService {
  url;
  test: number;
  constructor(private http: HttpClient) { }
  Savesresponse(responce) {
    this.url = 'http://localhost:58529/Api/Login/Savesresponse';
    return this.http.post(this.url, responce);
  }

  GetTest() {
    return this.http.get('http://localhost:58529/Api/Login/GetTest')
      .toPromise()
      .then(res => this.test = res as number);
  }
}