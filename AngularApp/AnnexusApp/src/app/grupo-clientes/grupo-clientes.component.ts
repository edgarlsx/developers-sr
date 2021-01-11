import { Component, OnInit } from '@angular/core';
import { GrupoClientesService } from '../_services/grupo-clientes.service';

@Component({
  selector: 'app-grupo-clientes',
  templateUrl: './grupo-clientes.component.html',
  styleUrls: ['./grupo-clientes.component.css']
})
export class GrupoClientesComponent implements OnInit {

  constructor(private grupoClientesService: GrupoClientesService) { }

  ngOnInit(): void {
  }

  listarGpCliente(){

  }

}
