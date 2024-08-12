// See https://aka.ms/new-console-template for more information
using System.IO.Compression;

Console.WriteLine("Hello, World!");
 
 void Mensagem(){
    Console.WriteLine("olá mundo");
 }

 Mensagem();

 void Escreva(string msg){
    msg = "shalom";
Console.WriteLine(msg);
 }

Escreva("olá de novo mundo");
string minhaMsg = "testando...";
Escreva(minhaMsg);

void MostrarIdade(string nome, int idade)
{
    Console.WriteLine($"{nome} tem {idade}");
}

MostrarIdade("Nivany", 15);

    void CalcularIdade2(string nome, int ano) 
    {
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
    }

CalcularIdade2("Nivany", 2009);

int MaiorEntre(int a, int b)
{
    if(a >= b)
    {
    return a;
    }
    else
    {
    return b;
    }
}
   Console.WriteLine(MaiorEntre(99,200));
   Console.WriteLine(MaiorEntre(15,7));
   Console.WriteLine(MaiorEntre(1,1));

    //exemplo de petição

    float resultado;

    resultado = (1*8 + 5*7) / 2f;
    Console.WriteLine("a média é " + resultado);

    resultado = (7*9 + 5*0) / 2f;
    Console.WriteLine("a média é " + resultado);

    resultado = (9*9 + 3*3) / 2f;
    Console.WriteLine("a média é " + resultado);

void CalcularMedia(int a, int b)
{
    float resultado = (2*a + 3*b)/5f;
    Console.WriteLine("a média é: " + resultado);
}

CalcularMedia(100,50);
CalcularMedia(70,50);
CalcularMedia(99,33);







void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}
    
//variaveis globais
float a;
float b;

void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    Console.WriteLine("Digite o valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de b:");
    b = float.Parse(Console.ReadLine());
}

//MENU
Console.WriteLine("--- Calculadora ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("----------------------------");
Console.WriteLine("Digite a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Divisão");
    Divisao(a,b);
}
else if(opcao == 4){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine("Opção inválida");
}




