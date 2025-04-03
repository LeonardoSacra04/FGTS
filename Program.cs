decimal salario;
decimal fgts;

Console.Clear();

Console.WriteLine("Digite qual é o seu salário: ");
salario = Convert.ToDecimal(Console.ReadLine()!);

Console.Clear();

fgts = salario * 0.08m;

Console.WriteLine($"Seu salário: {salario:C2}");
Console.WriteLine($"FGTS: {fgts:C2}");
