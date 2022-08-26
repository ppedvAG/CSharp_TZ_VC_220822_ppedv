using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenbibliothekBeispiel
{
    public interface IArbeitend
    {
        int Gehalt { get; set; }
        string Job { get; set; }

        void Auszahlung();
    }
}
