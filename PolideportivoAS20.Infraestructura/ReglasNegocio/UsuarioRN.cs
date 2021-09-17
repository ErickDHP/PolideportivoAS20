using PolideportivoAS20.Core.Entidades;
using PolideportivoAS20.Core.Repositorios;
using PolideportivoAS20.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Infraestructura.ReglasNegocio
{
    public class UsuarioRN : IUsuario
    {

        Contexto_PolideportivoAS20_BD contexto;

        public void AgregarMantenimiento(Mantenimiento mantenimineto)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            contexto.manteniminetos.Add(mantenimineto);
            contexto.SaveChanges();
        }

        public void AgregarProducto(Producto producto)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            contexto.productos.Add(producto);
            contexto.SaveChanges();
        }

        public void AgregarProforma(Proforma proforma)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            contexto.proformas.Add(proforma);
            contexto.SaveChanges();
        }

        public void AgregarTotal(Total total)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            contexto.totals.Add(total);
            contexto.SaveChanges();
        }

        public void AgregarUsuario(Vehiculo usuario)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            contexto.vehiculo.Add(usuario);
            contexto.SaveChanges();
        }
        public Vehiculo BuscarUsuario(string id)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            var resultado = contexto.vehiculo.Find(id);
            return resultado;
        }

        public void EliminarUsuario(Vehiculo usuario)
        {
            contexto.Entry(usuario).State = EntityState.Deleted;
            contexto.SaveChanges();
        }

        public IEnumerable<Mantenimiento> Listarmanteniminetos()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.manteniminetos.ToList();
        }

        public IEnumerable<Producto> ListarProductos()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.productos.ToList();
        }

        public IEnumerable<Proforma> ListarProforma()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.proformas.ToList();
        }

        public IEnumerable<Total> Listartotal()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.totals.ToList();
        }

        public IEnumerable<Vehiculo> ListarUsuario()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.vehiculo.ToList();
        }

        public Mantenimiento mantenimineto(string id)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            var resultado = contexto.manteniminetos.Find(id);
            return resultado;
        }

        public void ModificarUsuario(Vehiculo usuario)
        {
            contexto.Entry(usuario).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public Producto Producto(string id)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            var resultado = contexto.productos.Find(id);
            return resultado;
        }

        public Proforma Proforma(int id)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            var resultado = contexto.proformas.Find(id);
            return resultado;
        }

        public Total total(int id)
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            var resultado = contexto.totals.Find(id);
            return resultado;
        }
    }
}
