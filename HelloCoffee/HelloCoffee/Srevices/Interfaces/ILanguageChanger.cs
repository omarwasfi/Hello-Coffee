using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoffee.Srevices.Interfaces
{
    interface ILanguageChanger
    {
        public event Action RefreshRequested;

        public void ChangeCurrentLan(string Lan);

        public string GetCurrentLan();
    }
}
