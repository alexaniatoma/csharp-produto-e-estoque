using System.Globalization;
using csharp_orientacao_ao_objetoEstoque;

Console.WriteLine("Entre com os dados do produto");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco, quantidade);

Console.WriteLine("Dados do produto " + produto);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");

int qtdade = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(qtdade);
Console.WriteLine("Dados atualizados do estoque " + produto);
Console.WriteLine();

Console.Write("Quantidade a ser removido do estoque: ");
int qtdadeRemove = int.Parse(Console.ReadLine());
produto.RemoverProdutos(qtdadeRemove);
Console.WriteLine("Dados atualizados do estoque: " + produto);
Console.WriteLine();







