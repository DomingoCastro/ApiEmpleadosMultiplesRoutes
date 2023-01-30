using ApiEmpleadosMultiplesRoutes.Data;
using ApiEmpleadosMultiplesRoutes.Model;

namespace ApiEmpleadosMultiplesRoutes.Repositories
{
    public class RepositoryEmpleado
    {
        private EmpleadoContext context;
        public RepositoryEmpleado(EmpleadoContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }
        public Empleado FindEmpleado(int id)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdEmpleado == id
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
