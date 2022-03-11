using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DEPARTAMENTOS_D
    {
        ProyectoASPEntities BaseDatos = new ProyectoASPEntities();

        public void InsertarDepartamentos(Departamentos depar)
        {
            BaseDatos.Departamentos.Add(depar);
            BaseDatos.SaveChanges();
        }
        public List<Departamentos> MostrarDepartamentos()
        {
            return BaseDatos.Departamentos.ToList();
        }
        public Departamentos DetalleDPTO(int id)
        {
            using (var detalle = new ProyectoASPEntities())
            {
                return detalle.Departamentos.Find(id);
            }
        }
        public void EditarDPTO(Departamentos dpto)
        {
            var x = BaseDatos.Departamentos.Find(dpto.ID_DEP);
            x.Codigo = dpto.Codigo;
            x.Departamento = dpto.Departamento;
            BaseDatos.SaveChanges();
        }
        public void EliminarDPTO(int id)
        {
            var dpto = BaseDatos.Departamentos.Find(id);
            BaseDatos.Departamentos.Remove(dpto);
            BaseDatos.SaveChanges();
        }
    }
}
