using System;
class Funcionarios : Pessoas
{

    //-------- Atributos ------------
    
    protected int matricula;    //ID do funcionário    
    protected char cargo;       //Cargo do Funcionário da empresa
    protected double salBase;   //Salario base do funcionário
    protected double gratProd;  //Gratificação de produção
    protected int numDep;       //numero de Dependentes
    

    // ---------- constructors ------------
    public Funcionarios()
    {
        matricula = 0;
        cargo = ' ';
        salBase = 0.0;
        gratProd= 0.0;
        numDep = 0;
    }

    /*Inicializar objeto com  valor nos Atributos*/
    public Funcionarios(string nome, int idade, char sexo, int matricula, char cargo, double salBase, double gratProd, int numDep)
    {
        this.matricula = matricula;
        this.cargo = cargo;
        this.salBase = salBase;
        this.gratProd= gratProd;
        this.numDep = numDep;
    }

    // ---------- gets e sets ------------
    public int Matricula 
    {
        get => matricula; 
        set => matricula = value;
    }
    public char Cargo
    {
        get => cargo ;
        set => cargo = value;
    }
    public double SalBase
    {
        get => salBase ;
        set => salBase = value;
    }
    public double GratProd
    {
        get => gratProd;
        set => gratProd = value;
    }
    public int NumDep
    {
        get => numDep;
        set => numDep = value;
    }

    // --------- Metodos ---------

    /*Fornece o salario bruto do funcionario, soma do salario base 
      com bonus de produtividade*/
    public virtual double FornecaSalBruto ()
    {
       return this.salBase + this.gratProd;
    }

    /*Fornece o valor do desconto do INSS com base no salario base*/
    public double FornecaINSS ()
    {
        return this.salBase * 0.1;
    }

    /*Fornece o valor do desconto do Imposto de Renda com base 
      na Tabela de Imposto de renda de 2023*/
    public double FornecaIR ()
    {
        if (this.salBase <= 1903.98)
        {
            return 0;
        }
        else if ((this.salBase >= 1903.99) && (this.salBase <= 2826.65))
        {
            return ((this.salBase * 0.075)  - 142.80);
        }
        else if ((this.salBase >= 2826.66) &&(this.salBase <= 3751.05))
        {
            return ((this.salBase * 0.15) - 354.80);

        }
        else if ((this.salBase >= 3751.06) && (this.salBase <= 4664.68))
        {
            return ((this.salBase * 0.225) - 636.130);
        }
        else
        {
            return ((this.salBase * 0.27) - 869.36);
        }
    }

    /*Fornece a soma dos descontos do INSS e Imposto de Renda*/
    public double FornecaDescontos()
    {
        return (FornecaINSS() + FornecaIR());

    }

    /*Fornece o salario liquido do funcionario*/
    public virtual double FornecaSalLiquido()
    {
        return ( FornecaSalBruto() - FornecaDescontos());
    }


}
