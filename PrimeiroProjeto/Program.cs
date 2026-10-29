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

// //*Arrays e coleções 
// int[] numeros = { 10, 20, 30, 40, 50 }; //instanciando o array ja definindo os seus valores e posições

// string[] nomes = new string[3]; //criando um array que ja possui 3 posições, sem valores definidos 

// nomes[0] = "Ana";
// nomes[1] = "Bruno";
// nomes[2] = "Carla";

// Console.WriteLine(nomes[0]);
// Console.WriteLine(nomes[1]);
// Console.WriteLine(nomes[2]);
// Console.WriteLine(nomes.Length);

int[] numeros = { 10, 20, 30, 40 };
for (int i = 0; i < numeros.Length; i++)
{
	Console.WriteLine(numeros[i]);
}

//for each 
foreach (var numero in numeros)
{
	Console.WriteLine(numero);
}


//Lista: é uma coleção que armazeena elementos do mesmo tipo e permite aumentar ou diminuir sua quantidade durante a execução

//todo List<T>  ---> Lista de tipos genéricos

List<string> nomes = new List<string>();

nomes.Add("Ana");
nomes.Add("Bruno");
nomes.Add("Carla");

Console.WriteLine(nomes.Count);

List<int> numbers = new List<int> { 5, 12, 18, 25, 30 };

nomes.Remove("Bruno");

Console.WriteLine(nomes.Count);
Console.WriteLine(nomes.Contains("Ana"));

int encontrado = numbers.Find(n => n > 20); //retorna apenas o primeiro elemento da lista que atende o critério de filtro

Console.WriteLine(encontrado);

string? nome_encontrado = nomes.Find(nome => nome.StartsWith("C"));

Console.WriteLine(nome_encontrado);

//Dicionario: dicionary<TKey, tvalue>
Dictionary<int, string> produtos = new Dictionary<int, string>();

produtos.Add(101, "Notebook");
produtos.Add(102, "Mouse");
produtos.Add(103, "Teclado");

// Console.WriteLine(produtos[101]);

if (produtos.ContainsKey(104))
{
	Console.WriteLine(produtos[104]);
}
else
{
	Console.WriteLine("Produto Não Encontrado");
}

foreach (var produto in produtos)
{
	Console.WriteLine(
$"Código: {produto.Key} - Nome: {produto.Value}"

	);
}