using System;
class Program {
static void Main() {

    // Declaração de variáveis
    int score = 0;
    int resposta_a;
    int resposta_b;
    string resposta_c;
    string resposta_d;


    // Perguntas feitas para o usuário
    Console.WriteLine("Quanto é 137 - 128 ?");
    resposta_a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Quanto é 1677 - 1577 ?");
    resposta_b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o nome do navio que deu origim a um filme ganhador de Oscar ?");
    resposta_c = Console.ReadLine().ToLower().Trim();

    Console.WriteLine("Qual foi a primeira linguagem de programação a ser comercializada ?");
    resposta_d = Console.ReadLine().ToLower().Trim();


    // Parte lógica
    if (resposta_a == 9){
        score++;
    }

    if (resposta_b == 100){
        score++;
    }

    if (resposta_c == "titanic"){
        score++;
    }

    if (resposta_d == "fortran"){
        score++;
    }

    // Impressão do Resultado
    Console.WriteLine("A sua pontuação final foi de: " + score);
}
}