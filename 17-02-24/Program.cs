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
produto.CadastrarProduto("Leite", new DateOnly(2024,01,03)); // copie apenas essa linha para criar um novo produto
produto.CadastrarProduto("Arroz", new DateOnly(2024,09,05));
produto.CadastrarProduto("café", new DateOnly(2023,10,02));
produto.CadastrarProduto("Carne", new DateOnly(2024,02,17));
produto.CadastrarProduto("Chocolate", new DateOnly(2024,02,19));



produto.MostrarProdutosLetra('C'); // usando o método de filtro de letra inicial
produto.MostrarProdutos(); // usando o método de mostrar todos os produtos
