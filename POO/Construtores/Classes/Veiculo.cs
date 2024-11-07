namespace Construtores.Classes
{
    public class Veiculo
    {
      
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Cor { get; set; }



        public Veiculo( string ma, string md, int an, string cr){
Marca = ma;
Modelo = md;
Ano = an;
Cor = cr;        }
        public void ExibirDados(){
Console.WriteLine(@$"
Marca: {Marca}
Modelo: {Modelo};
Ano: {Ano}
Cor: {Cor} ");
        }
    }
}