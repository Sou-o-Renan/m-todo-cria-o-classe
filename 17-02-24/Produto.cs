namespace DesafioProduto;

public class Produto
{         // TUDO QUE PRECISA NO PRODUTO
    public int ID { get; set; }
    public string Nome { get; set; }
    public DateOnly DataValidade { get; set; }

//____________________________________________________________________//
//________________________LISTA DE PRODUTOS________________________________//

    public List <Produto> Produtos { get; set; } 
    = new List<Produto>();
//____________________________________________________________________//


//______________________MÉTODO DE CADASTRAR O PRODUTO________________________________//

    public void CadastrarProduto(string nome, DateOnly validade) // método de cadastrar um produto
    {
        Produto produto = new Produto()
        { Nome = nome, DataValidade = validade};


    Produtos.Add(produto);
    }
//____________________________________________________________________//


//____________________________________________________________________//


// MÉTODO PARA MOSTRAR PRODUTOS POR FILTRO DA LETRA
    public void MostrarProdutosLetra(char LetraFiltro) // método de filtrar por letra inicial um produto
    {

        foreach(var produto in Produtos){
            if(produto.Nome[0].ToString().ToUpper() == LetraFiltro.ToString().ToUpper()){
             Console.WriteLine($"Produto: {produto.Nome}  Validade: {produto.DataValidade}  ID: {produto.ID}");

            }
        }


    }

    public void MostrarProdutos() // método de mostrar todos os produtos
    {
        foreach(var prod in Produtos){
            Console.WriteLine($"Produto: {prod.Nome}  Validade: {prod.DataValidade}  ID: {prod.ID}");
        }
    }
    
}

