using ApiEmpleadosMultiplesRoutes.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpleadosMultiplesRoutes.Data
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
