using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;


namespace Logica
{
    public class Principal
    {
        public Respuesta RealizarCalculo(Function funcion, int xi, int xd, int numeroIteraciones, double tolerancia)
        {
            Respuesta respuesta = new Respuesta();
            int contador = 1;
            double xAnt = 0;
            Expression expresionxi = new Expression($"funcion({xi})", funcion);
            Expression expresionxd = new Expression($"funcion({xd})", funcion);
            double funcionxi = expresionxi.calculate();
            double funcionxd = expresionxd.calculate();

            if (funcionxi * funcionxd == 0)
            {
                if (funcionxi == 0)
                {
                    respuesta.Raiz = xi.ToString();
                    respuesta.Comentario = "xi es raíz";

                }
                else
                {
                    respuesta.Raiz = xd.ToString();
                    respuesta.Comentario = "xd es raiz";
                }
                respuesta.Converge = "Si";
                respuesta.Iteraciones = contador.ToString();
                respuesta.Error = 1.ToString();

                return respuesta;
            }
            else
            {
                if (funcionxi * funcionxd < 0)
                {
                    respuesta.Raiz = "-";
                    respuesta.Comentario = "No hay raiz entre los valores";
                    respuesta.Converge = "No";
                    respuesta.Iteraciones = contador.ToString();
                    respuesta.Error = 1.ToString();
                }
                else
                {
                    int xr = (xi + xd) / 2;
                    double error = CalcularError(xr, xAnt);
                    Argument nuevoArgumento = new Argument($"nuevoArgumento={xr}");
                    Expression nuevaExpresion = new Expression($"funcion({nuevoArgumento})", funcion, nuevoArgumento);
                    ResultadoComprobacion resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);
                    while (resultado.Resultado != false && nuevaExpresion.calculate() != 0)
                    {
                        if (nuevaExpresion.calculate() * expresionxi.calculate() < 0)
                        {
                            xd = xr;
                        }
                        else
                        {
                            xi = xr;
                            expresionxi = new Expression($"funcion({xi})", funcion);
                        }
                        xAnt = xr;
                        xr = (xi + xd) / 2;
                        error = CalcularError(xr, xAnt);
                        contador += 1;
                        nuevoArgumento = new Argument($"nuevoArgumento={xr}");
                        nuevaExpresion = new Expression($"funcion({nuevoArgumento})", funcion, nuevoArgumento);
                        resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);

                    }
                    respuesta.Converge = "Si";
                    respuesta.Comentario = resultado.Comentario;
                    respuesta.Error = error.ToString();
                    respuesta.Raiz = xr.ToString();
                    respuesta.Iteraciones = contador.ToString();
                }
                return respuesta;
            }
        }

        private ResultadoComprobacion ComprobarCondiciones(double tolerancia, int iteraciones, int contador, Expression funcion, double error)
        {
            ResultadoComprobacion resultado = new ResultadoComprobacion();
            if (Math.Abs(funcion.calculate()) < tolerancia)
            {
                resultado.Comentario = "El valor es menor a la tolerancia";
                resultado.Resultado = false;
            }
            else
            {
                if (error < tolerancia)
                {
                    resultado.Comentario = "El error es menor a la tolerancia";
                    resultado.Resultado = false;
                }
                else
                {
                    if (contador >= iteraciones)
                    {
                        resultado.Comentario = "Se superó el número de iteraciones";
                        resultado.Resultado = false;
                    }
                    else
                    {
                        resultado.Resultado = true;
                        resultado.Comentario = "xr es la raiz";
                    }

                }

            }
            return resultado;
        }

        private double CalcularError(double xr, double xAnt)
        {
            return Math.Abs((xr - xAnt) / xr);
        }
    }
}
