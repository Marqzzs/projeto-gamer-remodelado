// // // ///////////////////////////////////////////////////////////////////////TEMA ARRAYS//////////////////////////////////////////////////////////////////////////////////////

// // //Arrays são usados ​​para armazenar vários valores em uma única variável, em vez de declarar variáveis ​​separadas para cada valor.
// // //Para declarar um array, defina o tipo de variável com colchetes []

// // // string[] cars;
// // // Agora declaramos uma variável que contém um array de strings.

// // // Para inserir valores nele, podemos usar um array literal - coloque os valores em uma lista separada por vírgulas, entre chaves:

// // // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// // // Para criar um array de inteiros, você poderia escrever:

// // // int[] myNum = {10, 20, 30, 40};

// // // Acessar os elementos de um array
// // // Você acessa um elemento de matriz referindo-se ao número do índice.

// // // Esta instrução acessa o valor do primeiro elemento em cars :

// // // Exemplo:
// // // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// // // Console.WriteLine(cars[0]);
// // // Outputs Volvo

// // // Alterar um elemento de matriz
// // // Para alterar o valor de um elemento específico, consulte o número do índice:

// // // Exemplo
// // // cars[0] = "Opel";
// // // Exemplo
// // // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// // // cars[0] = "Opel";
// // // Console.WriteLine(cars[0]);
// // // // Now outputs Opel instead of Volvo

// // // Comprimento da Matriz
// // // Para descobrir quantos elementos um array tem, use a Lengthpropriedade:

// // // Exemplo
// // // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// // // Console.WriteLine(cars.Length);
// // // Outputs 4

// // // Outras maneiras de criar uma matriz
// // // Se você estiver familiarizado com C#, poderá ter visto arrays criados com a newpalavra-chave e talvez tenha visto arrays com um tamanho especificado também. Em C#, existem diferentes maneiras de criar um array:

// // // // Create an array of four elements, and add values later
// // // string[] cars = new string[4];

// // // // Create an array of four elements and add values right away 
// // // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// // // // Create an array of four elements without specifying the size 
// // // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// // // // Create an array of four elements, omitting the new keyword, and without specifying the size
// // // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


// // ///********************************COM FOR****************************************////


// // ///// using System;

// // // class Program
// // // {
// // //     static void Main(string[] args)
// // //     {
// // //         // Lê um array de números inteiros
// // //         Console.WriteLine("Digite os números separados por espaço:");
// // //         string input = Console.ReadLine();
// // //         string[] stringNumeros = input.Split(' ');
// // //         int[] numeros = new int[stringNumeros.Length];
// // //         for (int i = 0; i < stringNumeros.Length; i++)
// // //         {
// // //             numeros[i] = int.Parse(stringNumeros[i]);
// // //         }

// // //         // Encontra o maior e o menor valor do array
// // //         int maior = numeros[0];
// // //         int menor = numeros[0];
// // //         for (int i = 1; i < numeros.Length; i++)
// // //         {
// // //             if (numeros[i] > maior)
// // //             {
// // //                 maior = numeros[i];
// // //             }
// // //             if (numeros[i] < menor)
// // //             {
// // //                 menor = numeros[i];
// // //             }
// // //         }

// // //         // Imprime o resultado
// // //         Console.WriteLine("Maior valor: " + maior);
// // //         Console.WriteLine("Menor valor: " + menor);
// // //     }
// // // }

// // //**********************************COM FOREACH******************************//

// // // int[] numeros = { 1, 2, 3, 4, 5 };

// // // foreach (int numero in numeros)
// // // {
// // //     Console.WriteLine(numero); // imprime o valor de cada elemento do array
// // // }





// // //**************************************************************FUNÇÕES********************************************************************//

// // Um método é um bloco de código que só é executado quando é chamado.

// // Você pode passar dados, conhecidos como parâmetros, para um método.

// // Os métodos são usados ​​para executar determinadas ações e também são conhecidos como funções .

// // Por que usar métodos? Para reutilizar o código: defina o código uma vez e use-o várias vezes.

// // Criar um método
// // Um método é definido com o nome do método, seguido de parênteses () . C# fornece alguns métodos predefinidos, com os quais você já está familiarizado, como Main(), mas também pode criar seus próprios métodos para executar determinadas ações:

// // ExemploObtenha seu próprio servidor C#
// // Crie um método dentro da classe Program:

// // class Program
// // {
// //   static void MyMethod() 
// //   {
// //     // code to be executed
// //   }
// // } 
// // Exemplo explicado
// // MyMethod()é o nome do método
// // staticsignifica que o método pertence à classe Program e não um objeto da classe Program. Você aprenderá mais sobre objetos e como acessar métodos por meio de objetos posteriormente neste tutorial.
// // voidsignifica que este método não tem um valor de retorno. Você aprenderá mais sobre valores de retorno posteriormente neste capítulo
// // Observação: em C#, é uma boa prática começar com uma letra maiúscula ao nomear métodos, pois isso facilita a leitura do código.

// // Chame um método
// // Para chamar (executar) um método, escreva o nome do método seguido de dois parênteses () e um ponto e vírgula ;

// // No exemplo a seguir, MyMethod()é usado para imprimir um texto (a ação), quando é chamado:

// // Exemplo
// // Dentro de Main(), chame o myMethod()método:

// // static void MyMethod() 
// // {
// //   Console.WriteLine("I just got executed!");
// // }

// // static void Main(string[] args)
// // {
// //   MyMethod();
// // }

// // // Outputs "I just got executed!"
 

// // Um método pode ser chamado várias vezes:

// // Exemplo
// // static void MyMethod() 
// // {
// //   Console.WriteLine("I just got executed!");
// // }

// // static void Main(string[] args)
// // {
// //   MyMethod();
// //   MyMethod();
// //   MyMethod();
// // }

