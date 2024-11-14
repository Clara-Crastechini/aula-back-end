using PilaresPOO.Classes.Aprendizagem;

namespace PilaresPOO.Classes
{
    public class Aluno : Pessoa
    {
        
        public int matricula { get; set; }

        public string curso { get; set; }

        public float media { get; set; }
    }
}