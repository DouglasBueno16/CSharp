/*
Propriedades e métodos construtores
*/

using PropriedadesMetodosConstrutores;

Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Bueno");

Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Silva");

Curso cursoDeIngles = new Curso(nome: "Inglês");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();