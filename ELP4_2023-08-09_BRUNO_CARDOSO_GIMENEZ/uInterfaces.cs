class Interfaces
{
    //---------- Atributos ----------

    //---------- Constructors ----------

    // ---------- gets e sets ------------

    //---------- Metodos ----------

    /*Coletar dados Funcionarios,Chefe ou Apoio*/
    public void PecaDadosFunc(ref string nome, ref int idade,ref char sexo,ref int matricula, ref char cargo, ref double salBase,ref double gratProd, 
    ref int numDep, ref double adicChefe)
    {  
        Console.WriteLine("Entre com o Tipo de funcionario(a): (F/A/C)");
        cargo = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.WriteLine("Entre com o numero de matricula deste funcionario(a): ");
        matricula = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre com o nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Entre com a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre com o sexo: M/F");
        sexo = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Entre com o Salario base do funcionario(a): ");
        salBase = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Entre com o valor de Gratificacao de producao: ");
        gratProd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Numero de Dependentes: ");
        numDep = Convert.ToInt32(Console.ReadLine());
        
        if (cargo == 'C') //Coletar valor do adicional de Chefia se o funcionario for do tipo "Chefe"
        {
            Console.WriteLine ("Entre com o valor do adicional de Chefia: ");
            adicChefe = Convert.ToDouble(Console.ReadLine()); 
        }
    }
    /*Coletar dados da empresa*/
    public void PecaDadosEmp(ref string razaoSocial, ref string cnpj, ref int numFunc)
    {
        Console.WriteLine("Entre com a Razao Social da Empresa: ");
        razaoSocial =Console.ReadLine();
        Console.WriteLine("Entre com o CNPJ da Empresa: ");
        cnpj = Console.ReadLine();
        Console.WriteLine("Entre com numero de colaboradores da empresa: ");
        numFunc = Convert.ToInt32(Console.ReadLine());
    }

    /*Mostrar os dados do Funcionario*/
    public void MostrarFunc(string nome, char cargo, double salBruto, double salLiquido, double descontos)
    {
        Console.WriteLine("Nome: {0}",  nome);
        Console.WriteLine("Cargo: {0}", cargo);
        Console.WriteLine("Salario Bruto: {0}", salBruto);
        Console.WriteLine("Descontos: {0}", descontos);
        Console.WriteLine("Salario Liquido: {0}",  salLiquido);
    }

    /*Mostrar os dados da empresa*/
    public void MostrarEmp(double salTotalBruto, double salTotalLiquido, double totalDescontos)
    {
        Console.WriteLine("Total de Salario Bruto: {0}", salTotalBruto);
        Console.WriteLine("Total de Descontos: {0}",  totalDescontos);
        Console.WriteLine("Total de Salario Liquido: {0}",  salTotalLiquido);
    }
}
