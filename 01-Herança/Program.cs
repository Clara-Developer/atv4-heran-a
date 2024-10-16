using _01_Herança;

Cachorro cachorro1 = new Cachorro
{
    Nome = "Noah Biju da Silva",
    Idade = 3,
    TipoAlimentação = "Carnívoro",
    Raca = "Lulu da Pomerânia",
    BuscaObjetos = true,
};

Console.WriteLine($"O nome do seu cachorro é {cachorro1.Nome} sua raça é {cachorro1.Raca} ele tem {cachorro1.Idade} anos, seu tipo de alimentação é {cachorro1.TipoAlimentação}. Ele busca objetos? {cachorro1.BuscaObjetos}");

Console.ReadKey();