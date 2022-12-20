using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniaoConjuntosCsharp
{
    public class Aluno
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Id == aluno.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}