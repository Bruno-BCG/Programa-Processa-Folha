
class Empresa
{
    //---------- Atributos ----------
    
    protected string razaoSocial;
    protected string cnpj;
    protected int numFunc;              //Numero de funcionarios
    protected double salTotalBruto;     //Total de salario bruto dos funcionarios
    protected double salTotalLiquido;   //Total de salario liquido dos funcionarios
    protected double totalDescontos;    //Total de descontos dos funcionarios 
    

    //---------- Constructors ----------
    public Empresa()
    {
        razaoSocial=" ";
        cnpj=" ";
        numFunc= 0;
        salTotalBruto = 0.0;
        salTotalLiquido = 0.0;
        totalDescontos = 0.0;
    }

    /*Inicializar objeto com valor nas Atributos*/
    public Empresa (string razaoSocial, string cnpj, int numFunc)
    {
        this.razaoSocial= razaoSocial;
        this.cnpj= cnpj;
        this.numFunc= numFunc;
    }

    // ---------- gets e sets ------------

    public string RazaoSocial
    {
        get => razaoSocial;
        set => razaoSocial = value;
    }
    public string Cnpj
    {
        get => cnpj;
        set => cnpj = value;
    }
    public int NumFunc
    {
        get => numFunc;
        set => numFunc = value;
    }
    public double SalTotalBruto
    {
        get => salTotalBruto;
        set => salTotalBruto = value;
    }
    public double SalTotalLiquido
    {
        get => salTotalLiquido;
        set => salTotalLiquido = value;
    }
    public double TotalDescontos
    {
        get => totalDescontos;
        set => totalDescontos = value;
    }

    public double FornecaTotalBruto()
    {
        return salTotalBruto;
    }
    public double FornecaTotalLiquido()
    {
        return salTotalLiquido;
    }
    public double FornecaTotalDescontos()
    {
        return totalDescontos;
    }


    //---------- Metodos ----------
    public void ProcessaFolha(Interfaces aInterface)
    {

        int i = 0;
        string nome = " ";
        int idade = 0;
        int matricula = 0;
        int numDep = 0;
        double salBase = 0.0;
        double gratProd = 0.0;
        double adicChefe = 0.0;
        char sexo = ' ';
        char cargo = ' ';

        /*Loop para coletar a informação de cada funcionario com base no seu cargo e adicionar algumas informacoes a empresa*/
        while (i < this.numFunc)
        {
            aInterface.PecaDadosFunc(ref nome, ref idade, ref sexo, ref matricula, ref cargo, ref salBase, ref gratProd, ref numDep, ref adicChefe);
            Funcionarios oFunc = null;
            if (cargo == 'F') //Se o Funcionario for apenas um funcionario
            {
                oFunc = new Funcionarios(nome, idade, sexo, matricula, cargo, salBase, gratProd, numDep);
            }
            else if (cargo == 'A') //Se o Funcionario for do tipo "Apoio"
            {
                oFunc = new Apoio(nome, idade, sexo, matricula, cargo, salBase, gratProd, numDep);
            }
            else if (cargo == 'C') //Se o Funcionario for do tipo "Chefe"
            {
                Chefe oChefe = new Chefe(nome, idade, sexo, matricula, cargo, salBase, gratProd, numDep, adicChefe);
                oFunc = oChefe;
            }

            /*Mostrar os valores atuais da empresa apos a inclusão de cada funcionario*/
            salTotalBruto += oFunc.FornecaSalBruto();
            totalDescontos += oFunc.FornecaDescontos();
            salTotalLiquido += oFunc.FornecaSalLiquido();

            /*Mostrar informações coletas do funcionario*/
            aInterface.MostrarFunc(oFunc.Nome, oFunc.Cargo, oFunc.FornecaSalBruto(), oFunc.FornecaSalLiquido(), oFunc.FornecaDescontos());
            i++;
        }
    }
}