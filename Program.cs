int numeroUm, numeroDois;

Console.Write("Início:");
numeroUm = Convert.ToInt32 (Console.ReadLine()!);


Console.Write("Fim:");
numeroDois = Convert.ToInt32 (Console.ReadLine()!);

string mensagem = "";

try
{
    if (numeroDois < numeroUm)
    {
        throw new Exception ("O segundo número não pode ser menor que o primeiro");
    }

    while (numeroUm <= numeroDois)
    {
        mensagem += $"{numeroUm++}";
    }
    Console.WriteLine($"{mensagem}");
}
    catch (Exception e)
{
    Console.WriteLine($"{mensagem}");
}
