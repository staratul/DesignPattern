using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.ObserverPattern
{
    public interface IObserver
    {
        void Update(float temperature);
    }
}
