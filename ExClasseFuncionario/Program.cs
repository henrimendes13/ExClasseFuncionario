using ExClasseFuncionario;

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Salário bruto: ");
funcionario.SalaraioBruto = double.Parse(Console.ReadLine());

Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine($"Funcionario: {funcionario}");

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagem);

Console.Write($"Dados atualizados: {funcionario}");

