int inicio, fim;



string mensagem = "";

try
{
    Console.Write("Início:");
    inicio = Convert.ToInt32 (Console.ReadLine()!);


    Console.Write("Fim:");
    fim = Convert.ToInt32 (Console.ReadLine()!);

    if (fim < inicio)
    {
        throw new Exception ("O segundo número não pode ser menor que o primeiro");
    }

    while (inicio <= fim)
    {
       
        mensagem += $"{inicio++} ";

    }

    //Exibe mensagem de sucesso
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{mensagem}");

}
  catch (FormatException e)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("É necessário digitar um número válido.");
    Console.WriteLine(e.Message);
}
    catch (Exception e)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(e.Message);
}
finally
{
    Console.ResetColor();
    Console.WriteLine("Obrigado por utilizar nosso programa!");
}
