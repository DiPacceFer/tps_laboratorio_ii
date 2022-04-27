using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        double numero;

        string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }
        #region Constructores

        public Operando()
        {
            this.Numero = "0";
        }
        public Operando(double numero)
        {
            this.Numero = numero.ToString();
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion
        private double ValidarOperando(string strNumero)
        {
            double validacion = 0;
            foreach (char i in strNumero)
            {
                if (i < 48 || i > 57)
                    break;
                else
                    validacion++;
            }
            if (validacion > 0)
                return Convert.ToDouble(strNumero);
            else
                return validacion;
        }
        public static bool EsBinario(string binario)
        {
            bool validacion = true;
            foreach (int i in binario)
            {
                if (i != '1' && i != '0')
                {
                    validacion = false;
                    break;
                }
            }
            return validacion;
        }
        public static string BinarioDecimal(string binario)
        {
            double numeroDe = 0;
            if (EsBinario(binario))
            {
                double x = 1;
                int tam = binario.Length;
                int b = tam;
                int d;
                for (int j = 0; j < tam; j++)
                {
                    char c;
                    x = Math.Pow(2, j);
                    c = binario[b - 1];
                    d = (int)(c - '0');
                    numeroDe += (int)x * d;
                    b--;
                }
                return (Math.Abs(numeroDe)).ToString();
            }
            else
                return "Valor invalido";
        }
        public static string DecimalBinario(double numero)
        {
            double b;
            string binario = "";
            string resultado = "";
            b = Math.Abs(numero);
            do
            {
                b = Math.Floor(b);
                binario = ((b % 2).ToString()) + binario;
                b = b / 2;
                if (b <= 1)
                {
                    resultado = binario;
                }
            } while (b > 1);
            if (EsBinario(resultado))
            {
                return resultado;
            }
            else
                return "Valor invalido";
        }
        public static string DecimalBinario(string numero)
        {
            double dec = Convert.ToDouble(numero);
            return DecimalBinario(dec);
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2 != 0)
                return n1.numero / n2.numero;
            else
                return double.MinValue;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static bool operator ==(Operando n1, double numero)
        {
            return n1.numero == numero;
        }
        public static bool operator !=(Operando n1, double numero)
        {
            return n1.numero != numero;
        }
    }
}
