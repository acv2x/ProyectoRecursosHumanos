using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class VACACIONES_D
    {
        public void InsertarVacaciones(Vacaciones vaca)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                BaseDatos.Vacaciones.Add(vaca);
                BaseDatos.SaveChanges();
            }
        }
        public List<Vacaciones> MostrarVacaciones()
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Vacaciones.ToList();
            }
        }
        public Vacaciones DetalleVacaciones(int id)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Vacaciones.Find(id);
            }
        }
        public void EditarVacaciones(Vacaciones vaca)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                var x = BaseDatos.Vacaciones.Find(vaca.ID_VAC);
                x.ID_EMP = vaca.ID_EMP;
                x.Desde = vaca.Desde;
                x.Hasta = vaca.Desde;
                x.CorrespondienteA = vaca.CorrespondienteA;
                x.Comentario = vaca.Comentario;
                BaseDatos.SaveChanges();
            }
        }
        public void EliminarVacaciones(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                var vac = BaseDatos.Vacaciones.Find(id);
                BaseDatos.Vacaciones.Remove(vac);
                BaseDatos.SaveChanges();
            }
        }
    }
}
