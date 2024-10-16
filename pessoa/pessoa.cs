namespace pessoa
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Envelhecer (int anos)
        {
            Idade += anos;
        }

        public void Aguadavida(int anos)
        {
            Idade -= anos;
        }
    }
    public class funcionario : Pessoa
        {

        }
    
}
