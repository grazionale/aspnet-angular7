import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConsultarCepService {

  constructor(private http: HttpClient) { }

  consultarCep(cep: any): Promise<any>{
    return this.http.get('http://localhost:61305/api/Cidade/BuscarLogradouro/' + cep)
    .toPromise()
    .then(response => {
      return response;
    }, (error) => {
      console.log(error);
    });
  }
}


