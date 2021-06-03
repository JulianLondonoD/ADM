import { Categoria } from "../models/categoria"

export  const mapCategorias = (categorias : any[]) : Categoria[] =>  {
    let categoriasArray : Categoria[] = [];
    categorias.map(categoria => {
        let categoriaModel : Categoria = {
            Categoria: categoria.categoria,
            IdCategoria: categoria.idCategoria,
        }
        categoriasArray.push(categoriaModel);
    })
    return categoriasArray;
} 