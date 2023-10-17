using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudImpressionadorBalta.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve cconter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracteres")]
        [DisplayName("Nome completo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;
    }
}
