using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Composite
{
    internal interface IComponenteRuta
    {
        string Nombre { get; set; }
        double CalcularCosto();
        double CalcularTiempo();
    }
}
