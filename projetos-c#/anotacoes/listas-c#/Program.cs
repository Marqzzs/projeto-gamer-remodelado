using listas_c_;

//Criar uma lista de objetos(produtos)
List<Produto> produtos = new List<Produto>();

//inserir objetos de produtos dentro da lista
//atraves de uma instancia direta (com construtores)
produtos.Add(new Produto(1234, "Cam Lacoste", 299.99f));

//atraves de uma instancia basica de objeto
Produto camisetaArmani = new Produto(1235, "Cam Armani", 199.99f);
produtos.Add(camisetaArmani);

//read
foreach (var item in produtos)
{
    Console.WriteLine($"\n\n Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
}

//upadate

//acessar um objeto da lista para manipula-lo
Produto produtoEncontrado = produtos.Find(item => item.Codigo == 1235);
int index = produtos.IndexOf(produtoEncontrado);
Console.WriteLine($"O indeice do produto encontrado é : {index}");

//fazer alterações
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item a lista
produtos.Insert(index, produtoEncontrado);

foreach (var item in produtos)
{
    Console.WriteLine($"\n\n Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
    
}
