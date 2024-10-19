using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    class CarritoCompra
    {
        public int? Id { get; set; }
        public int? IdUsuarios { get; set; }
        public int? IdProducto { get; set; }
        public int? CostoTotal { get; set; }
        public int? Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }

    }
}
