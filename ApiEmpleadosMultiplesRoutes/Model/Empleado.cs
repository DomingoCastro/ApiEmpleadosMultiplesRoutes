using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEmpleadosMultiplesRoutes.Model
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [Column("EMP_NO")]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        public string Nombre { get; set; }
        [Column("OFICIO")]
        public string Oficio { get; set; }
        [Column("DEPT_NO")]
        public int IdDepartamento { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
