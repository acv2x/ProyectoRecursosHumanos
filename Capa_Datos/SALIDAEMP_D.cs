using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class SALIDAEMP_D
    {
        ProyectoASPEntities BaseDatos = new ProyectoASPEntities();
        public void InsertarSALIDAEMP(Salidas sal)
        {
            BaseDatos.Salidas.Add(sal);
            BaseDatos.SaveChanges();
        }
        public List<Salidas> MostrarSalidas()
        {
            return BaseDatos.Salidas.ToList();
        }
        public Salidas DetalleSalidas(int id)
        {
            using (var detalle = new ProyectoASPEntities())
            {
                return detalle.Salidas.Find(id);
            }
        }
        public void EditarSalida(Salidas sal)
        {
            var x = BaseDatos.Salidas.Find(sal.ID_EMP);
            x.TipoSalida = sal.TipoSalida;
            x.Motivo = sal.Motivo;
            x.FechaSalida = sal.FechaSalida;
            BaseDatos.SaveChanges();

        }
        public void EliminarSalida(int id)
        {
            var sal = BaseDatos.Salidas.Find(id);
            BaseDatos.Salidas.Remove(sal);
            BaseDatos.SaveChanges();
        }
    }
}
