// criar classe de um produto 
// produto tem ID, Nome, Data de Validade.
// produtos dentro da validade, serão vendidos
// produtos fora da validade, guardados.




// CADASTRAR PRODUTO MANUALMENTE
// Produto produto1 = new Produto();
// produto1.ID = 1;
// produto1.Nome = "Leite";
// produto1.DataValidade = new DateOnly(2024, 01, 13);
using DesafioProduto;



Produto produto = new Produto();
produto.CadastrarProduto("Leite", new DateOnly(2024,01,03));
produto.MostrarProdutos();
