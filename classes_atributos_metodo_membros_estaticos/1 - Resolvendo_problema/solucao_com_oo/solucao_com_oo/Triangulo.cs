using System;

namespace solucao_com_oo
{
    internal class Triangulo
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public Triangulo() { }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public void SetLadoA (double ladoA)
        {
            this.ladoA = ladoA;
        }

        public void SetLadoB(double ladoB)
        {
            this.ladoB = ladoB;
        }

        public void SetLadoC(double ladoC)
        {
            this.ladoC = ladoC;
        }

        public double Area()
        {
            double calc = (this.ladoA + this.ladoB + this.ladoC) / 2.0;
            double area = Math.Sqrt(calc * (calc - this.ladoA) * (calc - this.ladoB) * (calc - this.ladoC));

            return area;
        }
    }
}
