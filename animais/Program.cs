using animais;
using System;


   gato gato = new gato
{
    Especie = "Gato do mato",
};

porco porco = new porco
{
    Especie = "leitão",
};

capivara capivara = new capivara
{
    Especie = "marrom",
};

Console.WriteLine($"A especie do seu gato é  {gato.Especie}");
gato.EmitirSom();
Console.WriteLine($"A especie do seu porco é  {porco.Especie}");
porco.EmitirSom();
Console.WriteLine($"A especie da sua capivara é  {capivara.Especie}");
capivara.EmitirSom();
Console.ReadKey();