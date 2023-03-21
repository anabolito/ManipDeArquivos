using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaçãoDeArquivos
{
    internal class Person
    {
        public string Name { get; set; }
        public char Gender { get; set; }

        public Person(string n, char g)
        {
            this.Name = n;
            this.Gender = g;
           
        }
        public override string ToString()
        {
            return $"Nome:{Name} | Gênero: {Gender}" ;
        }
    }
}
