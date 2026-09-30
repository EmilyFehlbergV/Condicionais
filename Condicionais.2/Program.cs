//Crie uma variável chamada "idade" e atribua o valor 18 nela

int idade = 60; // cira uma variável chamada idade e atribui o valor 60 nele
//Crie uma variável chamada "valorIngresso" e atribua o valor 30.00 a ela

double valorIngresso = 30.00; // cira uma variável chamada valorIngresso e atribui o valor 30.00 nele
//Crie uma variável chamada "ehEstudante"

bool ehEstudante = false; //cria uma variável booleana chamada ehEstudante e atribui o valor false nela

bool clienteVIP = true; //cria uma variável booleana chamada clienteVIP e atribui o valor true nela

//Criar um bloco de condição testando se a idade é menor ou igual à 7
// if (idade is <= 7 or >= 60)

if (clienteVIP) //valida se o cliente é vip
{
    valorIngresso = valorIngresso * 0.4; // aplica o desconto caso o cliente for vip
}
else if (idade <= 7 || idade >= 60 || ehEstudante)

    //Crie uma variável chamada "clienteVIP" e atribua um valor que possibilite entender que o usuario é um cliente VIP

// Dentro do bloco de condição, você terá que calcular a metade do valor do ingresso e atribui-lo novamente à variavel "valorIngresso"
{
    valorIngresso = valorIngresso * .5;
}

//valorIngresso *= 0.4;

//Exiba a informação abaixo:
//"O valor do ingresso a pagar é R$ ??"
Console.WriteLine($"O valor do ingresso a pagar é R${valorIngresso}");
 