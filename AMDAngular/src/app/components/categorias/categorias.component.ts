import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CategoriaService } from 'src/app/services/categoria.service';
import {Categoria} from '../../models/categoria';
import {mapCategorias} from '../../business/categoriaBusiness';

@Component({
  selector: 'app-categorias',
  templateUrl: './categorias.component.html',
  styleUrls: ['./categorias.component.css']
})
export class CategoriasComponent implements OnInit {
  
  categorias: Categoria[] = [];

  

  constructor(private toastr: ToastrService, private _categoriaService : CategoriaService) { }

  ngOnInit(): void {
    this.getCategorias();
  }

  getCategorias()
  {
    this._categoriaService.getCategorias().subscribe(data => {
      this.categorias = mapCategorias(data);
    },error => {
      console.log(error);
    });
  }

  onDeleteCategoria(categoria : Categoria)
  {
    this._categoriaService.deleteCategoria(categoria).subscribe(data => {
      this.toastr.error('Categoría eliminada con exito', 'Categoria');
      this.getCategorias();
    },error => {
      console.log(error);
    });
  }

  onReloadCategoria($event : boolean){
    if($event)
      this.getCategorias();
  }

}