// // // I just got executed!
// // // I just got executed!
// // // I just got executed!


// //*********************************CLASS***********************************//

// //criação de personagem utilizando classe

// //toda classe deve começar com letra maiuscula
// //utilizar o mesmo nome da classe com a do arquivo para facilitar
// //criação

// // public class Personagem
// // {
// //     //declarar as propriedades
// //     public string nome = "Tony Stark";
// //     public int idade = 35;
// //     public string armadura = "Bleeding Edge";
// //     public string IA = "Jarvis";

// //     //declarar os metodos

// //     public void Atacar()
// //     {
// //         Console.WriteLine($"O personagem atacou");
// //     }

// //     public void Defender()
// //     {
// //         Console.WriteLine($"O personagem defendeu");
// //     }

// //     public void RestaurarArmadura()
// //     {
// //         Console.WriteLine($"O personagem restaurou a armadura");     
// //     }

// // }

// //levar essa classe agora para a Program.cs

// // using POO;

// // //instaciamos um objeto da classe Personagem
// // Personagem tony = new Personagem();

// // Console.WriteLine(tony.Atacar);

// //**********************************************pilares POO***************************************//

// //São eles: abstração, herança, polimorfismo; encapsulamento

// //abstração: abstrai apenas os elementos necessarios, para não vir informações desnecessarias
// //herança, cria uma classe abrstrata com informações uteis, comuns que se repetem, e podemos criar subclasses para herdas as propriedades e funções para não ter que criar novas propriedades e funções iguais
// //polimorfismo: duas vertentes; a sobre escrita e a sobrecarga
// //sobre escrita; reescreve os parametros da classe mãe na classe filha
// //sobre carga;são as diversas formas de carga no metodo
// //encapsulamento; ato de proteger ou encapsular


// //////////////////////////////////////////****** LIST ***********************************************************/////////////////////////////
// Add(T)	
// Adiciona um objeto ao final do List<T>.

// AddRange(IEnumerable<T>)	
// Adiciona os elementos da coleção especificada ao final do List<T>.

// AsReadOnly()	
// Retorna um wrapper ReadOnlyCollection<T> somente leitura para a coleção atual.

// BinarySearch(Int32, Int32, T, IComparer<T>)	
// Pesquisa um intervalo de elementos no List<T> classificado para encontrar um elemento que usa o comparador especificado e retorna o índice baseado em zero do elemento.

// BinarySearch(T)	
// Pesquisa todo o List<T> classificado para um elemento usando o comparador padrão e retorna o índice baseado em zero do elemento.

// BinarySearch(T, IComparer<T>)	
// Pesquisa um elemento em todo o List<T> classificado usando o comparador especificado e retorna o índice baseado em zero do elemento.

// Clear()	
// Remove todos os elementos do List<T>.

// Contains(T)	
// Determina se um elemento está no List<T>.

// ConvertAll<TOutput>(Converter<T,TOutput>)	
// Converte os elementos no List<T> atual para outro tipo e retorna uma lista contendo os elementos convertidos.

// CopyTo(Int32, T[], Int32, Int32)	
// Copia um intervalo de elementos do List<T> para uma matriz unidimensional compatível, começando pelo índice especificado da matriz de destino.

// CopyTo(T[])	
// Copia todo o List<T> em uma matriz unidimensional compatível, a partir do início da matriz de destino.

// CopyTo(T[], Int32)	
// Copia todo o List<T> para uma matriz unidimensional compatível, iniciando no índice especificado da matriz de destino.

// EnsureCapacity(Int32)	
// Garante que a capacidade dessa lista seja pelo menos a especificada capacity. Se a capacidade atual for menor que capacity, ela será sucessivamente aumentada para o dobro da capacidade atual até que seja pelo menos a especificada capacity.

// Equals(Object)	
// Determina se o objeto especificado é igual ao objeto atual.

// (Herdado de Object)
// Exists(Predicate<T>)	
// Determina se o List<T> contém elementos que correspondem às condições definidas pelo predicado especificado.

// Find(Predicate<T>)	
// Pesquisa um elemento que corresponde às condições definidas pelo predicado especificado e retorna a primeira ocorrência em toda a List<T>.

// FindAll(Predicate<T>)	
// Recupera todos os elementos que correspondem às condições definidas pelo predicado especificado.

// FindIndex(Int32, Int32, Predicate<T>)	
// Pesquisa um elemento que coincida com as condições definidas pelo predicado especificado e retorna o índice baseado em zero da primeira ocorrência dentro do intervalo de elementos na List<T> que começa no índice especificado e contém o número de elementos especificado.

// FindIndex(Int32, Predicate<T>)	
// Pesquisa um elemento que corresponda às condições definidas pelo predicado especificado e retorna o índice baseado em zero da primeira ocorrência dentro do intervalo de elementos no List<T> que se estende do índice especificado ao último elemento.

// FindIndex(Predicate<T>)	
// Pesquisa um elemento que corresponde às condições definidas pelo predicado especificado e retorna o índice baseado em zero da primeira ocorrência em toda a List<T>.

// FindLast(Predicate<T>)	
// Pesquisa um elemento que corresponda às condições definidas pelo predicado especificado e retorna a primeira ocorrência em toda a List<T>.

// FindLastIndex(Int32, Int32, Predicate<T>)	
// Pesquisa por um elemento que corresponda às condições definidas pelo predicado especificado e retorna o índice baseado em zero da última ocorrência no intervalo de elementos no List<T> que contém o número de elementos especificado e termina no índice especificado.

// FindLastIndex(Int32, Predicate<T>)	
// Pesquisa um elemento que corresponde às condições definidas pelo predicado especificado e retorna o índice baseado em zero da última ocorrência dentro do intervalo de elementos no List<T> que se estende do primeiro elemento ao índice especificado.

