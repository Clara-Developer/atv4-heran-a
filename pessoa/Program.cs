using pessoa;

funcionario Pessoa1 = new funcionario { Nome = "Anna Camilo", Idade = 30 };

Pessoa1.Envelhecer(10);//Somar a idade que você passou para a variavel pessoa 1
Console.WriteLine($"sua idade envelhecida é: {Pessoa1.Idade}");
Pessoa1.Aguadavida(5);
Console.WriteLine($"Sua idade depois da fonte da vida é: {Pessoa1.Idade}");

funcionario Pessoa2 = new funcionario { Nome = "Carlos Eduardo", Idade = 70 };

Pessoa2.Envelhecer(10);
Console.WriteLine($"sua idade envelhecida é: {Pessoa2.Idade}");
Pessoa2.Aguadavida(10);
Console.WriteLine($"Sua idade depois da fonte da vida é: {Pessoa2.Idade}");

funcionario Pessoa3 = new funcionario { Nome = "Joana dark", Idade = 24 };

Pessoa3.Envelhecer(10);
Console.WriteLine($"sua idade envelhecida é: {Pessoa3.Idade}");
Pessoa3.Aguadavida(10);
Console.WriteLine($"Sua idade depois da fonte da vida é: {Pessoa3.Idade}");


Console.WriteLine("Pressione uma tecla para encerrar");
Console.ReadKey();