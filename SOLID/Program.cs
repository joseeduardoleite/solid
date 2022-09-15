// using SOLID.LSP.Violacao;
// using SOLID.LSP.Solucao;

//LSP Violacao
// Apple apple = new Orange();
// Console.WriteLine(apple.GetColor());

// LSP Solucao
// Fruit fruit = new Orange();
// Console.WriteLine(fruit.GetColor());
// fruit = new Apple();
// Console.WriteLine(fruit.GetColor());

DateTime dateLCI = new DateTime(2021, 10, 15);
Console.WriteLine("LCI 1\n" + "Aplicação: " + dateLCI.ToString("dd/MM/yyyy"));
Console.WriteLine("Resgate: " + dateLCI.AddDays(180).ToString("dd/MM/yyyy"));

dateLCI = new DateTime(2021, 12, 20);
Console.WriteLine("\nLCI 2\n" + "Aplicação: " + dateLCI.ToString("dd/MM/yyyy"));
Console.WriteLine("Resgate: " + dateLCI.AddDays(180).ToString("dd/MM/yyyy"));

System.Console.WriteLine();
System.Console.WriteLine("\\");