// FindLastIndex(Predicate<T>)	
// Pesquisa um elemento que corresponde às condições definidas pelo predicado especificado e retorna o índice baseado em zero da última ocorrência em toda a List<T>.

// ForEach(Action<T>)	
// Executa a ação especificada em cada elemento do List<T>.

// GetEnumerator()	
// Retorna um enumerador que itera por meio de List<T>.

// GetHashCode()	
// Serve como a função de hash padrão.

// (Herdado de Object)
// GetRange(Int32, Int32)	
// Cria uma cópia superficial de um intervalo de elementos no List<T> de origem.

// GetType()	
// Obtém o Type da instância atual.

// (Herdado de Object)
// IndexOf(T)	
// Pesquisa o objeto especificado e retorna o índice baseado em zero da primeira ocorrência dentro de todo o List<T>.

// IndexOf(T, Int32)	
// Procura o objeto especificado e retorna o índice baseado em zero da primeira ocorrência dentro do intervalo de elementos em List<T> que se estende do índice especificado para o último elemento.

// IndexOf(T, Int32, Int32)	
// Pesquisa o objeto especificado e retorna o índice baseado em zero da primeira ocorrência em um intervalo de elementos no List<T> que começa no índice especificado e contém o número de elementos especificado.

// Insert(Int32, T)	
// Insere um elemento no List<T>, no índice especificado.

// InsertRange(Int32, IEnumerable<T>)	
// Insere os elementos de uma coleção no List<T> no índice especificado.

// LastIndexOf(T)	
// Pesquisa o objeto especificado e retorna o índice baseado em zero da última ocorrência dentro de todo o List<T>.

// LastIndexOf(T, Int32)	
// Procura o objeto especificado e retorna o índice baseado em zero da última ocorrência dentro do intervalo de elementos em List<T> que se estende do primeiro elemento ao índice especificado.

// LastIndexOf(T, Int32, Int32)	
// Pesquisa o objeto especificado e retorna o índice baseado em zero da última ocorrência no intervalo de elementos na List<T> que contém o número de elementos especificado e termina no índice especificado.

// MemberwiseClone()	
// Cria uma cópia superficial do Object atual.

// (Herdado de Object)
// Remove(T)	
// Remove a primeira ocorrência de um objeto específico do List<T>.

// RemoveAll(Predicate<T>)	
// Remove todos os elementos que correspondem às condições definidas pelo predicado especificado.

// RemoveAt(Int32)	
// Remove o elemento no índice especificado do List<T>.

// RemoveRange(Int32, Int32)	
// Remove um intervalo de elementos do List<T>.

// Reverse()	
// Inverte a ordem dos elementos em todo o List<T>.

// Reverse(Int32, Int32)	
// Inverte a ordem dos elementos no intervalo especificado.

// Sort()	
// Classifica os elementos em todo o List<T> usando o comparador padrão.

// Sort(Comparison<T>)	
// Classifica os elementos em todo o List<T> usando o Comparison<T> especificado.

// Sort(IComparer<T>)	
// Classifica os elementos em todo o List<T> usando o comparador especificado.

// Sort(Int32, Int32, IComparer<T>)	
// Classifica os elementos em um intervalo de elementos em List<T> usando o comparador especificado.

// ToArray()	
// Copia os elementos do List<T> em uma nova matriz.

// ToString()	
// Retorna uma cadeia de caracteres que representa o objeto atual.

// (Herdado de Object)
// TrimExcess()	
// Define a capacidade para o número real de elementos de List<T>, se esse número for menor que um valor limite.

// TrueForAll(Predicate<T>)	
// Determina se cada elemento do List<T> corresponde às condições definidas pelo predicado especificado.

// Implantações explícitas de interface
// ICollection.CopyTo(Array, Int32)	
// Copia os elementos do ICollection para um Array, começando em um determinado índice Array.

// ICollection.IsSynchronized	
// Obtém um valor que indica se o acesso à ICollection é sincronizado (thread-safe).

// ICollection.SyncRoot	
// Obtém um objeto que pode ser usado para sincronizar o acesso ao ICollection.

// ICollection<T>.IsReadOnly	
// Obtém um valor que indica se o ICollection<T> é somente leitura.

// IEnumerable.GetEnumerator()	
// Retorna um enumerador que itera em uma coleção.

// IEnumerable<T>.GetEnumerator()	
// Retorna um enumerador que itera em uma coleção.

// IList.Add(Object)	
// Adiciona um item ao IList.

// IList.Contains(Object)	
// Determinará se o IList contiver um valor específico.

// IList.IndexOf(Object)	
// Determina o índice de um item específico em IList.

// IList.Insert(Int32, Object)	
// Insere um item na IList no índice especificado.

// IList.IsFixedSize	
// Obtém um valor que indica se o IList tem um tamanho fixo.

// IList.IsReadOnly	
// Obtém um valor que indica se o IList é somente leitura.

// IList.Item[Int32]	
// Obtém ou define o elemento no índice especificado.

// IList.Remove(Object)	
// Remove a primeira ocorrência de um objeto específico do IList.

// Métodos de Extensão
// AsReadOnly<T>(IList<T>)	
// Retorna um wrapper somente ReadOnlyCollection<T> leitura para a lista especificada.

// ToImmutableArray<TSource>(IEnumerable<TSource>)	
// Cria uma matriz imutável com base na coleção especificada.

// ToImmutableDictionary<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Constrói um dicionário imutável de uma coleção existente de elementos, aplicando uma função de transformação nas chaves de origem.

// ToImmutableDictionary<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Constrói um dicionário imutável com base em alguma transformação de uma sequência.

// ToImmutableDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>)	
// Enumera e transforma uma sequência e produz um dicionário imutável com base em seu conteúdo.

// ToImmutableDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>, IEqualityComparer<TKey>)	
// Enumera e transforma uma sequência e produz um dicionário imutável com base em seu conteúdo usando o comparador de chave especificado.

// ToImmutableDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>, IEqualityComparer<TKey>, IEqualityComparer<TValue>)	
// Enumera e transforma uma sequência e produz um dicionário imutável com base em seu conteúdo usando os comparadores de chave e valor especificados.

// ToImmutableHashSet<TSource>(IEnumerable<TSource>)	
// Enumera uma sequência e produz um conjunto de hash imutável de seu conteúdo.

// ToImmutableHashSet<TSource>(IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Enumera uma sequência, produz um conjunto de hash imutável de seu conteúdo e usa o comparador de igualdade especificado para o tipo de conjunto.

// ToImmutableList<TSource>(IEnumerable<TSource>)	
// Enumera uma sequência e produz uma lista imutável de seu conteúdo.

// ToImmutableSortedDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>)	
// Enumera e transforma uma sequência e produz um dicionário classificado imutável com base em seu conteúdo.

// ToImmutableSortedDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>, IComparer<TKey>)	
// Enumera e transforma uma sequência e produz um dicionário classificado imutável com base em seu conteúdo usando o comparador de chave especificado.

// ToImmutableSortedDictionary<TSource,TKey,TValue>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TValue>, IComparer<TKey>, IEqualityComparer<TValue>)	
// Enumera e transforma uma sequência e produz um dicionário classificado imutável com base em seu conteúdo usando os comparadores de chave e valor especificados.

// ToImmutableSortedSet<TSource>(IEnumerable<TSource>)	
// Enumera uma sequência e produz um conjunto classificado imutável de seu conteúdo.

// ToImmutableSortedSet<TSource>(IEnumerable<TSource>, IComparer<TSource>)	
// Enumera uma sequência, produz um conjunto classificado imutável de seu conteúdo e usa o comparador especificado.

// CopyToDataTable<T>(IEnumerable<T>)	
// Retorna um DataTable que contém cópias dos objetos DataRow, dado um objeto IEnumerable<T> de entrada em que o parâmetro genérico T é DataRow.

// CopyToDataTable<T>(IEnumerable<T>, DataTable, LoadOption)	
// Copia objetos DataRow no DataTable especificado, dado um objeto IEnumerable<T> de entrada em que o parâmetro genérico T é DataRow.

// CopyToDataTable<T>(IEnumerable<T>, DataTable, LoadOption, FillErrorEventHandler)	
// Copia objetos DataRow no DataTable especificado, dado um objeto IEnumerable<T> de entrada em que o parâmetro genérico T é DataRow.

// Aggregate<TSource>(IEnumerable<TSource>, Func<TSource,TSource,TSource>)	
// Aplica uma função de acumulador a uma sequência.

// Aggregate<TSource,TAccumulate>(IEnumerable<TSource>, TAccumulate, Func<TAccumulate,TSource,TAccumulate>)	
// Aplica uma função de acumulador a uma sequência. O valor de semente especificado é usado como o valor inicial do acumulador.

// Aggregate<TSource,TAccumulate,TResult>(IEnumerable<TSource>, TAccumulate, Func<TAccumulate,TSource,TAccumulate>, Func<TAccumulate,TResult>)	
// Aplica uma função de acumulador a uma sequência. O valor de semente especificado é usado como o valor inicial do acumulador e a função especificada é usada para selecionar o valor do resultado.

// All<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Determina se todos os elementos de uma sequência atendem a uma condição.

// Any<TSource>(IEnumerable<TSource>)	
// Determina se uma sequência contém elementos.

// Any<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Determina se algum elemento de uma sequência atende a uma condição.

// Append<TSource>(IEnumerable<TSource>, TSource)	
// Acrescenta um valor ao final da sequência.

// AsEnumerable<TSource>(IEnumerable<TSource>)	
// Retorna a entrada digitada como IEnumerable<T>.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Decimal>)	
// Calcula a média de uma sequência de valores Decimal obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Double>)	
// Calcula a média de uma sequência de valores Double obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Int32>)	
// Calcula a média de uma sequência de valores Int32 obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Int64>)	
// Calcula a média de uma sequência de valores Int64 obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Decimal>>)	
// Calcula a média de uma sequência de valores Decimal que permitem valor nulo obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Double>>)	
// Calcula a média de uma sequência de valores Double que permitem valor nulo obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int32>>)	
// Calcula a média de uma sequência de valores Int32 que permitem valor nulo obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int64>>)	
// Calcula a média de uma sequência de valores Int64 que permitem valor nulo obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Single>>)	
// Calcula a média de uma sequência de valores Single que permitem valor nulo obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Average<TSource>(IEnumerable<TSource>, Func<TSource,Single>)	
// Calcula a média de uma sequência de valores Single obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Cast<TResult>(IEnumerable)	
// Converte os elementos de um IEnumerable para o tipo especificado.

// Chunk<TSource>(IEnumerable<TSource>, Int32)	
// Divide no máximo sizeos elementos de uma sequência em partes de tamanho.

// Concat<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)	
// Concatena duas sequências.

// Contains<TSource>(IEnumerable<TSource>, TSource)	
// Determina se uma sequência contém um elemento especificado usando o comparador de igualdade padrão.

// Contains<TSource>(IEnumerable<TSource>, TSource, IEqualityComparer<TSource>)	
// Determina se uma sequência contém um elemento especificado usando um IEqualityComparer<T> especificado.

// Count<TSource>(IEnumerable<TSource>)	
// Retorna o número de elementos em uma sequência.

// Count<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna um número que representa quantos elementos na sequência especificada atendem a uma condição.

// DefaultIfEmpty<TSource>(IEnumerable<TSource>)	
// Retornará os elementos da sequência especificada ou o valor padrão do parâmetro de tipo em uma coleção de singletons se a sequência estiver vazia.

