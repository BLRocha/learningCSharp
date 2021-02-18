using System;
using System.Globalization;

namespace dot.utl
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produtos()
        {
            this.EnterAddDellProd();
        }

        private void EnterAddDellProd()
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            this.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qauantidade em estoque: ");
            this.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Produto: {0}", this);
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            this.AdicionarProsutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados Atualizados: {0}", this);
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            this.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados Atualizados: {0}", this);
        }

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProsutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return this.Nome + ", $" + this.Preco.ToString("F2",
                CultureInfo.InvariantCulture) + ", " + this.Quantidade + " unidades, Total: R$ " +
                this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}