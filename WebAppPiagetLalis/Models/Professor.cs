namespace WebAppPiagetLalis.Models
{
    public class Professor : Base
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public String Telefone { get; set; }

        public Aluno? Aluno { get; set; }
    }
}
