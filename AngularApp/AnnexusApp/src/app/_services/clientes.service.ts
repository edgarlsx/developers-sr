import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { baseUrl } from 'src/environments/environment';
import { ClienteModel } from '../clientes/clientes.model';

@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient) { }

  listarClientes(): Observable<any>{
      return this.http.get(`${baseUrl}Clientes`);
  }

  cadastrarCliente(cliente: ClienteModel): Observable<any>{
    return this.http.post(`${baseUrl}Clientes`, cliente);
  }


}
