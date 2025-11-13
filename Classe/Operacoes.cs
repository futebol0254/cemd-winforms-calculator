using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public double getX()
        {
            return this.x;
        }

        public void setYFromInput(double y)
        {
            this.y = y;
        }

        public double getY()
        {
            return this.y;
        }

        //Operações
        public double Sum() => x + y;

        public double Subtract() => x - y;

        public double Multiply() => x * y;

        public double Divide()
        {

            if (y == 0)
            {
                return double.NaN;
            }
            return x / y;
        }

        public double SquareOfX() => x * x;

        public double SquareRootOfX()
        {

            if (x < 0)
            {
                return double.NaN;
            }

            return Math.Sqrt(x);
        }

        public double PercentageXofY() => (x / 100) * y;

        public double ToBinary()
        {
            long numero = (long)x;
            if (numero < 0) return double.NaN;
            if (numero == 0) return 0;

            double resultadoBinario = 0;
            double multiplicador = 1;

            while (numero > 0)
            {
                resultadoBinario += (numero % 2) * multiplicador;
                numero /= 2;
                multiplicador *= 10;
            }
            return resultadoBinario;
        }

        public double XRaisedToThePowerOfY()
        {
            if (y == 0) return 1.0;

            double resultado = 1.0;
            int potencia = (int)Math.Abs(y);

            for (int i = 0; i < potencia; i++)
            {
                resultado *= x;
            }

            if (y < 0)
            {
                return 1.0 / resultado;
            }
            return resultado;
        }
    }
}
