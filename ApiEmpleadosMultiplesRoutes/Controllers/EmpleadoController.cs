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
    }
}
