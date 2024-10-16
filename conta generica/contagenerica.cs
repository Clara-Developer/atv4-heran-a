namespace conta_generica
{
    public abstract class Contagenerica
    {
        public string Banco { get; set; }
        public int Agente { get; set; }
        public int conta { get; set; }
        public double Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }

    public class ContaCorrente : Contagenerica
    {
        //Propriedade pedida no exercício
        public double limite { get; set; }
        //Sempre que eu herdo um método do pai, eu tenho que aplicar
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 500 reais");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 200 reais");
        }
    }
}