// DefaultIfEmpty<TSource>(IEnumerable<TSource>, TSource)	
// Retorna os elementos da sequência especificada ou o valor especificado em uma coleção de singletons se a sequência está vazia.

// Distinct<TSource>(IEnumerable<TSource>)	
// Retorna os elementos distintos de uma sequência usando o comparador de igualdade padrão para comparar valores.

// Distinct<TSource>(IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Retorna os elementos distintos de uma sequência usando um IEqualityComparer<T> especificado para comparar valores.

// DistinctBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Retorna elementos distintos de uma sequência de acordo com uma função de seletor de chave especificada.

// DistinctBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Retorna elementos distintos de uma sequência de acordo com uma função de seletor de chave especificada e usando um comparador especificado para comparar chaves.

// ElementAt<TSource>(IEnumerable<TSource>, Index)	
// Retorna o elemento de um índice especificado em uma sequência.

// ElementAt<TSource>(IEnumerable<TSource>, Int32)	
// Retorna o elemento de um índice especificado em uma sequência.

// ElementAtOrDefault<TSource>(IEnumerable<TSource>, Index)	
// Retorna o elemento em um índice especificado em uma sequência ou um valor padrão se o índice estiver fora do intervalo.

// ElementAtOrDefault<TSource>(IEnumerable<TSource>, Int32)	
// Retorna o elemento em um índice especificado em uma sequência ou um valor padrão se o índice estiver fora do intervalo.

// Except<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)	
// Produz a diferença de conjunto de duas sequências usando o comparador de igualdade padrão para comparar os valores.

// Except<TSource>(IEnumerable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Produz a diferença de conjunto de duas sequências usando o IEqualityComparer<T> especificado para comparar os valores.

// ExceptBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TKey>, Func<TSource,TKey>)	
// Produz a diferença de conjunto de duas sequências de acordo com uma função de seletor de chave especificada.

// ExceptBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TKey>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Produz a diferença de conjunto de duas sequências de acordo com uma função de seletor de chave especificada.

// First<TSource>(IEnumerable<TSource>)	
// Retorna o primeiro elemento de uma sequência.

// First<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o primeiro elemento em uma sequência que satisfaz uma condição especificada.

// FirstOrDefault<TSource>(IEnumerable<TSource>)	
// Retorna o primeiro elemento de uma sequência ou um valor padrão se a sequência não contém elementos.

// FirstOrDefault<TSource>(IEnumerable<TSource>, TSource)	
// Retorna o primeiro elemento de uma sequência ou um valor padrão especificado se a sequência não contiver elementos.

// FirstOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o primeiro elemento da sequência que satisfaz uma condição ou um valor padrão, caso esse elemento não seja encontrado.

// FirstOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)	
// Retorna o primeiro elemento da sequência que atende a uma condição ou um valor padrão especificado se nenhum elemento desse tipo for encontrado.

// GroupBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Agrupa os elementos de uma sequência de acordo com uma função de seletor de chave especificada.

// GroupBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Agrupa os elementos de uma sequência de acordo com uma função do seletor de chave especificada e compara as chaves usando um comparador especificado.

// GroupBy<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>)	
// Agrupa os elementos de uma sequência de acordo com a função de seletor de chave especificada e projeta os elementos de cada grupo usando uma função especificada.

// GroupBy<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>, IEqualityComparer<TKey>)	
// Agrupa os elementos de uma sequência de acordo com uma função de seletor de chave. As chaves são comparadas usando um comparador e os elementos de cada grupo são projetados usando uma função especificada.

// GroupBy<TSource,TKey,TResult>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TKey,IEnumerable<TSource>,TResult>)	
// Agrupa os elementos de uma sequência de acordo com uma função do seletor de chave especificada e cria um valor de resultado de cada grupo e sua chave.

// GroupBy<TSource,TKey,TResult>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TKey,IEnumerable<TSource>,TResult>, IEqualityComparer<TKey>)	
// Agrupa os elementos de uma sequência de acordo com uma função do seletor de chave especificada e cria um valor de resultado de cada grupo e sua chave. As chaves são comparadas usando um comparador especificado.

// GroupBy<TSource,TKey,TElement,TResult>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>, Func<TKey,IEnumerable<TElement>,TResult>)	
// Agrupa os elementos de uma sequência de acordo com uma função do seletor de chave especificada e cria um valor de resultado de cada grupo e sua chave. Os elementos de cada grupo são projetados usando uma função especificada.

// GroupBy<TSource,TKey,TElement,TResult>(IEnumerable<TSource>, Func<TSource, TKey>, Func<TSource,TElement>, Func<TKey,IEnumerable<TElement>, TResult>, IEqualityComparer<TKey>)	
// Agrupa os elementos de uma sequência de acordo com uma função do seletor de chave especificada e cria um valor de resultado de cada grupo e sua chave. Os valores da chave são comparados usando um comparador especificado e os elementos de cada grupo são projetados usando uma função especificada.

// GroupJoin<TOuter,TInner,TKey,TResult>(IEnumerable<TOuter>, IEnumerable<TInner>, Func<TOuter,TKey>, Func<TInner,TKey>, Func<TOuter,IEnumerable<TInner>, TResult>)	
// Correlaciona os elementos de duas sequências com base na igualdade de chaves e agrupa os resultados. O comparador de igualdade padrão é usado para comparar chaves.

// GroupJoin<TOuter,TInner,TKey,TResult>(IEnumerable<TOuter>, IEnumerable<TInner>, Func<TOuter,TKey>, Func<TInner,TKey>, Func<TOuter,IEnumerable<TInner>, TResult>, IEqualityComparer<TKey>)	
// Correlaciona os elementos de duas sequências com base na igualdade de chaves e agrupa os resultados. Um IEqualityComparer<T> especificado é usado para comparar chaves.

