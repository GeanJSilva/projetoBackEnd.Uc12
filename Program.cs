using ProjetoBackEnd.Classes;

String? opcao;
String? opcaoPF;
List<PessoaFisica> listaPF = new List<PessoaFisica>();

PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();

//***********AQUI COMEÇA A TELA DE MENU **********************************************

//***********BARRA DE CARREGAMENTO*********************************

// //puxado da class Utils
// Utlils.barraCarregamento("Carregando");
// Console.Clear();


//************TELA DE BOAS VINDAS**********************************
//Interpolacao (@$):
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
                |           2- PESSOA JURIDICA             |
                |                                          |
                |           0- SAIR                        |
                --------------------------------------------

    ");

    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":

            do
            {


                Console.Clear();
                Console.WriteLine(@$"

                --------------------------------------------
                |  Digite uma opcao abaixo e aperte Enter  |
                --------------------------------------------
                |                                          |
                |  1- Cadastrar nova Pessoa Física         |
                |  2- Consultar Pessoa Fisica Cadastrada   |
                |                                          |
                |           0- VOLTAR                      |
                --------------------------------------------
                ");

                opcaoPF = Console.ReadLine();

                switch (opcaoPF)
                {

//Aula gravar informacoes em .txt:--------------------------------------------------------------
//                     case "1":

//                         PessoaFisica novaPf = new PessoaFisica();
//                         Endereco novoEndPf = new Endereco();
//                         novaPf.Endereco = novoEndPf;
//                         Console.Clear();

//                         Console.WriteLine($"Digite o NOME da Pessoa:");
//                         novaPf.Nome = Console.ReadLine();
// //criar arquivo(.txt):                   
//                         using (StreamWriter sw =new StreamWriter($"{novaPf.Nome}.txt"))
//                         {
//                             sw.WriteLine(novaPf.Nome);
//                         }
// //imprimir msg de sucesso:
//                          Console.WriteLine(@$"
//                          Cadastro Realizado com Sucesso!
//                          Pressione Enter para continuar");
//                          Console.ReadLine();

//                         break;

//                     case "2":

//                         Console.Clear();
// //buscar arquivo:
//                         using (StreamReader sr = new StreamReader("gean.txt"))
//                         {
//                             string? linha;               
//                             while ((linha = sr.ReadLine()) != null)
//                             {
//                                 Console.WriteLine($"{linha}");   
                                
//                                 Console.WriteLine(@$"Pressione Enter para continuar");
//                                 Console.ReadLine();

//                             }    
//                         }                       
                              
//                         break;

//-Gravar arquivos em CSV------------------------------------------------------------------------
                   case "1":

                        Console.Clear();
                     
                        Console.WriteLine($"Digite o NOME da Pessoa:");
                        novaPf.Nome = Console.ReadLine();
                        Console.WriteLine($"Digite o CPF da Pessoa:");
                        novaPf.cpf = Console.ReadLine();

//cadastrar o arquivo:
                        novaPf.InserirPf(novaPf);                        

// //imprimir msg de sucesso:                      
                        Console.WriteLine(@$"
                        Cadastro Realizado com Sucesso!
                        Pressione Enter para continuar");
                        Console.ReadLine();

                    break;

                    case "2":

                        Console.Clear();
                        
                        List<PessoaFisica> listaExibirPf =  novaPf.LerArquivo();
                                
                        foreach (var cadaItem in listaExibirPf)
                        {
                            Console.WriteLine($@"
                                Nome: {cadaItem.Nome};
                                CPF : {cadaItem.cpf}
                            
                                                   
                            ");

                            Console.WriteLine(@$"Pressione Enter para continuar");
                            Console.ReadLine(); 
                            Console.Clear();  
                        }

                        Console.WriteLine(@$"Pressione Enter para continuar");
                        Console.ReadLine();

                    break;

//----------------------------------------------------------------------------------------------
// //Cadastrar novas PFs:

//                     case "1":

//                         PessoaFisica novaPf = new PessoaFisica();
//                         Endereco novoEndPf = new Endereco();
//                         novaPf.Endereco = novoEndPf;
// //**falta o Imposto pF                        
//                         float ImpostoPagarPF = novaPf.CalcularImposto(novaPf.rendimentos);    

//                         Console.Clear();

//                         Console.WriteLine($"Digite o NOME da Pessoa:");
//                         novaPf.Nome = Console.ReadLine();
//**falta validar o cpf
//                         Console.WriteLine($"Digite o CPF da Pessoa:");
//                         novaPf.cpf = Console.ReadLine();

//                         Console.WriteLine($"Digite o RENDIMENTO da Pessoa:");
//                         string? rendEntrada = Console.ReadLine();
//                         float.TryParse(rendEntrada, out float rendConvertido);
//                         novaPf.rendimentos = rendConvertido;
// //**falta validar a data
// //de nascimento
//                         Console.WriteLine($"Digite a DATA DE NASCIMENTO da Pessoa:");
//                         string? dataEntrada = Console.ReadLine();
                        
//                         DateTime.TryParse(dataEntrada, out DateTime dataConvertida);
//                         novaPf.DataNasc = dataConvertida;
                    
//                         Console.WriteLine($"Digite o Endereço:");
//                         novoEndPf.logradouro = Console.ReadLine();

//                         Console.WriteLine($"Digite o NÚMERO do endereço:");
//                         string? numEntrada = Console.ReadLine();
//                         int.TryParse(numEntrada, out int numConvertido);
//                         novoEndPf.numero = numConvertido;

//                         Console.WriteLine($"Digite o CEP do endereço:");
//                         string? cepEntrada = Console.ReadLine();
//                         int.TryParse(cepEntrada, out int cepConvertido);
//                         novoEndPf.cep = cepConvertido;

//                         Console.WriteLine($"Complemento:");
//                         novoEndPf.complemento = Console.ReadLine();

// //adiciona o cadastro a 
// //uma lista:
//                          listaPF.Add(novaPf);

// //imprimir msg de sucesso:
//                          Console.WriteLine(@$"
//                          Cadastro Realizado com Sucesso!
//                          Pressione Enter para continuar");
//                          Console.ReadLine();

//                         break;

// //Listar na tela PFs Cadastrados:

//                     case "2":

//                         Console.Clear();
                       
//                         if (listaPF.Count > 0)
//                         {
//                                 foreach (PessoaFisica CadaPF in listaPF)
//                                 {

//                                     Console.Clear();
                                
//                                 Console.WriteLine(@$"
//                                 Nome: {CadaPF.Nome}
//                                 CPF:{CadaPF.cpf}
//                                 Endereço: {CadaPF.Endereco.logradouro}, Num:{CadaPF.Endereco.numero}
//                                 Complemento: {CadaPF.Endereco.complemento}
//                                 Maior de Idade: {CadaPF.ValidarDataNasc(CadaPF.DataNasc)}  
//                                 ");

//  //falta saber como colocar na lista:
//  //Imposto à pagar: {ImpostoPagarPF.ToString("C")}
//  //maioridade
//  //validacao do cpf
//                                 Console.WriteLine($"Pressione Enter para continuar");
//                                 Console.ReadLine();
//                                 }
//                         } else
//                         {
//                          Console.WriteLine($"Nenhum dado cadastrado para exibir"); 
//                          Thread.Sleep(1500);  
//                         }
                        
//                         break;
//------------------------------------------------------------------------------------------------------

//voltar a tela anterior:

                    case "0":
                    
                        break;

                    default:
                        Console.WriteLine($"Erro");
                        Thread.Sleep(1000);
                        break;
                }

            } while (opcaoPF != "0");

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
            // //Sai do menu
            // Utlils.barraCarregamento("Finalizando");
            // Console.Clear();               
            break;

        default:
            Console.WriteLine($"Erro");
            Thread.Sleep(1500);
            break;
    }

} while (opcao != "0");


//******************FIM DO MENU DO USUARIO*********************************************