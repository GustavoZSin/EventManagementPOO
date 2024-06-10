using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOPadroesProjeto.Observer
{
    public class Participant : IEventObserver
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Participant(string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"Participant {name} was notified! {message}");
        }
    }
}
