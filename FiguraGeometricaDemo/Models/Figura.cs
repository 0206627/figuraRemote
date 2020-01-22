using System;
namespace FiguraGeometricaDemo.Models
{
    public class Figura
    {
        public int atributo1 { set; get; }
        private int _atributo2 { set; get; }
        protected int atributo3 { set; get; }
        public int atributo4 { set; get; }

        public Figura()
        {
            atributo1 = 1;
            _atributo2 = 1;
            atributo3 = 1;
            atributo4 = 1;
        }

    }
}
