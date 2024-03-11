int n1, n2, opc, soma, sub, div, mult;

Console.WriteLine("Informe o 1 número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o 2 número: ");
n2 = int.Parse(Console.ReadLine());

if (n1 > 0 && n2 > 0)
{
    Console.WriteLine("Que operação você deseja realizar ? ");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - multiplicação");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            soma = n1 + n2;
            Console.WriteLine("A soma é " + soma);
            break;
        case 2:
            sub = n1 - n2;
            Console.WriteLine("A subtração é " + sub);
            break;
        case 3:
            div = n1 / n2;
            Console.WriteLine("A divisao é " + div);
            break;
        case 4:
            mult = n1 * n2;
            Console.WriteLine("A multiplicação é " + mult);
            break;
    }
}
else
{
    Console.WriteLine("Os números informados são negativos");
}