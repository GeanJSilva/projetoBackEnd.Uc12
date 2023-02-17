using ProjetoBackEnd.Classes;

//**********PESSOA FISICA***************

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();
// novaPf.Nome = "Gean";
// novaPf.cpf ="123456789";
// novaPf.rendimentos = 5000;
// novaPf.DataNasc = new DateTime(2010, 01, 01);

// novoEndPf.logradouro = "Rua D";
// novoEndPf.numero = 100;
// novoEndPf.cep = 57000000;
// novoEndPf.complemento = "Curso Senai";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// // Console.WriteLine(novaPf.Nome);
// // Console.WriteLine(novaPf.cpf);


//**********PESSOA JURIDICA***************

PessoaJuridica novaPJ = new PessoaJuridica();


novaPJ.Nome = "VelhaAnglo";
novaPJ.rendimentos = 8000;
novaPJ.cnpj = "59184301200115";
Endereco novoEndPJ = new Endereco();
novaPJ.Endereco = novoEndPJ;

novoEndPJ.logradouro = "Rua D";
novoEndPJ.numero = 100;
novoEndPJ.cep = 57000000;
novoEndPJ.complemento = "Curso Senai";
novoEndPJ.endComercial = true;

//Console.WriteLine(novaPJ.ValidarCnpj("59184301000115"));
//Console.WriteLine(novaPJ.ValidarCnpj("97.310.609/0001-07"));


//Interpolacao $:
Console.WriteLine(@$"
Nome: {novaPJ.Nome} 
Endereço: {novoEndPJ.logradouro}, Num: {novoEndPJ.numero}
CNPJ: {novaPJ.cnpj} - Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
");






// // //Interpolacao $:
// // Console.WriteLine($"Bem vindo, {novaPf.Nome} de cpf {novaPf.cpf}");

// // //Concatenação:
// // Console.WriteLine("Bem vindo, "+ novaPf.Nome);


//     //Aula calcular imposto:
    
//         //pessoa fisica:
//         float ImpostoPagarPF = novaPf.CalcularImposto(novaPf.rendimentos);
//         Console.WriteLine(ImpostoPagarPF.ToString("C"));

//         //pessoa juridica
//         float ImpostoPagarPJ = novaPJ.CalcularImposto(novaPJ.rendimentos);
//         Console.WriteLine(ImpostoPagarPJ);

//     //

    
//     //Aula validar data de nascimento:
//         Console.WriteLine(novaPf.ValidarDataNasc("01/jan/2000"));
//     //

//     //Aula mostrar o endereço total:
//         //@ formatar o formulario como quiser: 
//         Console.WriteLine(@$"
        
//         Nome: {novaPf.Nome}
//         Endereço: {novoEndPf.logradouro }, NUm: {novoEndPf.numero}
//         Maior de Idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}        
//         ");
//     //    


    