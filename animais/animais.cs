namespace animais
{
    public abstract class Animais
    {
        public string Especie { get; set; }

        public abstract void EmitirSom();

    }

    public class gato : Animais
    {
        public string Especie { get; set; }
        public override void EmitirSom()
        {
            Console.WriteLine("miaw miaw");
        }
    }

    public class porco : Animais
    {
        public string Especie { get; set; }
        public override void EmitirSom()
        {
            Console.WriteLine("oinch oinch");
        }
    }

    public class capivara : Animais
    {
        public string Especie { get; set; }
        public override void EmitirSom()
        {
            Console.WriteLine("hahahahahaha");
        }
    }
}
