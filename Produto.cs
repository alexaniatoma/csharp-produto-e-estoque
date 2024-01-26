
using System.Globalization;

namespace csharp_orientacao_ao_objetoEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

       public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double valorQuantidadeEmEstoque()
        {
            return Quantidade * Preco;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: R$"
            + valorQuantidadeEmEstoque().ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}