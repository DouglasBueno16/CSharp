namespace PropriedadesMetodosConstrutores;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
        Alunos = new List<Pessoa>();
    }
    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }  // adicionar aluno

    public int ObterQuantidadeDeAlunosMatriculados()
    {
        return Alunos.Count;
    }

    public void RemoverAluno(Pessoa aluno)
    {
        Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos matriculados no curso {Nome}: ");

        for (int count = 0; Alunos.Count > count; count++ )
        {
            string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";  // interpolação
            Console.WriteLine(texto);
        }
       
    }  // listar alunos

}  // Curso
