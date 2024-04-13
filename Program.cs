Console.Clear();

double altura, pesoIdeal;
string sexo;

Console.Write("Digite sua altura em cm:");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]asculino / [F]eminino:");
sexo = Console.ReadLine()!.ToUpper().Substring(0, 1);

if (sexo == "M")
{
    pesoIdeal = altura * 72.7 - 58.0;
}
else

{
    pesoIdeal = altura * 62.1 - 44.7;
}

Console.WriteLine($"Seu peso ideal é {pesoIdeal:n1}kg");
