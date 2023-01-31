using ApiEmpleadosMultiplesRoutes.Model;
using ApiEmpleadosMultiplesRoutes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpleadosMultiplesRoutes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private RepositoryEmpleado repo;
        public EmpleadoController(RepositoryEmpleado repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Empleado>> GetEmpleados()
        {
            return this.repo.GetEmpleados();
        }
        [HttpGet("{id}")]
        public ActionResult<Empleado> FindEmpleado(int id)
        {
            return this.repo.FindEmpleado(id);
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<string>> Oficios()
        {
            return this.repo.GetOficios();
        }
        [HttpGet]
        [Route("[action]/{oficio}")]
        public ActionResult<List<Empleado>> EmpleadosOficio(string oficio)
        {
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
                return empleados;
        }
        [HttpGet]
        [Route("[action]/{salario}")]
        public ActionResult<List<Empleado>> EmpleadosSalario (int salario)
        {
            List<Empleado> empleados= this.repo.GetEmpleadosSalario(salario);
            return empleados;
        }
    }
}
