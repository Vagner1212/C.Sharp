using System;

namespace Academico
{
    public class Aluno
    {
        private string Matricula;  
        private string Nome;       
        private double NotaProva1;
        private double NotaProva2;
        private double NotaTrabalho;

        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public void RegistrarNotaProva1(double nota)
        {
            NotaProva1 = nota;
        }

        public void RegistrarNotaProva2(double nota)
        {
            NotaProva2 = nota;
        }

        public void RegistrarNotaTrabalho(double nota)
        {
            NotaTrabalho = nota;
        }

        public double CalcularMediaFinal()
        {
            return Math.Round((NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7.0, 1);
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("300729", "Vagner");

            aluno.RegistrarNotaProva1(8.0);
            aluno.RegistrarNotaProva2(8.0);
            aluno.RegistrarNotaTrabalho(10.0);

            Console.WriteLine($"Média final do aluno vagner e: {aluno.CalcularMediaFinal()}");
        }
    }
}


