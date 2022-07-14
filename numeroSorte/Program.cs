// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int num1, num2, num3, num4, num5, num6, cpf1, cpf2, cpf3, cpf4, idade;
int result1, result2, result3, result4, result5, result6;

Random dice = new Random();
num1 = dice.Next(0, 60);
num2 = dice.Next(0, 60);
num3 = dice.Next(0, 60);
num4 = dice.Next(0, 60);
num5 = dice.Next(0, 60);
num6 = dice.Next(0, 60);
result1 = dice.Next(0, 60);
result2 = dice.Next(0, 60);
result3 = dice.Next(0, 60);
result4 = dice.Next(0, 60);
result5 = dice.Next(0, 60);
result6 = dice.Next(0, 60);
cpf1 = dice.Next(000, 999);
cpf2 = dice.Next(000, 999);
cpf3 = dice.Next(000, 999);
cpf4 = dice.Next(00, 99);

Console.WriteLine("Qual o seu nome?\n");
Console.ReadLine();
Console.WriteLine(" ");

Console.WriteLine("Qual é a sua idade?\n");
idade = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Aperte Enter para gerar o CPF.\n");
Console.ReadKey();
Console.WriteLine(cpf1 + "." + cpf2 + "." + cpf3 + "-" + cpf4);
Console.WriteLine(" ");

if (idade >= 18) 
{
    Console.WriteLine("Bem vindo ao sorteio. \n");
    Console.WriteLine("O resultado do sorteio é: " + result1 + ", " + result2 + ", " + result3 + ", " + result4 + ", " + result5 + ", " + result6);
    Console.WriteLine(" ");
    Console.ReadKey();
    Console.WriteLine("Os seus números sorteados são: " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5 + ", " + num6);
}
else 
{
    Console.WriteLine("Infelizmente você não pode participar, porque só é permitido para maiores dezoito anos.");
}

