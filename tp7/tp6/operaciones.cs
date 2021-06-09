using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    class Calculadora
    {
        private float numero1 = 0, numero2 = 0, resultado =0;
        private char operacion;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public char Operacion { get => operacion; set => operacion = value; }
        public float Resultado { get => resultado; set => resultado = value; }

        public float suma(float n1, float n2)
        {
            return n1 + n2;
        }
        public float resta(float n1, float n2)
        {
            return n1 - n2;
        }
        public float multi(float n1, float n2)
        {
            return n1 * n2;
        }
        public float div(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}
