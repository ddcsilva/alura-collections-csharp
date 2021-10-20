using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SetNoModelo
{
    class Curso
    {
        public Curso(string nome, string instrutor)
        {
            this.aulas = new List<Aula>();
            Nome = nome;
            Instrutor = instrutor;
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        // Alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;
        public IList<Aula> Aulas 
        { 
            get { return new ReadOnlyCollection<Aula>(aulas); } 
        }
        public string Nome { get; set; }
        public string Instrutor { get; set; }

        public int TempoTotal { 
            get 
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                // LINQ = Language Integrated Query (Consulta Integrada à Linguagem)
                return aulas.Sum(aula => aula.Tempo);
            } 
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Tempo: {TempoTotal}, Aulas:\n\t{string.Join(",\n\t", aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }
    }
}
