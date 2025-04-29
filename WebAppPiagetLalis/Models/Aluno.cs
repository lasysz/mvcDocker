namespace WebAppPiagetLalis.Models

/// <summary>
/// Class auxuiliar para a criação de um aluno
/// </summary>
{
    public class Aluno : Base
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public String Telefone { get; set; }
    }
}
