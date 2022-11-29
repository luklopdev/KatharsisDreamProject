import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { lastValueFrom } from 'rxjs';
import { RegisterUserModel } from 'src/app/models/register-user.model';
import { RegisterService } from 'src/app/services/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  
  registerForm = new FormGroup({
    email: new FormControl<string>(''),
    password: new FormControl<string>(''),
    confirmPassword: new FormControl<string>('')
  });

  constructor(private registerService: RegisterService) { }

  ngOnInit(): void {
  }

  async onSubmit(){
    let accountData: RegisterUserModel = new RegisterUserModel(
      this.registerForm.value.email as string,
      this.registerForm.value.password as string,
      this.registerForm.value.confirmPassword as string
    );

    await this.registerService.registerAccount(accountData);
  }
}
