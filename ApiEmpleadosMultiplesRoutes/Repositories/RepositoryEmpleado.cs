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
        //Metodo para devolver todos los empleados
        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }
        //Metodo para devolver 1 solo empleado
        public Empleado FindEmpleado(int id)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdEmpleado == id
                           select datos;
            return consulta.FirstOrDefault();
        }
        //Metodo para obtener todos los oficios
        public List<string> GetOficios()
        {
            var consulta = (from datos in this.context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }


        //Metodo para obtener los empleados por oficio
        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }
        //Metodo para obtener empleados por salario
        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }
    }
}