// Intersect<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)	
// Produz a interseção de conjunto de duas sequências usando o comparador de igualdade padrão para comparar os valores.

// Intersect<TSource>(IEnumerable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Produz a interseção de conjunto de duas sequências usando o IEqualityComparer<T> especificado para comparar os valores.

// IntersectBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TKey>, Func<TSource,TKey>)	
// Produz a interseção de conjunto de duas sequências de acordo com uma função de seletor de chave especificada.

// IntersectBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TKey>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Produz a interseção de conjunto de duas sequências de acordo com uma função de seletor de chave especificada.

// Join<TOuter,TInner,TKey,TResult>(IEnumerable<TOuter>, IEnumerable<TInner>, Func<TOuter,TKey>, Func<TInner,TKey>, Func<TOuter,TInner,TResult>)	
// Correlaciona os elementos de duas sequências com base em chaves de correspondência. O comparador de igualdade padrão é usado para comparar chaves.

// Join<TOuter,TInner,TKey,TResult>(IEnumerable<TOuter>, IEnumerable<TInner>, Func<TOuter,TKey>, Func<TInner,TKey>, Func<TOuter,TInner,TResult>, IEqualityComparer<TKey>)	
// Correlaciona os elementos de duas sequências com base em chaves de correspondência. Um IEqualityComparer<T> especificado é usado para comparar chaves.

// Last<TSource>(IEnumerable<TSource>)	
// Retorna o último elemento de uma sequência.

// Last<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o último elemento de uma sequência que satisfaz uma condição especificada.

// LastOrDefault<TSource>(IEnumerable<TSource>)	
// Retorna o último elemento de uma sequência ou um valor padrão se a sequência não contém elementos.

// LastOrDefault<TSource>(IEnumerable<TSource>, TSource)	
// Retorna o último elemento de uma sequência ou um valor padrão especificado se a sequência não contiver elementos.

// LastOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o último elemento de uma sequência que satisfaz uma condição ou um valor padrão, caso esse elemento não seja encontrado.

// LastOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)	
// Retorna o último elemento de uma sequência que satisfaz uma condição ou um valor padrão especificado se nenhum elemento desse tipo for encontrado.

// LongCount<TSource>(IEnumerable<TSource>)	
// Retorna um Int64 que representa o número total de elementos em uma sequência.

// LongCount<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna um Int64 que representa quantos elementos na sequência atendem a uma condição.

// Max<TSource>(IEnumerable<TSource>)	
// Retorna o valor máximo em uma sequência genérica.

// Max<TSource>(IEnumerable<TSource>, IComparer<TSource>)	
// Retorna o valor máximo em uma sequência genérica.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Decimal>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Decimal máximo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Double>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Double máximo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Int32>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int32 máximo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Int64>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int64 máximo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Decimal>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Decimal máximo que permite valor nulo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Double>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Double máximo que permite valor nulo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int32>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int32 máximo que permite valor nulo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int64>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int64 máximo que permite valor nulo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Single>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Single máximo que permite valor nulo.

// Max<TSource>(IEnumerable<TSource>, Func<TSource,Single>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Single máximo.

// Max<TSource,TResult>(IEnumerable<TSource>, Func<TSource,TResult>)	
// Invoca uma função de transformação em cada elemento de uma sequência genérica e retorna o maior valor resultante.

// MaxBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Retorna o valor máximo em uma sequência genérica de acordo com uma função de seletor de chave especificada.

// MaxBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IComparer<TKey>)	
// Retorna o valor máximo em uma sequência genérica de acordo com uma função de seletor de chave especificada e um comparador de chave.

// Min<TSource>(IEnumerable<TSource>)	
// Retorna o valor mínimo em uma sequência genérica.

// Min<TSource>(IEnumerable<TSource>, IComparer<TSource>)	
// Retorna o valor mínimo em uma sequência genérica.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Decimal>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Decimal mínimo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Double>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Double mínimo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Int32>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int32 mínimo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Int64>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int64 mínimo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Decimal>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Decimal mínimo que permite valor nulo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Double>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Double mínimo que permite valor nulo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int32>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int32 mínimo que permite valor nulo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int64>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Int64 mínimo que permite valor nulo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Single>>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Single mínimo que permite valor nulo.

// Min<TSource>(IEnumerable<TSource>, Func<TSource,Single>)	
// Invoca uma função de transformação em cada elemento de uma sequência e retorna o valor Single mínimo.

// Min<TSource,TResult>(IEnumerable<TSource>, Func<TSource,TResult>)	
// Invoca uma função de transformação em cada elemento de uma sequência genérica e retorna o menor valor resultante.

// MinBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Retorna o valor mínimo em uma sequência genérica de acordo com uma função de seletor de chave especificada.

// MinBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IComparer<TKey>)	
// Retorna o valor mínimo em uma sequência genérica de acordo com uma função de seletor de chave especificada e um comparador de chave.

// OfType<TResult>(IEnumerable)	
// Filtra os elementos de um IEnumerable com base em um tipo especificado.

// OrderBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Classifica os elementos de uma sequência em ordem crescente de acordo com uma chave.

// OrderBy<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IComparer<TKey>)	
// Classifica os elementos de uma sequência em ordem crescente usando um comparador especificado.

// OrderByDescending<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Classifica os elementos de uma sequência em ordem decrescente de acordo com uma chave.

// OrderByDescending<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IComparer<TKey>)	
// Classifica os elementos de uma sequência em ordem decrescente usando um comparador especificado.

// Prepend<TSource>(IEnumerable<TSource>, TSource)	
// Adiciona um valor ao início da sequência.

// Reverse<TSource>(IEnumerable<TSource>)	
// Inverte a ordem dos elementos em uma sequência.

