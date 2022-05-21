Console.Write("quantos elefantes: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

if (quantidade <= 2 || quantidade % 2 ==1)
{
    Console.WriteLine("\nsomente serão aceitos numeros pares de elefantes, maiores do que 2. ");
}
else
{
    int elefanteAtuais = 1;

    while (elefanteAtuais <= quantidade)
    {
        if (elefanteAtuais == 1)
        {
            Console.WriteLine($"\n{elefanteAtuais} elefante incomoda muita gente ");
        }
        else
        {
            Console.WriteLine($"\n{elefanteAtuais} elefantes incomodam muita gente");
        }

        elefanteAtuais += 1;

        Console.Write($"{elefanteAtuais} elefantes");

        int incomoda = 1;
        while (incomoda <= elefanteAtuais)
        {
            Console.Write("incomodam ");
            incomoda += 1;
        }

        Console.Write("muito mais");
        elefanteAtuais += 1;
 }
}

