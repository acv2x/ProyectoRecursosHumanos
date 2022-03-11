using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class PERMISOS_D
    {
        public void CrearPermiso(Permisos permi)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                BaseDatos.Permisos.Add(permi);
                BaseDatos.SaveChanges();
            }
        }
        public List<Permisos> MostrarPermiso()
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Permisos.ToList();
            }
        }
        public Permisos DetallePermiso(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Permisos.Find(id);
            }
        }
        public void EditarPermiso(Permisos perm)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                var x = BaseDatos.Permisos.Find(perm.ID_PER);
                x.ID_EMP = perm.ID_EMP;
                x.Desde = perm.Desde;
                x.Hasta = perm.Hasta;
                x.Comentario = perm.Comentario;
                BaseDatos.SaveChanges();
            }
        }
        public void EliminarPermisos(int id)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                var perm = BaseDatos.Permisos.Find(id);
                BaseDatos.Permisos.Remove(perm);
                BaseDatos.SaveChanges();
            }
        }
    }
}
