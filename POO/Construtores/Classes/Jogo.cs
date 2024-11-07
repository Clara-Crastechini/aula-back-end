namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome {get; set;}

        public int lancamento{get; set;}	

        public float valor {get; set;}

        public string genero {get; set;}

        public Jogo(string nm, int lc, float va, string ge){
            nome = nm;
            lancamento = lc;
            valor = va;
            genero = ge;
        }

    public void ExibirDados(){
Console.WriteLine(@$"
        nome: {nome};
        valor: {valor};
        genero: {genero}");
        }
    }
    }
