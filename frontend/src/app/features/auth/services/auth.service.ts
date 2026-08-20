import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  login(email: string, password: string): Observable<any> {
    return this.http.post('api/Auth/login', {
      email: email,
      password: password
    });
  }

  saveToken(token: string) {
    localStorage.setItem('auth_token', token);
  }

}
