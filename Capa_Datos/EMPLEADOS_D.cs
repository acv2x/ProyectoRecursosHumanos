using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class EMPLEADOS_D
    {
        ProyectoASPEntities BaseDatos = new ProyectoASPEntities();
        public void InsertarEmpleado(Empleados emple)
        {
            BaseDatos.Empleados.Add(emple);
            BaseDatos.SaveChanges();
        }
        public List<Empleados> MostrarEmpleado()
        {
            return BaseDatos.Empleados.ToList();
        }
        public Empleados DetalleEMP(int id)
        {
            using (var detalle = new ProyectoASPEntities())
            {
                return detalle.Empleados.Find(id);
            }
        }
        public void EditarEmp(Empleados emp)
        {
            var x = BaseDatos.Empleados.Find(emp.ID_EMP);
            x.Nombre = emp.Nombre;
            x.Apellido = emp.Apellido;
            x.Telefono = emp.Telefono;
            x.ID_DEP = emp.ID_DEP;
            x.ID_CAR = emp.ID_CAR;
            x.FechaIngreso = emp.FechaIngreso;
            x.Salario = emp.Salario;
            x.Estatus = emp.Estatus;
            BaseDatos.SaveChanges();
        }
        public void EliminarEMP(int id)
        {
            var emple = BaseDatos.Empleados.Find(id);
            BaseDatos.Empleados.Remove(emple);
            BaseDatos.SaveChanges();
        }
    }
}
