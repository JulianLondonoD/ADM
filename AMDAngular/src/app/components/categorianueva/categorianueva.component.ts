import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CategoriaService } from 'src/app/services/categoria.service';
import {Categoria} from '../../models/categoria';

@Component({
  selector: 'app-categorianueva',
  templateUrl: './categorianueva.component.html',
  styleUrls: ['./categorianueva.component.css']
})
export class CategorianuevaComponent implements OnInit {

  @Output() reloadCategorias = new EventEmitter<boolean>();

  form: FormGroup;


  constructor(private fb: FormBuilder, private toastr: ToastrService, private _categoriaService : CategoriaService) { 
    this.form = this.fb.group({
      IdCategoria: [''],
      Categoria: ['', Validators.required]
    })

  }

  ngOnInit(): void {
  }

  onSubmitCategoria()
  {
    let categoria: Categoria = {
      IdCategoria: 0,
      Categoria: this.form.get("Categoria")?.value.toUpperCase(),
    }
    this._categoriaService.createCategoria(categoria).subscribe(data => {
      this.toastr.success('Categoría creada con exito', 'Categoria');
      this.form.reset();
      this.reloadCategorias.emit(true);
    },error => {
      console.log(error);
    });
  }

}
