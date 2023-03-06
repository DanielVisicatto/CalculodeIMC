Console.WriteLine("Escolha o sexo (M) ou (F)");
char sex = char.Parse(Console.ReadLine());

Console.Write("Digite a altura: ");
double altura = float.Parse(Console.ReadLine());
Console.Write("Digite o peso: ");
double peso = float.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

if (sex == 'm')
{
    if (imc < 20.7)
    {
        Console.WriteLine("Abaixo do peso!");
    }
    else if (imc < 26.5)
    {
        Console.WriteLine("Peso ideal!");
    }
    else if (imc < 27.9)
    {
        Console.WriteLine("Pouco acima do peso!");
    }
    else if (imc < 31.2)
    {
        Console.WriteLine("Acima do peso!");
    }
    else
        Console.WriteLine("Obesidade!");

}
else
{
    if (imc < 19.1)
    {
        Console.WriteLine("Abaixo do peso!");
    }
    else if (imc < 25.9)
    {
        Console.WriteLine("Peso ideal!");
    }
    else if (imc < 27.4)
    {
        Console.WriteLine("Pouco acima do peso!");
    }
    else if (imc < 32.3)
    {
        Console.WriteLine("Acima do peso!");
    }
    else
        Console.WriteLine("Obesidade!");
}