// Select<TSource,TResult>(IEnumerable<TSource>, Func<TSource,TResult>)	
// Projeta cada elemento de uma sequência em um novo formulário.

// Select<TSource,TResult>(IEnumerable<TSource>, Func<TSource,Int32,TResult>)	
// Projeta cada elemento de uma sequência em um novo formulário, incorporando o índice do elemento.

// SelectMany<TSource,TResult>(IEnumerable<TSource>, Func<TSource,IEnumerable<TResult>>)	
// Projeta cada elemento de uma sequência em um IEnumerable<T> e nivela as sequências resultantes em uma sequência.

// SelectMany<TSource,TResult>(IEnumerable<TSource>, Func<TSource,Int32,IEnumerable<TResult>>)	
// Projeta cada elemento de uma sequência em um IEnumerable<T> e nivela as sequências resultantes em uma sequência. O índice de cada elemento de origem é usado no formulário projetado desse elemento.

// SelectMany<TSource,TCollection,TResult>(IEnumerable<TSource>, Func<TSource,IEnumerable<TCollection>>, Func<TSource,TCollection,TResult>)	
// Projeta cada elemento de uma sequência em um IEnumerable<T>, mescla as sequências resultantes em uma sequência e chama uma função de seletor de resultado em cada elemento contido nele.

// SelectMany<TSource,TCollection,TResult>(IEnumerable<TSource>, Func<TSource,Int32,IEnumerable<TCollection>>, Func<TSource,TCollection,TResult>)	
// Projeta cada elemento de uma sequência em um IEnumerable<T>, mescla as sequências resultantes em uma sequência e chama uma função de seletor de resultado em cada elemento contido nele. O índice de cada elemento de origem é usado no formulário projetado intermediário do elemento.

// SequenceEqual<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)	
// Determina se duas sequências são iguais comparando os elementos usando o comparador de igualdade padrão para o tipo.

// SequenceEqual<TSource>(IEnumerable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Determina se duas sequências são iguais, comparando seus elementos usando um IEqualityComparer<T> especificado.

// Single<TSource>(IEnumerable<TSource>)	
// Retornará o único elemento de uma sequência e lançará uma exceção se não houver exatamente um elemento na sequência.

// Single<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o único elemento de uma sequência que satisfaz uma condição especificada e gera uma exceção se houver mais de um tal elemento.

// SingleOrDefault<TSource>(IEnumerable<TSource>)	
// Retorna o único elemento de uma sequência ou um valor padrão se a sequência é vazia; esse método gera uma exceção se há mais de um elemento na sequência.

// SingleOrDefault<TSource>(IEnumerable<TSource>, TSource)	
// Retorna o único elemento de uma sequência ou um valor padrão especificado se a sequência estiver vazia; esse método gerará uma exceção se houver mais de um elemento na sequência.

// SingleOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna o único elemento de uma sequência que satisfaz uma condição especificada ou um valor padrão se esse elemento não existir. Esse método lança uma exceção se mais de um elemento satisfizer a condição.

// SingleOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)	
// Retorna o único elemento de uma sequência que satisfaz uma condição especificada ou um valor padrão especificado se nenhum elemento desse tipo existir; esse método gerará uma exceção se mais de um elemento atender à condição.

// Skip<TSource>(IEnumerable<TSource>, Int32)	
// Ignora um número especificado de elementos em uma sequência e retorna os elementos restantes.

// SkipLast<TSource>(IEnumerable<TSource>, Int32)	
// Retorna uma nova coleção enumerável que contém os elementos de source com os últimos elementos de count da coleção de origem omitidos.

// SkipWhile<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Ignora elementos em uma sequência, contanto que uma condição especificada seja verdadeira e retorne os elementos restantes.

// SkipWhile<TSource>(IEnumerable<TSource>, Func<TSource,Int32,Boolean>)	
// Ignora elementos em uma sequência, contanto que uma condição especificada seja verdadeira e retorne os elementos restantes. O índice do elemento é usado na lógica da função de predicado.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Decimal>)	
// Calcula a soma da sequência de valores Decimal obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Double>)	
// Calcula a soma da sequência de valores Double obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Int32>)	
// Calcula a soma da sequência de valores Int32 obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Int64>)	
// Calcula a soma da sequência de valores Int64 obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Decimal>>)	
// Calcula a soma da sequência de valores Decimal anuláveis obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Double>>)	
// Calcula a soma da sequência de valores Double anuláveis obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int32>>)	
// Calcula a soma da sequência de valores Int32 anuláveis obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Int64>>)	
// Calcula a soma da sequência de valores Int64 anuláveis obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Nullable<Single>>)	
// Calcula a soma da sequência de valores Single anuláveis obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Sum<TSource>(IEnumerable<TSource>, Func<TSource,Single>)	
// Calcula a soma da sequência de valores Single obtidos pela invocação de uma função de transformação em cada elemento da sequência de entrada.

// Take<TSource>(IEnumerable<TSource>, Int32)	
// Retorna um número especificado de elementos contíguos do início de uma sequência.

// Take<TSource>(IEnumerable<TSource>, Range)	
// Retorna um intervalo especificado de elementos contíguos de uma sequência.

// TakeLast<TSource>(IEnumerable<TSource>, Int32)	
// Retorna uma nova coleção enumerável que contém os últimos elementos de count de source.

// TakeWhile<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Retorna os elementos de uma sequência contanto que uma condição especificada seja verdadeira.

// TakeWhile<TSource>(IEnumerable<TSource>, Func<TSource,Int32,Boolean>)	
// Retorna os elementos de uma sequência contanto que uma condição especificada seja verdadeira. O índice do elemento é usado na lógica da função de predicado.

// ToArray<TSource>(IEnumerable<TSource>)	
// Cria uma matriz de um IEnumerable<T>.

