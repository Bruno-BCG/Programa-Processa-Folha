class Chefe : Funcionarios
{

    //----------- Atributos -------------


    protected double adicChefe;   //Adicional de Chefia


    // ---------- constructors ------------

    public Chefe()
    {
        adicChefe = 0.0;
    }

    public Chefe(string nome, int idade, char sexo, int matricula, char cargo, double salBase, double gratProd, int numDep, double adicChefe) : base(nome, idade, sexo, matricula, cargo, salBase, gratProd, numDep)
    {
        this.adicChefe = adicChefe;
    }


    // ---------- gets e sets -----------
    public double AdicChefe
    {
        get => adicChefe;
        set => adicChefe = value;
    }

    // ----------- Metodos ------------
    public override double FornecaSalBruto()
    {
        return (base.FornecaSalBruto() + adicChefe);
    }

    public double fornecaAdicChefe()
    {
        return adicChefe;
    }

}