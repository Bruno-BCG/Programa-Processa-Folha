class Pessoas
{
    
    protected int idade;
    protected string nome;
    protected char sexo;
    
    public Pessoas()
    {
        idade = 0;
        nome = " ";
        sexo = ' ';
    }

    public Pessoas(int idade, string nome, char sexo)
    {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;

    }

    public int Idade 
    { 
        get => idade; 
        set => idade = value; 
    }

    public string Nome 
    { 
        get => nome; 
        set => nome = value; 
    }

    public char Sexo 
    { 
        get => sexo; 
        set => sexo = value; 
    }
}
