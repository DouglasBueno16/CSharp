/*
Propriedades e métodos construtores
*/

using PropriedadesMetodosConstrutores;

Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Bueno");
// {
//     Nome = "Douglas",
//     Sobrenome = "Bueno",
//     Idade = 21
// };
// p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Silva");
// {
//     Nome = "João",
//     Sobrenome = "Silva",
//     Idade = 22
// };

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();