using System;
using System.Diagnostics;

namespace Pessoa
{
        class Program
    {
        static void Main(string[] args)
        {
            Person[] pessoal = new Person[10];

            var contador = 0;
            var id=0;
            string opcao = Coleta_Opcao();

            while (opcao.ToUpper()!="F")
            {
                switch(opcao)
                {
                    case "1":
                    Console.WriteLine("Informe o Nome da pessoa:");
                    var pessoas = new Person();
                    pessoas.nome = Console.ReadLine(); 

                    Console.WriteLine("Informe a Idade da pessoa:");
                    if (int.TryParse(Console.ReadLine(), out int idade))
                        pessoas.idade = idade;
                    else
                        throw new ArgumentException("Opa Cara, a Idade deve ser um Número");

                    Console.WriteLine("Informe o Apelido da pessoa:");
                    pessoas.apelido = Console.ReadLine(); 

                    id++;                   
                    pessoas.id=id;

                    pessoal[contador] = pessoas;
                    contador++;
                    break;

                    case "2":
                    Nivel nivel_pessoa;
                    if (id<=2)
                        nivel_pessoa=Nivel.Preto;
                    else if (id<=4)
                        nivel_pessoa=Nivel.Vermelho;
                    else if (id<=6)
                        nivel_pessoa=Nivel.Amarelo;
                    else if (id<=8)
                        nivel_pessoa=Nivel.Azul;
                    else
                        nivel_pessoa=Nivel.Branco;
                    foreach (var persona in pessoal)
                    {
                        if(!string.IsNullOrEmpty(persona.nome))
                            Console.WriteLine($"--------\nNome: {persona.nome} \nIdade: {persona.idade} \nApelido: {persona.apelido} \nId: {persona.id} \nNível: {nivel_pessoa} \n--------\n\n");
                        
                        continue;
                    }
 
                    break;

                    case "3":
                    Console.WriteLine("Informe o Id da pessoa que deseja Alterar algo:");
                    int confirma = int.Parse(Console.ReadLine());
                        
                    Console.WriteLine("Informe agora o que voce deseja alterar:");
                    Console.WriteLine("1-Nome\n2-Idade\n3-Apelido\n");
                    var selecionado = Console.ReadLine();

                    var pos_i=0;
                    for (int i=0; i < pessoal.Length; i++)    
                    {
                        if (confirma == pessoal[i].id)
                            pos_i=i;

                    }

                    switch(selecionado)
                    {
                        case "1":
                        Console.WriteLine("Digite o novo nome:");
                        pessoal[pos_i].nome = Console.ReadLine(); 
                        break;

                        case "2":
                        Console.WriteLine("Digite a nova Idade:");
                        
                        if (int.TryParse(Console.ReadLine(), out int novaidade))
                            pessoal[pos_i].idade = novaidade;
                        else
                            throw new ArgumentException("Opa Cara, a Idade deve ser um Número");
                        break;

                        case "3":
                        Console.WriteLine("Digite o novo nome:");
                        pessoal[pos_i].apelido = Console.ReadLine(); 
                        break;
                    }
                    break;

                    case "4":
                    
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = Coleta_Opcao();
            }
        }
           private static string Coleta_Opcao()
        {
            Console.WriteLine("Olá, Bem Vindo ao Código de Controle de Pessoas");
            Console.WriteLine("Para começarmos digite a opção que lhe interesse:");
            Console.WriteLine("1-Cadastrar Pessoa");
            Console.WriteLine("2-Listar Pessoas");
            Console.WriteLine("3-Alterar Informações sobre uma pessoa");
            Console.WriteLine("F-Finalizar");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            return opcao;
        }

    }
}
