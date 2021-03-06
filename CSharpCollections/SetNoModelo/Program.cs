using System;

namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos declarar o curso
            Curso csharpCollections = new Curso("C# Collections", "Marcelo Oliveira");

            // Adicionando 3 aulas a esse curso
            // - Trabalhando com Listas - 21 minutos
            // - Criando uma Aula - 20 minutos
            // - Modelando com Coleções - 24 minutos
            csharpCollections.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpCollections.Adiciona(new Aula("Criando uma Aula", 20));
            csharpCollections.Adiciona(new Aula("Modelando com Coleções", 24));

            // Um aluno também tem matrícula!
            // Vamos criar a classe Aluno com Nome e NumeroMatricula
            // - Vanessa Tonini - 34672
            // - Ana Losnak - 5617
            // - Rafael Nercessian - 17645
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // Precisamos matricular os alunos no curso, criando um método
            csharpCollections.Matricula(a1);
            csharpCollections.Matricula(a2);
            csharpCollections.Matricula(a3);

            // Imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpCollections.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();

            //Imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            //Criar um método EstaMatriculado
            Console.WriteLine(csharpCollections.EstaMatriculado(a1));
            //Vamos instanciar uma aluna (Vanessa Tonini)
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //e verificar se Tonini está matriculada
            Console.WriteLine("Tonini está matriculada? " + csharpCollections.EstaMatriculado(tonini));
            //Mas a1 == a Tonini?
            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);
            //O que ocorreu? a1 é equals a Tonini?
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));
            //São diferentes! Precisamos então implementar Equals()
        }
    }
}
