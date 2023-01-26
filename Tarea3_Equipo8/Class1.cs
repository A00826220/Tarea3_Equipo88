using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_Equipo8
{
    public class GeneradorAlaeatorios
    {
        public List<float> aleatorios { get; set; }
        public int a { get; set; }
        public int c { get; set; }
        public int m { get; set; }
        public float semilla { get; set; }
    }
    
    public void GeneradorAleatorios (int numeroDatos, int limiteSuperior, int limiteInferior)
    {
        Random aleatorio = new Random(Environment.TickCount);
        for (int i = 0; i < a; i++)
        {
            double value = aleatorio.NextDouble();
            double value2 = aleatorio.Next(limiteInferior, limiteSuperior);
            double value3 = aleatorio.Next(limiteInferior, limiteSuperior);
            Numeros numero = new Numeros();
            numero.Valores = i.ToString();
            numero.CantidadRequerida = value2;
            numero.formula = value2 + value3;
            listaNumeros.Add(numero);
        }
        {
            double formula1 = 0;
            double formula2 = 0;
            double formula3 = 0;
            llenarDatosAleatorios(numeroDatos, limiteInferior, limiteSuperior);
            formula1 = calcularFormula1(listaNumeros);
            formula2 = calcularFormula2(listaNumeros, formula1);
            formula3 = calcularFormula3(listaNumeros, formula2);
            listaNumeros.Add(formula1);
            listaNumeros.Add(formula2);
            listaNumeros.Add(formula3);
            return formula1;
        }
        {
        public double calcularFormula1(List<double> listaNumeros)
        {
           double formula1 = 0, formula = 0;
           foreach (Numeros numero in listaNumeros)
           {
                    formula1 = semilla();
           }
            return formula1; 
        }
        public double calcularFormula2(List<double> listaNumeros)
        {
            double formula2 = 0;
            foreach(Numeros numero in listaNumeros)
            {
                formula2 = a * formula1 + c();
            }
            return formula2;
        }
        public double calcularFormula3(double formula2)
        {
            double formula3 = 0;
            foreach (Numeros numero in listaNumeros)
            {
                formula3 = formula2 MOD m();
            }
            return formula3;
        }

        
    }
    


    
}
