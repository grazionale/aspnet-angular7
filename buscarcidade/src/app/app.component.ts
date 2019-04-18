import { ConsultarCepService } from './consultar-cep.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Buscador de Cep';

  cep = null;
  dados = [];

  constructor(private consultarCep: ConsultarCepService){}

  buscarCep() {
    this.consultarCep.consultarCep(this.cep).then(resultado => {
      this.dados = resultado;
      //console.log(this.dados);
    });
  }
}


