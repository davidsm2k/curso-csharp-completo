using System;

namespace solucao_com_oo
{
    internal class Triangulo
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }

        public Triangulo() { }

        public double Area()
        {
            double calc = (this.ladoA + this.ladoB + this.ladoC) / 2.0;
            double area = Math.Sqrt(calc * (calc - this.ladoA) * (calc - this.ladoB) * (calc - this.ladoC));

            return area;
        }
    }
}
