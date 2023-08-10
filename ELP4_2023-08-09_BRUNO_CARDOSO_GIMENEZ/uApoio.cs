class Apoio : Funcionarios
{
    //---------- Atributos ----------

    //---------- Constructors ----------

    public Apoio(string nome, int idade, char sexo, int matricula, char cargo, double salBase, double gratProd, int numDep) : base(nome, idade, sexo, matricula, cargo, salBase, gratProd, numDep)
    {

    }

    //---------- Metodos ----------

    /*Calcular o valor do auxilio educação com base no numero de dependentes*/
    public double CalcAuxilioEduc()
    {
        
        if (base.numDep <= 5)
        {
            return  (base.numDep * 60.00);
        }
        else
        {
            return 300.00;
        }
    }

    /*Calcular o salario liquido, soma do salario bruto mais o auxilio educação*/
    public override double FornecaSalLiquido()
    {
        return (base.FornecaSalBruto() + CalcAuxilioEduc());
    }

}
