using System;
using Sistema_de_Controle_de_Clientes.Model;

class Program
{
    static void Main(string[] args)
    {
        float valorCompra;
        Console.WriteLine("Informar Nome");
        var nome = Console.ReadLine();
        Console.WriteLine("Informar Endereço");
        var endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
        var tipoPessoa = Console.ReadLine();
        if (tipoPessoa == "f")
        {
            // --- Pessoa Física ----
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.nome = nome;
            pessoaFisica.endereco = endereco;
            Console.WriteLine("Informar CPF:");
            pessoaFisica.cpf = Console.ReadLine();
            Console.WriteLine("Informar RG:");
            pessoaFisica.rg = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            valorCompra = float.Parse(Console.ReadLine());
            pessoaFisica.Pagar_Imposto(valorCompra);
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + pessoaFisica.nome);
            Console.WriteLine("Endereço ......: " + pessoaFisica.endereco);
            Console.WriteLine("CPF ...........: " + pessoaFisica.cpf);
            Console.WriteLine("RG ............: " + pessoaFisica.rg);
            Console.WriteLine("Valor de Compra: " +
            pessoaFisica.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " +
            pessoaFisica.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " +
            pessoaFisica.total.ToString("C"));
        }
        if (tipoPessoa == "j")
        {
            // Pessoa Jurídica
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.nome = nome;
            pessoaJuridica.endereco = endereco;
            Console.WriteLine("Informar CNPJ:");
            pessoaJuridica.cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            pessoaJuridica.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            valorCompra = float.Parse(Console.ReadLine());
            pessoaJuridica.Pagar_Imposto(valorCompra);
            Console.WriteLine("-------- Pessoa Jurídica ---------");
            Console.WriteLine("Nome ..........: " + pessoaJuridica.nome);
            Console.WriteLine("Endereço ......: " + pessoaJuridica.endereco);
            Console.WriteLine("CNPJ ..........: " + pessoaJuridica.cnpj);
            Console.WriteLine("IE ............: " + pessoaJuridica.ie);
            Console.WriteLine("Valor de Compra: " +
            pessoaJuridica.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " +
            pessoaJuridica.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " +
            pessoaJuridica.total.ToString("C"));
        }
    }
}

