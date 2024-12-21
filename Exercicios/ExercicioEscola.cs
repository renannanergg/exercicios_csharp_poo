// Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

namespace Exercicios
{
    public class Aluno
    {
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; }
        public int Idade { get; }
        public List<double> Notas {get; set;} = new List<double>();
        public string FichaAluno => $"O aluno(a) {Nome} tem {Idade} anos.";
    }

    public class Professor
    {
        public Professor(string nome)
        {
            Nome = nome;
        }
        public string Nome { get;}
        public List<string> DisciplinasLecionadas = new List<string>();
        public string FichaProfessor => $"O professor(a) {Nome} leciona {DisciplinasLecionadas.Count} disciplinas";
       
    }

    public class Disciplina
    {
        public Disciplina(string nome)
        {
            NomeDisciplina = nome;
        }
        public string NomeDisciplina { get;}
        List<Aluno> AlunosMatriculados {get; set;} = new List<Aluno>();
        public string FichaDisciplina => $"A disciplina {NomeDisciplina} tem {AlunosMatriculados.Count} alunos matriculados.";

        public void AdicionarAlunoNaDisciplina(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
            Console.WriteLine($"O aluno {aluno.Nome} foi adicionado na matéria {NomeDisciplina}");
        }

    }

    public class ExercicioEscola
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno("Maria", 17); 
            Aluno aluno2 = new Aluno("Carlos", 18); 
            Professor professor = new Professor("Dr. Silva"); 
            Disciplina disciplina = new Disciplina("Matemática"); 

            disciplina.AdicionarAlunoNaDisciplina(aluno1);
            disciplina.AdicionarAlunoNaDisciplina(aluno2);

            professor.DisciplinasLecionadas.Add("Matemática");

            Console.WriteLine(aluno1.FichaAluno); 
            Console.WriteLine(aluno2.FichaAluno); 
            Console.WriteLine(professor.FichaProfessor);
            Console.WriteLine(disciplina.FichaDisciplina);

        }
    }
}