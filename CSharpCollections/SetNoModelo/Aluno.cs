namespace SetNoModelo
{
    /// <summary>
    /// Representa um Aluno, com nome e número de matrícula
    /// </summary>
    class Aluno
    {
        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }

        /// <summary>
        /// Obtém o texto com detalhes do aluno, no formato "[Nome: , Matrícula: ]"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
        }

        /// <summary>
        /// Determina se esta instância de aluno e outra instância de aluno 
        /// possuem o mesmo valor.
        /// </summary>
        /// <param name="obj">A outra instância de Aluno a ser comparada</param>
        /// <returns>Verdadeiro ou falso, indicando se as duas instâncias possuem o mesmo valor.</returns>
        public override bool Equals(object obj)
        {
            Aluno aluno = obj as Aluno;

            if (aluno == null)
            {
                return false;
            }

            return this.Nome.Equals(aluno.Nome);
        }

        /// <summary>
        /// Retorna o código de dispersão para este Aluno.
        /// </summary>
        /// <returns>Um código de dispersão inteiro de 32 bits.</returns>
        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        //IMPORTANTE!!
        //Dois objetos que são iguais possuem o mesmo hash code.
        //PORÉM, o contrário não é verdadeiro: 
        //Dois objetos com mesmo hash codes não são necessariamente iguais! 
    }
}
