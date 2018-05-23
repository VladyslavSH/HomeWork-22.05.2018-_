using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Observers;

namespace WindowsFormsApp1.Subjects
{
    public interface iSubject
    {
        void registerObserver(iObserver o);
        void removeObserver(iObserver o);
        void notifyObserver();
    }
}
