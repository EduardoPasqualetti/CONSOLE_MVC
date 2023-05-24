using PROJETO_MVC.Model;

namespace PROJETO_MVC.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos) 
        {
            Console.Clear();
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:c}");
            }
        }
    }
}