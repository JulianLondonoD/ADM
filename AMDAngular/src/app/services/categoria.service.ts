import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from '../models/categoria';
import * as url from '../resources/urls';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private apiUrl = url.API_URL + url.CATEGORIAS_URL;

  constructor(private http : HttpClient) { }

  getCategorias() : Observable<any> {
    return this.http.get(this.apiUrl);
  }

  deleteCategoria(categoria: Categoria) : Observable<any> {
    return this.http.delete(this.apiUrl + JSON.stringify(categoria));
  }

  createCategoria(categoria: Categoria) : Observable<any> {
    return this.http.post(this.apiUrl, categoria);
  }
}
