using System;
using System.Collections.Generic;
using System.Text;

namespace SetNoModelo
{
    class Aluno
    {
        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }

        public override string ToString()
        {
            return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
        }
    }
}
