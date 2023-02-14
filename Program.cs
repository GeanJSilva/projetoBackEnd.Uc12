using ProjetoBackEnd.Classes;


PessoaJuridica novaPJ = new PessoaJuridica();
novaPJ.Nome = "VelhaAnglo";
novaPJ.cnpj = "1234123412341324";
novaPJ.rendimentos = 8000;


PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Gean";
novaPf.cpf ="123456789";
novaPf.rendimentos = 5000;
novaPf.DataNasc = new DateTime(2010, 01, 01);
//atribuir endereço:
Endereco novoEndPf = new Endereco();

novoEndPf.logradouro = "Rua D";
novoEndPf.numero = 100;
novoEndPf.cep = 57000000;
novoEndPf.complemento = "Curso Senai";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.cpf);

// //Interpolacao $:
// Console.WriteLine($"Bem vindo, {novaPf.Nome} de cpf {novaPf.cpf}");

// //Concatenação:
// Console.WriteLine("Bem vindo, "+ novaPf.Nome);


//Aula calcular imposto:
    //pessoa fisica:
    float ImpostoPagarPF = novaPf.CalcularImposto(novaPf.rendimentos);
    Console.WriteLine(ImpostoPagarPF.ToString("C"));


    //pessoa juridica
        float ImpostoPagarPJ = novaPJ.CalcularImposto(novaPJ.rendimentos);
        Console.WriteLine(ImpostoPagarPJ);

    //

    //validar data de nascimento:
        Console.WriteLine(novaPf.ValidarDataNasc("01/jan/2000"));
    //

    //mostrar o endereço total:
        //@ formatar o formulario como quiser: 
        Console.WriteLine(@$"
        
        Nome: {novaPf.Nome}
        Endereço: {novoEndPf.logradouro }, NUm: {novoEndPf.numero}
        Maior de Idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}        
        ");
        

