using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_no8
{
    public class Temperatura
    {
        int departamento;
        int temperaturaLeida;

        public int Departamento { get => departamento; set => departamento = value; }
        public int TemperaturaLeida { get => temperaturaLeida; set => temperaturaLeida = value; }
    }
}