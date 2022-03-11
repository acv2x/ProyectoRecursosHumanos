using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CARGOS_D
    {
        public void InsertarCargos(Cargos car)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                BaseDatos.Cargos.Add(car);
                BaseDatos.SaveChanges();
            }
        }
        public List<Cargos> MostrarCargo()
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Cargos.ToList();
            }
        }
        public Cargos DetalleCargo(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                return BaseDatos.Cargos.Find(id);
            }
        }
        public void EditarCargo(Cargos car)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                var x = BaseDatos.Cargos.Find(car.ID_CAR);
                x.Cargo = car.Cargo;
                BaseDatos.SaveChanges();
            }
        }
        public void EliminarCargo(int id)
        {
            using (var BaseDatos = new ProyectoASPEntities())
            {
                var carg = BaseDatos.Cargos.Find(id);
                BaseDatos.Cargos.Remove(carg);
                BaseDatos.SaveChanges();
            }
        }
    }
}
