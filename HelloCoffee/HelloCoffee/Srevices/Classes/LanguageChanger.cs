using HelloCoffee.Srevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoffee.Srevices.Classes
{
    public class LanguageChanger : ILanguageChanger
    {
        public string CurrentLan { get; set; }

        public event Action RefreshRequested;

        public LanguageChanger()
        {
            CurrentLan = "en";
        }

        public void ChangeCurrentLan(string Lan)
        {
            CurrentLan = Lan;
            RefreshRequested?.Invoke();
        }

        public string GetCurrentLan()
        {
            return CurrentLan;
        }
    }
}
