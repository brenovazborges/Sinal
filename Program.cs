int numero;


Console.WriteLine("----Atividade de PC1----\n");
Console.Write("Digite um numero:");
numero = Convert.ToInt32(Console.ReadLine());

if (numero <0)
{
    Console.WriteLine("Negativo");
}

else 
{
    if (numero >0)
    Console.WriteLine("Positivo");

    else 
    Console.WriteLine("Zero");
}
