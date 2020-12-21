using System.Collections.Generic;

namespace ObjetosArgumento.classes
{
    public class Produto
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);        }
        }
        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }
        public void MostrarProdutos()
        {
            if(Carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R$ {p.Preco.ToString("n2")} - {p.Nome} ");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if(Carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($" Total do Carrinho R$ {ValorTotal.ToString("n2")} ");
            }else{
                Console.WriteLine($" Seu carrinho ainda está vazio! ");
            }
            Console.ResetColor();

            publi void AlteraeItem(int _codigo, Produto _novoProduto){
                Carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
                Carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
            }
        }
}