int num1, num2, num3, num4, num5, num6, cpf1, cpf2, cpf3, cpf4, idade;
int result1, result2, result3, result4, result5, result6;
int saida;
bool continuar = true;

Random dice = new Random();

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
Console.WriteLine("\n");

Console.WriteLine("Qual é a sua idade?\n");
idade = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Aperte Enter para gerar o CPF.\n");
Console.ReadKey();
Console.WriteLine($"{cpf1}.{cpf2}.{cpf3}-{cpf4}");
Console.WriteLine("\n");

if (idade >= 18) 
{
    Console.WriteLine("Escolha o número de 0 a 60. \n");

    Console.WriteLine("Escolha o primeiro número. \n");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Escolha o segundo número. \n");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Escolha o terceiro número. \n");
    num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Escolha o quarto número. \n");
    num4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Escolha o quinto número. \n");
    num5 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Escolha o sexto número. \n");
    num6 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Bem vindo ao sorteio. \n");
    Console.WriteLine($"Os seus números escolhidos: {num1}, {num2}, {num3}, {num4}, {num5}, {num6}");
    Console.WriteLine("\n");
    Console.WriteLine($"Os números sorteados são: {result1}, {result2}, {result3}, {result4}, {result5}, {result6}");
    Console.WriteLine("\n");

    while (continuar) 
    {
        Console.WriteLine("Quer tentar de novo? - 0 para Sim / 1 para Não \n"); 
        saida = Convert.ToInt16(Console.ReadLine());    
        switch (saida) 
        {
            case 0:
                Console.WriteLine("\n");
                Console.WriteLine("Escolha o número de 0 a 60. \n");

                Console.WriteLine("Escolha o primeiro número. \n");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Escolha o segundo número. \n");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Escolha o terceiro número. \n");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Escolha o quarto número. \n");
                num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Escolha o quinto número. \n");
                num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Escolha o sexto número. \n");
                num6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Bem vindo ao sorteio. \n");
                Console.WriteLine($"Os seus números escolhidos: {num1}, {num2}, {num3}, {num4}, {num5}, {num6}");
                Console.WriteLine("\n");
                Console.WriteLine($"Os números sorteados são: {result1}, {result2}, {result3}, {result4}, {result5}, {result6}");
                Console.WriteLine("\n");
                break;

            case 1:
                Console.WriteLine("\n");
                Console.WriteLine("Boa sorte na próxima vez. \n");
                continuar = false;
                break;

            default:
                Console.WriteLine("\n");
                Console.WriteLine("Esse número não está nas opções do sorteio. \n");
                break;
        }
    }
}
else 
{
    Console.WriteLine("Infelizmente você não pode participar, porque só é permitido para maiores dezoito anos.");
}