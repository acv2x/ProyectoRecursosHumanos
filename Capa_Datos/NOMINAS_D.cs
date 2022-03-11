using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class NOMINAS_D
    {
        ProyectoASPEntities BaseDatos = new ProyectoASPEntities();
        public void CrearNomina(Nominas nomi)
        {
            BaseDatos.Nominas.Add(nomi);
            BaseDatos.SaveChanges();
        }
        public List<Nominas> MostrarNomina()
        {
            return BaseDatos.Nominas.ToList();
        }
        public Nominas DetalleNom(int id)
        {
            using (var detalle = new ProyectoASPEntities())
            {
                return detalle.Nominas.Find(id);
            }
        }
        public void EditarNomina(Nominas nomi)
        {
            var x = BaseDatos.Nominas.Find(nomi.ID_NOM);
            x.Año = nomi.Año;
            x.Mes = nomi.Mes;
            x.MontoTotal = nomi.MontoTotal;
            BaseDatos.SaveChanges();
        }
        public void EliminarNomina(int id)
        {
            var nomi = BaseDatos.Nominas.Find(id);
            BaseDatos.Nominas.Remove(nomi);
            BaseDatos.SaveChanges();
        }
    }
}
