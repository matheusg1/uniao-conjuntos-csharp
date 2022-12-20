using System;
using System.Collections.Generic;

namespace UniaoConjuntosCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            HashSet<Aluno> cursoA = new HashSet<Aluno>();
            HashSet<Aluno> cursoB = new HashSet<Aluno>();
            HashSet<Aluno> cursoC = new HashSet<Aluno>();

            cursoA.Add(new Aluno { Id = 21 });
            cursoA.Add(new Aluno { Id = 35 });
            cursoA.Add(new Aluno { Id = 22 });

            cursoB.Add(new Aluno { Id = 21 });
            cursoB.Add(new Aluno { Id = 50 });

            cursoC.Add(new Aluno { Id = 42 });
            cursoC.Add(new Aluno { Id = 35 });
            cursoC.Add(new Aluno { Id = 13 });

            var alunosUnicos = new HashSet<Aluno>(cursoA);
            alunosUnicos.UnionWith(cursoB);
            alunosUnicos.UnionWith(cursoC);
            Console.WriteLine(alunosUnicos.Count);
        }
    }
}
