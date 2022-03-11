using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class LICENCIAS_D
    {
        public void RegistrarLicencia(Licencias lic)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                BaseDatos.Licencias.Add(lic);
                BaseDatos.SaveChanges();
            }
        }
        public List<Licencias> MostrarLicencias()
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Licencias.ToList();
            }
        }
        public Licencias DetalleLicencia(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Licencias.Find(id);
            }
        }
        public void EditarLicencia(Licencias lice)
        {
            using(var BaseDatos = new ProyectoASPEntities())
            {
                var x = BaseDatos.Licencias.Find(lice.ID_LIC);
                x.ID_EMP = lice.ID_EMP;
                x.Desde = lice.Desde;
                x.Hasta = lice.Hasta;
                x.Motivo = lice.Motivo;
                x.Comentario = lice.Comentario;
                BaseDatos.SaveChanges();
            }
        }
        public void EliminarLicencia(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                var lic = BaseDatos.Licencias.Find(id);
                BaseDatos.Licencias.Remove(lic);
                BaseDatos.SaveChanges();
            }
        }
    }
}
