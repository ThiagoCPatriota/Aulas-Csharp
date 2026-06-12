// ---------------- CADASTRO POR VARIAVEIS ----------------

// int idade = 10;
// string nome = "Thiago Patriota";
// double altura = 1.68;
// bool desempregado = true;



// ---------------- CADASTRO POR PROMPT console.ReadLine ----------------

// Console.Write("Nome: ");
// string nome = Console.ReadLine();
// Console.Write("Idade: ");
// int idade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos");



// ---------------- Identificação de tipos simples po var ----------------

// var nome = "true";
// Console.WriteLine(nome);

// var nome = "João";
// var idade = 20;
// var aprovado = true;
// var salario = 3000.75m;



// ---------------- Tipos nulos, ou valores anuláveis. ----------------

// int? idade = null;


// ---------------- Utilizando o convert.ToInt ----------------

// var idade = "10";
// Console.WriteLine(Convert.ToInt32(idade));



//---------------- Utilizando o Casting - Trocando valores double para int ----------------

// double salario = 1470.98;
// Console.WriteLine(salario);
// int salario2 = (int)salario;
// Console.WriteLine(salario2);

// ---------------- Mini-exx001 Calcular desconto ----------------

// double salario = 1470.98;
// double valor_final = salario - (salario * 0.90 / 100);
// Console.WriteLine($"Preço final: {valor_final}");

// ---------------- if ----------------
// Console.WriteLine("Digite sua idade: ");
// int idade = Convert.ToInt32(Console.ReadLine());
// if (idade >= 18)
// {
//     Console.WriteLine("Você é maior de idade");
// }
// else
// {
//     Console.WriteLine("Você não pode dirigir");
// }

// ---------------- Mini Desafio exx002 - IMC ----------------

// Console.WriteLine("Digite seu peso: ");
// double peso = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite a sua altura: ");
// double altura = Convert.ToDouble(Console.ReadLine());
// double resultado_imc = peso / Math.Pow(altura, 2);
// if (resultado_imc >= 30)
// {
//     Console.WriteLine("Gordo pa porra");
// }
// else if (resultado_imc >= 25 || resultado_imc <= 29.9)
// {

//     Console.WriteLine("Gordin");
// }
// else if (resultado_imc >= 18.5 || resultado_imc <= 18.5)
// {
//     Console.WriteLine("Normal");
// }
// else
// {
//     Console.WriteLine("Israel Vicente");
// }


// ---------------- Exx003 - Calculadora com Menu ----------------

// Console.WriteLine("Escolha um operador matematico (+, -, /, *): ");
// string operador = Console.ReadLine();

// Console.Write("Digite um número: ");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Digite outro número: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// switch (operador)
// {
//     case "+":
//         Console.WriteLine(num1 + num2);
//         break;
//     case "-":
//         Console.WriteLine(num1 - num2);
//         break;
//     case "/":
//         Console.WriteLine(num1 / num2);
//         break;
//     case "*":
//         Console.WriteLine(num1 * num2);
//         break;
// }

// ---------------- Switch case - outro exemplo ----------------

// int nota = 10;
// var resultado = nota switch
// {
//     >= 9 => "Aprovado",
//     >= 7 => "aprovado",
//     >= 5 => "recuperação",
//     _ => "reprovado"
// };


// ---------------- for ----------------

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(new string('o', i));
// }

// ---------------- While ----------------

// ingual a javascript

// ---------------- Desafio de acumulação e fuga - Missao 1 ----------------

// int soma = 0;
// for (int i = 1; i <= 100; i++)
// {
//     soma += i;
// }
// Console.WriteLine(soma);

// ---------------- Desafio de acumulação e fuga - Missao 2 ----------------

// int soma = 0;
// int[] alunos = [10, 8, 1];
// foreach (var aluno in alunos)
// {
//     soma += aluno;

// }
// Console.WriteLine(soma / alunos.Length);

// ---------------- Desafio de acumulação e fuga - Missao 3 ----------------
// bool parada = true;
// int contador = 0;
// bool acesso = true;
// string usuario = "vinicius";
// int senhaAdm = 123;

// while (parada)
// {
//     if (contador >= 3)
//     {
//         Console.WriteLine("Seu acesso está bloqueado!");
//         Console.WriteLine("Saindo do sistema...");
//         parada = false;
//         acesso = false;
//     }

//     if (acesso)
//     {
//         Console.WriteLine("Login: ");
//         string nickname = Console.ReadLine().ToLower();
//         Console.WriteLine("Senha: ");
//         int senha = Convert.ToInt32(Console.ReadLine());

//         if (nickname != usuario || senha != senhaAdm)
//         {
//             Console.WriteLine("Usuario ou senha incorretas");
//             contador += 1;
//         }
//         else
//         {
//             Console.WriteLine("Logado com sucesso!");
//             break;
//         }
//     }
// }

// ---------------- treinando metodos ----------------

// string saudar()
// {
//     return "Olá";
// }
// Console.WriteLine(saudar());

// string verificaraprovacao(double nota)
// {
//     return nota >= 7 ? "aprovado" : "reprovado";
// }
// Console.WriteLine(verificaraprovacao(10));

// ---------------- treinando Objetos ----------------

Aluno aluno1 = new Aluno();
aluno1.Nome = "homi";
aluno1.Idade = 17;

Console.WriteLine(aluno1.Nome);
