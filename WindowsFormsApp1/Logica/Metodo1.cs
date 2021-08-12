using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;




namespace Logica
{
    public class Metodo1
    {
        /*public bool RealizarCalculo(Function funcion, int xi, int xd, int numeroIteraciones, double tolerancia)
        {
            string comentario, convergente;
            int raiz, iteraciones, contador;
            double errorRelativo, xAnt;
            List<string> Datos = new List<string>();
            Expression expresionxi = new Expression($"funcion({xi})", funcion);
            Expression expresionxd = new Expression($"funcion({xd})", funcion);
            double funcionxi =expresionxi.calculate();
            double funcionxd = expresionxd.calculate();

            if (funcionxi*funcionxd==0)
            {
                if (funcionxi==0)
                {
                    raiz = xi;
                    comentario = "xi es raíz";
                }
                else
                {
                    raiz = xd;
                    comentario = "xd es raiz";
                }
                convergente = "Si";
                iteraciones = 1;
                errorRelativo = CalcularError(xd,xAnt);
                return true;
            }
            else
            {
                if(funcionxi*funcionxd<0)
                {
                    raiz = 0;
                    comentario = "No hay raiz entre los valores";
                    convergente = "No";
                    iteraciones = 1;
                    errorRelativo = CalcularError(xd, xAnt);
                }
                else
                {
                    double xr = (xi+xd)/2;
                    double error = CalcularError(xr, xAnt);
                    while (ComprobarCondiciones()!=true)
                    {
                        Argument nuevoArgumento=new Argument($"b={xr}");
                        Expression nueaExpresion = new Expression($"{funcion}({xr})", funcion, xr);
                        if (expresionxd.calculate)
                        {

                        }
                        xr = xr = (xi + xd) / 2;
                        error = CalcularError(xr,xAnt);
                        contador += 1;
                        xAnt = xr;
                    }
                }
            }
            return true;
            
        }

        private bool ComprobarCondiciones(double xr,double tolerancia,int iteraciones,int contador,Function funcion ,int contador, double error)
        {
            if (Math.Abs(funcion))
            {

            }
            else
            {
                if ()
                {

                }
                else
                {

                }
            }
        }*/

        private double CalcularError(double xr, double xAnt)
        {
            return Math.Abs((xr - xAnt) / xr);
        }
        
    }
}
