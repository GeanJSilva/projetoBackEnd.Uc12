using ProjetoBackEnd.Classes;

String? opcao;
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();


//***********AQUI COMEÇA A TELA DE MENU **********************************************

//***********BARRA DE CARREGAMENTO*********************************

    //puxado da class Utils
    Utlils.barraCarregamento("Carregando");
    Console.Clear();


//************TELA DE BOAS VINDAS**********************************
    
Console.WriteLine(@$"

                -------------------------------------------
                |    Bem vindo ao Sistema de Cadastro!    |
                -------------------------------------------
  
");
    Thread.Sleep(1500);
    Console.Clear();


//*************TELA DE OPCAO PF OU PJ******************************

//roda o codigo enquanto a condicao for vdd

do
{
    Console.Clear();
    Console.WriteLine(@$"

                --------------------------------------------
                |  Digite uma opcao abaixo e aperte Enter  |
                --------------------------------------------
                |                                          |
                |           1- PESSOA FÍSICA               |
                |           2-  PESSOA JURIDICA            |
                |                                          |
                |           0- SAIR                        |
                --------------------------------------------

    ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
                novaPf.Nome = "Gean";
                novaPf.cpf ="123456789";
                novaPf.rendimentos = 5000;
                novaPf.DataNasc = new DateTime(2010, 01, 01);
                novoEndPf.logradouro = "Rua D";
                novoEndPf.numero = 100;                 
                novoEndPf.cep = 57000000;
                novoEndPf.complemento = "Curso Senai";
                novoEndPf.endComercial = true;
                novaPf.Endereco = novoEndPf;
            
            //Aula Imposto pessoa fisica:
                float ImpostoPagarPF = novaPf.CalcularImposto(novaPf.rendimentos);
                Console.WriteLine(ImpostoPagarPF.ToString("C"));

            //Interpolacao $:
                Console.WriteLine(@$"
                Nome: {novaPf.Nome}
                Endereço: {novoEndPf.logradouro }, NUm: {novoEndPf.numero}
                Maior de Idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}        
                ");
         
            Console.WriteLine($"Pressione Enter para continuar");
            Console.ReadLine();            
            break;
        
        case "2":
                novaPJ.Nome = "VelhaAnglo";
                novaPJ.rendimentos = 8000;
                novaPJ.cnpj = "59184301000115";
                novaPJ.Endereco = novoEndPJ;
                novoEndPJ.logradouro = "Rua D";
                novoEndPJ.numero = 100;
                novoEndPJ.cep = 57000000;
                novoEndPJ.complemento = "Curso Senai";
                novoEndPJ.endComercial = true;

            // Aula Calcular impostos pessoa juridica:
                float ImpostoPagarPJ = novaPJ.CalcularImposto(novaPJ.rendimentos);
                Console.WriteLine(ImpostoPagarPJ);

                //Interpolacao $:
                Console.WriteLine(@$"
                Nome: {novaPJ.Nome} 
                Endereço: {novoEndPJ.logradouro}, Num: {novoEndPJ.numero}
                CNPJ: {novaPJ.cnpj} - Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
                ");

            Console.WriteLine($"Pressione Enter para continuar");
            Console.ReadLine();
            break;
        
        case "0":
            //Sai do menu
            Utlils.barraCarregamento("Finalizando");
            Console.Clear();               
            break;        
        
        default:
            Console.WriteLine($"Erro");
            Thread.Sleep(1500);
            break;
    }
    
} while (opcao != "0");


//******************FIM DO MENU DO USUARIO*********************************************