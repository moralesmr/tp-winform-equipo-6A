using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_winform_equipo_6A
{
    class Articulo
    {
        public int CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public List<Imagen> Imagenes { get; set; }
    }
}
