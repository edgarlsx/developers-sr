import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { JwtServiceService } from '../_services/jwt-service.service';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  formGroup: FormGroup;
  isAuthenticated: boolean = false;
  authenticated: [] = [];
  userLogged: any = {};

  constructor(private jwtService: JwtServiceService) { }
  
  ngOnInit(){
    this.initForm();
  }

  initForm(){
    this.formGroup = new FormGroup({
      userName: new FormControl('', [Validators.required]),
      userPass: new FormControl('', [Validators.required])
    })
  }
  
  loginProces(){
    if (this.formGroup.valid){
      this.jwtService.login(this.formGroup.value).subscribe(data => {
        debugger;
        if (data.userName){
          this.authenticated = data;
          localStorage.setItem('user_logged', JSON.stringify(data));
        };
      }, error => {
        console.log(error);
        alert('Usuário ou Senha Invalido')
      })
    }else{
      alert('Usuario ou Senha Invalido.')
    }
  }

  getUserData(){
    this.userLogged = JSON.parse(localStorage.getItem('user_logged'));
    this.isAuthenticated = this.userLogged != null;
  }

}