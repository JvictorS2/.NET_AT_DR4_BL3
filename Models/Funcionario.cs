using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace infnetMVC.Models
{
    public class Funcionario
    {
        // fields

        private int id;
        private string nome;
        private string endereco;
        private string telefone;
        private string email;
        private DateTime dataNascimento;
        private int departamentoId;
        private Departamento? departamento;

        // propreties
        [Key]
        public int Id { get => id; set => id = value; }
        [Required]
        [StringLength(50)]
        public string Nome { get => nome; set => nome = value; }
        [Required]
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        [Required]
        public string Email { get => email; set => email = value; }
        [Required]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        // atributos do relacinamento muitos pra 1

        // foreign key
        [ForeignKey("Departamento")]
        [Display(Name = "Departamento")]
        public int DepartamentoId { get => departamentoId; set => departamentoId = value; }
        public Departamento? Departamento { get => departamento; set => departamento = value; }


        // constructor
        public Funcionario()
        {

        }
    }
}
