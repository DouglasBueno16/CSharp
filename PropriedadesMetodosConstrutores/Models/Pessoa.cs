namespace PropriedadesMetodosConstrutores;

public class Pessoa
{
    public Pessoa(string nome, string sobrenome)
    {
        // Método construtor
        Nome = nome;
        Sobrenome = sobrenome;
    }
    private string _nome;  // campo privado para armazenar o nome
    public string Nome
    {
        get => _nome.ToUpper();  // retorna o nome em maiúsculas              
        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            _nome = value;
        }
    }

    public string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();  // retorna a concatenação das classes 

    private int _idade;  // campo privado para Idade
    public int Idade
    {
        get => _idade;  // retorna a idade

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa.");
            }
            _idade = value;
        }

    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
    }  // Apresentar

}  // class Pessoa
