namespace DesafioProduto;

public class Produto
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public DateOnly DataValidade { get; set; }
    public List <Produto> Produtos { get; set; } // LISTA DE PRODUTOS
    = new List<Produto>();

// MÉTODO DE CADASTRAR O PRODUTO
    public void CadastrarProduto(string nome, DateOnly validade)
    {
        Produto produto = new Produto()
        { Nome = nome, DataValidade = validade};


    Produtos.Add(produto);
    }

    public void MostrarProdutos()
    {
        foreach(var prod in Produtos){
            Console.WriteLine($"Produto: {prod.Nome}  Validade: {prod.DataValidade}  ID: {prod.ID}");
        }
    }
    
}

