using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Observers
{
    public interface iObserver
    {
        void update(int temp, int humidity, int pressure);
        void display();
    }
}
