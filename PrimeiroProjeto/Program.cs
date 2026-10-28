/*
Console.WriteLine("Hello, World!");

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

// Concatenação de valores
Console.WriteLine("Meu nome é " + nome + " e o sobre nome é "  + sobrenome);

// Interpolação de valores
Console.WriteLine($"Meu nome é {nome} e o sobrenome é {sobrenome}");
*/

//*Formatação de valores
//using System.Net.NetworkInformation;


// decimal preco = 1250.5m;

// Console.WriteLine($"Preço: {preco:F2}");
// Console.WriteLine($"Preço: {preco:C}");

// preco = 1000.00m;

// const double pi = 3.1415;
// // pi = 3.14;

// //*Conversão de tipos
// double valor = 9.8;
// int numero = (int) valor;

// Console.WriteLine(numero);

// string texto = "25";
// int idade = int.Parse(texto);

// Console.WriteLine(idade);

//tryParse: tenat converter um valor sem lançar uma excessao quando a conversão falha 

// string texto = "25";

// if (int.TryParse(texto, out int idade))
// {
// 	Console.WriteLine($"Idade:  {idade}");
// }
// else
// {
// 	Console.WriteLine($"Valor Inválido");
// }
// int n = 2;
// n++;

//Estruturas de decisão 
// int idade = 80;
// if (idade >= 18)
// {
// 	Console.WriteLine("Maior de idade");
// }
// else if (idade > 18 && idade <= 60)
// {
// 	Console.WriteLine("Adulto");
// }
// else if (idade > 60)
// {
// 	Console.WriteLine("Idoso");
// }
// else
// {
// 	Console.WriteLine("Menor de idade");
// }


// //switch case 
// Console.WriteLine("""
// Selecione uma das opçãoes abaixo:
// 1 - Cadastrar
// 2 - Consiltar
// 3 - Excluir
// """);

// Console.WriteLine("Digite uma opção:");
// int opcao = int.Parse(Console.ReadLine()!);

// switch (opcao)
// {
// 	case 1:
// 		Console.WriteLine("Opção Cadastrar foi selecionada");
// 		break;
// 	case 2:
// 		Console.WriteLine("Opção Consultar foi selecionada");
// 		break;
// 	case 3:
// 		Console.WriteLine("Opção Excluir foi selecionada");
// 		break;

// 	default:
// 		Console.WriteLine("Opção inválida");
// 		break;
// }

//*estruturas de repetição 
//for

using System.Globalization;

// for (int i = 0; i < 5; i++)
// {
// 	Console.WriteLine(i);
// }

// //while
// int j = 1;
// while (j <= 5)
// {
// 	Console.WriteLine(j);
// 	j++;
// }

// //do while
// string senha;
// do
// {
// 	Console.WriteLine("Digite a sua senha: ");
// 	senha = Console.ReadLine()!;
// }
// while (senha != "123");

// Console.WriteLine("Acesso Liberado");

//*metodos

// void ExibirMensagem()
// {
// 	Console.WriteLine("Hello, world");
// }
// ExibirMensagem();

// void ExibirNome(string nome)
// {
// 	Console.WriteLine($"Olá, {nome}!");
// }
// ExibirNome("Samuel");

// int Somar(int a, int b)
// {
// 	if (a > 0)
// 	{
// 		return a + b;
// 	}
// 	else
// 	{
// 		return 0;
// 	}
// }
// Console.WriteLine(Somar(5, 3));

//*Arrays e coleções 
int[] numeros = { 10, 20, 30, 40, 50 }; //instanciando o array ja definindo os seus valores e posições

string[] nomes = new string[3]; //criando um array que ja possui 3 posições, sem valores definidos 

nomes[0] = "Ana";
nomes[1] = "Bruno";
nomes[2] = "Carla";

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes.Length);