// ToDictionary<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Cria um Dictionary<TKey,TValue> de um IEnumerable<T>, de acordo com uma função de seletor de chave especificada.

// ToDictionary<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Cria um Dictionary<TKey,TValue> de um IEnumerable<T>, de acordo com uma função de seletor de chave especificada e um comparador de chaves.

// ToDictionary<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>)	
// Cria um Dictionary<TKey,TValue> de um IEnumerable<T>, de acordo com as funções especificadas de seletor de chave e seletor de elemento.

// ToDictionary<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>, IEqualityComparer<TKey>)	
// Cria um Dictionary<TKey,TValue> de um IEnumerable<T> de acordo com uma função de seletor de chave, um comparador e uma função de seletor de elemento especificados.

// ToHashSet<TSource>(IEnumerable<TSource>)	
// Cria um HashSet<T> de um IEnumerable<T>.

// ToHashSet<TSource>(IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Cria um HashSet<T> de um IEnumerable<T> usando o comparer para comparar chaves.

// ToList<TSource>(IEnumerable<TSource>)	
// Cria um List<T> de um IEnumerable<T>.

// ToLookup<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>)	
// Cria um Lookup<TKey,TElement> de um IEnumerable<T>, de acordo com uma função de seletor de chave especificada.

// ToLookup<TSource,TKey>(IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Cria um Lookup<TKey,TElement> de um IEnumerable<T>, de acordo com uma função de seletor de chave especificada e um comparador de chaves.

// ToLookup<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>)	
// Cria um Lookup<TKey,TElement> de um IEnumerable<T>, de acordo com as funções especificadas de seletor de chave e seletor de elemento.

// ToLookup<TSource,TKey,TElement>(IEnumerable<TSource>, Func<TSource,TKey>, Func<TSource,TElement>, IEqualityComparer<TKey>)	
// Cria um Lookup<TKey,TElement> de um IEnumerable<T> de acordo com uma função de seletor de chave, um comparador e uma função de seletor de elemento especificados.

// TryGetNonEnumeratedCount<TSource>(IEnumerable<TSource>, Int32)	
// Tenta determinar o número de elementos em uma sequência sem forçar uma enumeração.

// Union<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)	
// Produz a união de conjunto de duas sequências usando o comparador de igualdade padrão.

// Union<TSource>(IEnumerable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>)	
// Produz a união de conjunto de duas sequências usando o IEqualityComparer<T> especificado.

// UnionBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TSource>, Func<TSource,TKey>)	
// Produz a união definida de duas sequências de acordo com uma função de seletor de chave especificada.

// UnionBy<TSource,TKey>(IEnumerable<TSource>, IEnumerable<TSource>, Func<TSource,TKey>, IEqualityComparer<TKey>)	
// Produz a união definida de duas sequências de acordo com uma função de seletor de chave especificada.

// Where<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)	
// Filtra uma sequência de valores com base em um predicado.

// Where<TSource>(IEnumerable<TSource>, Func<TSource,Int32,Boolean>)	
// Filtra uma sequência de valores com base em um predicado. O índice de cada elemento é usado na lógica da função de predicado.

// Zip<TFirst,TSecond>(IEnumerable<TFirst>, IEnumerable<TSecond>)	
// Produz uma sequência de tuplas com elementos das duas sequências especificadas.

// Zip<TFirst,TSecond,TThird>(IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>)	
// Produz uma sequência de tuplas com elementos das três sequências especificadas.

// Zip<TFirst,TSecond,TResult>(IEnumerable<TFirst>, IEnumerable<TSecond>, Func<TFirst,TSecond,TResult>)	
// Aplica uma função especificada para os elementos correspondentes de duas sequências, produzindo uma sequência dos resultados.

// AsParallel(IEnumerable)	
// Habilita a paralelização de uma consulta.

// AsParallel<TSource>(IEnumerable<TSource>)	
// Habilita a paralelização de uma consulta.

// AsQueryable(IEnumerable)	
// Converte um IEnumerable em um IQueryable.

// AsQueryable<TElement>(IEnumerable<TElement>)	
// Converte um IEnumerable<T> genérico em um IQueryable<T> genérico.

// Ancestors<T>(IEnumerable<T>)	
// Retorna uma coleção de elementos que contém os ancestrais de cada nó na coleção de origem.

// Ancestors<T>(IEnumerable<T>, XName)	
// Retorna uma coleção filtrada de elementos que contém os ancestrais de cada nó na coleção de origem. Somente os elementos que têm um XName correspondente são incluídos na coleção.

// DescendantNodes<T>(IEnumerable<T>)	
// Retorna uma coleção dos nós descendentes de todos os documentos e elementos na coleção de origem.

// Descendants<T>(IEnumerable<T>)	
// Retorna uma coleção de elementos que contém os elementos descendentes de cada elemento e o documento na coleção de origem.

// Descendants<T>(IEnumerable<T>, XName)	
// Retorna uma coleção filtrada de elementos que contém os elementos descendentes de cada elemento e o documento na coleção de origem. Somente os elementos que têm um XName correspondente são incluídos na coleção.

// Elements<T>(IEnumerable<T>)	
// Retorna uma coleção dos filhos elementos de cada elemento e o documento na coleção de origem.

// Elements<T>(IEnumerable<T>, XName)	
// Retorna uma coleção filtrada dos elementos filho de cada elemento e documento na coleção de origem. Somente os elementos que têm um XName correspondente são incluídos na coleção.

// InDocumentOrder<T>(IEnumerable<T>)	
// Retorna uma coleção de nós que contém todos os nós na coleção de origem, classificados em ordem segundo o documento.

// Nodes<T>(IEnumerable<T>)	
// Retorna uma coleção dos nós filhos de todos os documentos e elementos na coleção de origem.

// Remove<T>(IEnumerable<T>)	
// Remove todos os nós na coleção de origem do respectivo nó pai.