import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../_services/clientes.service';
import { ClienteModel } from './clientes.model';
import { DatePipe, formatDate } from '@angular/common';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  cliente: ClienteModel = new ClienteModel();
  clientes: [] = [];

  constructor(private clientesServices: ClientesService) { }

  ngOnInit(): void {
    this.listarTodos();
  }

  listarTodos(){
    this.clientesServices.listarClientes().subscribe(buscaClientes => {
      this.clientes = buscaClientes;
    }, error => {
      console.log('Erro ao buscar Clientes.')
    })
  }

  cadastrarCliente(){
    this.cliente.grupoClientesId = 1;
    this.clientesServices.cadastrarCliente(this.cliente).subscribe(clientes => {
      this.cliente = new ClienteModel();
      this.listarTodos();
    }, error => {
      console.log('Erro ao Salvar Clientes.')
    })
  }

}
