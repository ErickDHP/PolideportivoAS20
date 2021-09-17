using PolideportivoAS20.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Repositorios
{
    public interface IUsuario
    {
        void AgregarUsuario(Vehiculo usuario);
        void ModificarUsuario(Vehiculo usuario);
        void EliminarUsuario(Vehiculo usuario);
        IEnumerable<Vehiculo> ListarUsuario();
        Vehiculo BuscarUsuario(string id);

        void AgregarMantenimiento(Mantenimiento mantenimineto);
        IEnumerable<Mantenimiento> Listarmanteniminetos();
        Mantenimiento mantenimineto(string id);

        void AgregarProducto(Producto producto);
        IEnumerable<Producto> ListarProductos();
        Producto Producto(string id);

        void AgregarTotal(Total total);
        IEnumerable<Total> Listartotal();
        Total total(int id);

        void AgregarProforma(Proforma proforma);
        IEnumerable<Proforma> ListarProforma();
        Proforma Proforma(int id);
    }
}
