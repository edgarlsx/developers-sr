import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GrupoClientesComponent } from './grupo-clientes/grupo-clientes.component';
import { ClientesComponent } from './clientes/clientes.component';

import { GrupoClientesService } from './_services/grupo-clientes.service'
import { ClientesService } from './_services/clientes.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    GrupoClientesComponent,
    ClientesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [],
  providers: [
    GrupoClientesService,
    ClientesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
