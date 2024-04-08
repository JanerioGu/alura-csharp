

using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;


void TestaBuscarPalavra (){
    string [] palavras= new string[5];
    for(int i =0; i < palavras.Length; i++){
        System.Console.WriteLine($"Nome insirido no array {i + 1}");
        palavras[i]= Console.ReadLine();
    }

    System.Console.WriteLine($"Digite palavra a ser encontrada : ");
    var busca = Console.ReadLine(); //adicionando a  palavra a ser encontra na variavel BUSCA
    
    foreach(string palavra in palavras){  //Agora queremos buscar a palavra a ser encontrada na varivel PALAVRAS em que armazenamos o array que insirimos as palavras. Criamos uma outra variavel "palavra" onde compararemos com o a variavel "BUSCA" para verificarmos se os nomes sao iguais.
        if(palavra.Equals(busca)){
            System.Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
        else{
            Console.Write("Palavra nao econtrada");
            break;
        }

    }
}

void TestArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 60;
    idades[3] = 17;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do array {idades.Length}");

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice[{i}] = {idades[i]}");
    }
}

void TestaMediana(Array array){
    if  ((array == null) || (array.Length == 0)){
        System.Console.WriteLine("Array para calculo da mediana esta vazio ou nulo");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho/2;
    double mediana = (tamanho % 2!=0)?numerosOrdenados[meio]: //Linha interessante. Ela pergunta se o resto da divisao de "tamanho" for diferente de 0, será aplicado o que esta depois da "?" por outro lado, se for igual a 0 (caracterizando como numero par), será aplicado o que está depois do " : ". é BOOLEANO ou pode ser discrito também como um if e else. 
                                        (numerosOrdenados[meio] + numerosOrdenados[meio - 1])/ 2;
    System.Console.WriteLine($"Com base na amostra a mediana = {mediana}");

/*Array amostra = new double [5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);*/
}

double[] numeros = new double [3];
numeros.SetValue(6, 0);
numeros.SetValue(7, 1);
numeros.SetValue(8, 2);

void Exercicio(double[] array1){
    if((array1 == null) || (array1.Length == 0)){
        System.Console.WriteLine("Nao ha valores para calcularmos");
        return;
    }

double [] somaNumeros= (double[])array1.Clone();

double valorTotal = 0;

for(int i = 0; i < somaNumeros.Length; i++){
    valorTotal += somaNumeros[i];
}

double mediaValores = valorTotal / somaNumeros.Length;

System.Console.WriteLine("A media dos valores eh igual: " + mediaValores);
}

Exercicio(numeros);