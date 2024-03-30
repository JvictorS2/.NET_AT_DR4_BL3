using System.ComponentModel.DataAnnotations;

namespace infnetMVC.Models
{
    public class Departamento
    {
        // fields
        private int id;
        private string nome;
        private string local;
        private ICollection<Funcionario>? funcionarios;


        // propreties
        [Key]
        public int Id { get => id; set => id = value; }
        [Required]
        public string Nome { get => nome; set => nome = value; }
        [Required]
        public string Local { get => local; set => local = value; }

        // Referência da classe Funcionario, ICollection por ser uma relãção de muitos
        public ICollection<Funcionario>? Funcionarios { get => funcionarios; set => funcionarios = value; }

        // constructor
        public Departamento()
        {

        }
    }
}
