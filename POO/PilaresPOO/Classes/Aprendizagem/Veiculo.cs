namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo 
    {
        public string marca { get; set; }

        public string modelo { get; set; }

        public string cor { get; set; }

        public float potencia { get; set; } 

        public int qtdPassageiros { get; set; }


        public string Ligar(){
            return "vrum";
            // Console.WriteLine($"vrum");
        }

        public string Desligar(){
            return "desvrum";
            // Console.WriteLine($"desvrum");
        }

        public string Buzinar(){
            return "BIBIIII";
            // Console.WriteLine($"BIBIIII");
        }
    }
}