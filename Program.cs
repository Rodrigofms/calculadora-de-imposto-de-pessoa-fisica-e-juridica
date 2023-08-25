using System;
namespace calculadora_de_imposto_de_pessoa_fisica_e_juridica
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereco");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Juridica (j) ?");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f" || var_tipo == "F")
            {
                // --- Pessoa Fisica ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar o RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Fisica --------");
                Console.WriteLine("Nome.........: " + pf.nome);
                Console.WriteLine("Endereco.....: " + pf.endereco);
                Console.WriteLine("CPF..........: " + pf.cpf);
                Console.WriteLine("RG...........: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar...: " + pf.total.ToString("C"));
            }
            if (var_tipo == "j" || var_tipo == "J")
            {
                // --- Pessoa Juridica ---
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor de compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Juridica --------");
                Console.WriteLine("Nome.........: " + pj.nome);
                Console.WriteLine("Endereco.....: " + pj.endereco);
                Console.WriteLine("CNPJ.........: " + pj.cnpj);
                Console.WriteLine("IE...........: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar: " + pj.total.ToString("C"));
            }
        }
    }
}
