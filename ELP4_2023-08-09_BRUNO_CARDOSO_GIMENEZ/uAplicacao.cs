class Aplicacao
{
    //---------- Atributos ----------

    protected Interfaces aInter = new Interfaces();

    //---------- Constructors ----------

    // ---------- gets e sets ------------

    //---------- Metodos ----------

    public void Execute()
    {
        string razaoSocial = " ";
        string cnpj = " ";
        int numFunc = 0;

        aInter.PecaDadosEmp(ref razaoSocial, ref cnpj, ref numFunc);
        Empresa aEmpresa = new Empresa(razaoSocial, cnpj, numFunc);
        aEmpresa.ProcessaFolha(aInter);
        aInter.MostrarEmp(aEmpresa.FornecaTotalBruto(), aEmpresa.FornecaTotalLiquido(), aEmpresa.FornecaTotalDescontos());
    }   
}
