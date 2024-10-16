namespace _01_Herança
{
    /*A classe "animal" é uma clase abstrata que servirá para os outros animais  */
    public abstract class animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string TipoAlimentação { get; set; }
    
    /* Método abstrato - não possui implementação aqui, mas a classe que herdaram vao precisar implementar*/
    public abstract void EmitirSom(); 
    }

    //A classe "cachorro" herda da classe "animal"
    //Isso significa que o cachorro terá todos os atributos e comportamentos definidos em Animal. Mas também pode ter suas próprias características

    public class Cachorro : animal
    { 
        public string Raca { get; set; }
        //bool significa booleana, ou seja, espera uma resposta verdadeira ou falsa para o atributo
        public bool BuscaObjetos { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }

}
