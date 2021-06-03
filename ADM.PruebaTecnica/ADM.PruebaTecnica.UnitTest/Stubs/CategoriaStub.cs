using ADM.PruebaTecnica.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.UnitTest.Stubs
{
    public class CategoriaStub
    {
        public static CategoriaEntity categoria_1 = new CategoriaEntity()
        {
            IdCategoria = 1,
            Categoria = "TRABAJO"
             
        };

        public static CategoriaEntity categoria_2 = new CategoriaEntity()
        {
            IdCategoria = 2,
            Categoria = "VACACIONES"

        };

        public static CategoriaEntity categoria_3 = new CategoriaEntity()
        {
            IdCategoria = 3,
            Categoria = "BAJA"

        };

        public static IList<CategoriaEntity> categorias = new List<CategoriaEntity>(new CategoriaEntity[] { categoria_1, categoria_2, categoria_3 });
    }
}
