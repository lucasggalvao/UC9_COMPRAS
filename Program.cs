// Criar variáveis necessárias
double produto, total, totaldesconto;
int i;

// Inicializar Variáveis
total = 0;
totaldesconto = 0;

// Informar valores de produtos
for (i = 1; i <= 5; i++)
{
    Console.WriteLine("Informe o " + i + "º valor de produto");
    produto = double.Parse(Console.ReadLine());
    total = total + produto;
    Console.Clear();
    Console.WriteLine("O Total atual é: " + total);
}

totaldesconto = total - (total * 0.347);
Console.WriteLine("O Total com desconto de 34,7% é: " + totaldesconto);