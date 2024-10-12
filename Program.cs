double n1, n2, n3, n4, media;
string resultado;

Console.Clear();
Console.WriteLine("-- Média --\n");
Console.WriteLine("Digite as suas notas abaixo.");

Console.WriteLine("Nota 1: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 2: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 3: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota 4: ");
n4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (n1 < 0.0 || n1 > 10.0
   || n2 < 0.0 || n2 > 10.0
   || n3 < 0.0 || n3 > 10.0
   || n4 < 0.0 || n4 > 10.0)


{
    Console.WriteLine("Digite somente notas entre 0.0 e 10.0.");
}
else
{
    media = (n1 + n2 + n3 + n4) / 4;
    if (media < 5.0)
    {
        resultado = "Reprovado";
    }
    else if (media > 5.0 && media < 6.0)
    {
        resultado = "Em recuperção";
    }
    else
    {
        resultado = "Aprovado";
    }
    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}

