using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.ObserverPattern
{
    public class Website : IObserver
    {
        private string _name;

        public Website(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} received temperature update: {temperature} C");
        }
    }
}
