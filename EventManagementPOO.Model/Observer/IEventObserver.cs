using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOPadroesProjeto.Observer
{
    public interface IEventObserver
    {
        void Update(string message);
    }
}
