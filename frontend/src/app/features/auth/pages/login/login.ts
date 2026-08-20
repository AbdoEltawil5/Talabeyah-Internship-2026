import { Component, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  imports: [CommonModule, FormsModule],
  templateUrl: './login.html',
  styleUrls: ['./login.scss']
})
export class Login {

  email: string = '';
  password: string = '';
  loading: boolean = false;
  hasError = signal(false);
  errorMessage: string = '';
  successMessage: string = '';

  constructor(private authService: AuthService) { }

  onSubmit() {
    if (this.email == '' || this.password == '') {
      this.errorMessage = 'Please enter email and password';
      this.hasError.set(true);
      this.successMessage = '';
      return;
    }


    this.errorMessage = '';
    this.hasError.set(false);
    this.successMessage = '';
    this.loading = true;

    this.authService.login(this.email, this.password).subscribe({
      next: (response: any) => {
        // TODO:- to be implemented in an interceptor 
        this.authService.saveToken(response.Token);
        this.loading = false;
        this.successMessage = 'Login successful';
      },
      error: (error: any) => {
        this.loading = false;
        this.hasError.set(true);
        this.successMessage = '';
        if (error.status == 401) {
          this.errorMessage = 'Invalid email or password';
        } else {
          this.errorMessage = 'Something went wrong, please try again';
        }
      }
    })

  }

}
