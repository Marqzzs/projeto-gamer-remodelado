using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_estaticas
{
    public static class Conversor
    {
        public static float Valor { get; set; }

        public static float ReaisParaDolar(float Valor)
        {
            Valor = Valor * 5.01f;

            return Valor;
        }

        public static float DolarParaReais(float Valor)
        {
            Valor = Valor / 5.01f;

            return Valor;
        }
    }
}
// .ToString("C"), CultureInfo.CreatSpecificCulture("en-US")