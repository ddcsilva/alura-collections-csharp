using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListasSomenteLeitura
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

        private IList<Aula> aulas;
        public IList<Aula> Aulas 
        { 
            get { return new ReadOnlyCollection<Aula>(aulas); } 
        }
        public string Nome { get; set; }
        public string Instrutor { get; set; }
    }
}
