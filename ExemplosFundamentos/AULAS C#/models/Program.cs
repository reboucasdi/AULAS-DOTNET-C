using AULAS_C_.models;
#pragma warning disable CS8632

// OPERADOR OR ( PIPE, ||)















// SWITCH CASE - CONDIÇÕES 2º EXEMPLO

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine()!;

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal brother :/");
//         break;
// }


// //SWITCH CASE - CONDIÇÕES 1º MANEIRA 

// Console.WriteLine("Digite uma letra");

// string letra = Console.ReadLine();


// if ( letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal brother :/");
// }



// //OPERADOR CONDICIONAL - 2º EXEMPLO

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em estoque: {quantidadeCompra}");
// Console.WriteLine($"Quantidade em estoque: {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }

// else if(quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada em nome de Jesus o/");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque. Mas Deus há de prover Amém?");
// }


// //OPERADOR CONDICIONAL

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em estoque: {quantidadeCompra}");
// Console.WriteLine($"Quantidade em estoque: {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }

// else if(quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada em nome de Jesus o/");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque. Mas Deus há de prover Amém?");
// }



// CONVERSÃO SEGURA
// string a = "15-";
// //int b = 0;
// int.TryParse(a, out int b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso! Jesus é maravilhoso o tempo todo <3");


// ORDEM DOS OPERADORES
// SIMPLES double a = 4 / 2 + 2; = 4
// PARENTESES double a = 4 / (2 + 2); = 1
// Console.WriteLine(a);




// Cast - casting - CONVERSÕES
//int a = Convert.ToInt32("5");
//int a = int.Parse("5 c");
// int a = 5;
// double b = a;
// long a= long.MaxValue;
// int b =  Convert.ToInt32(a);
// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b);



// OPERADORES DE ATRIBUIÇÃO
// int a = 10;
// int b = 20;
// int c = a + b;
// c += c + 5;
// Console.WriteLine(c);



// TRABALHAR COM DATAS
//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



// SINTAXES
//string apresentacao = "Olá, seja bem vindo - Jesus Cristo é o senhor e poucas idéias!";

//int quantidade = 1;
//quantidade = 10;
//double altura = 1.83;
//decimal preco = 1.80M;
//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0"));
//Console.WriteLine("Valor da variável preço: " + preco);
//Console.WriteLine("Valor da variável condição: " + condicao);


// Objetos 
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Diego";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();
    
