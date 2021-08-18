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
        public Respuesta RealizarCalculo(Function funcion, double xi, double xd, int numeroIteraciones, double tolerancia)
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
                if (funcionxi * funcionxd > 0)
                {
                    respuesta.Raiz = "-";
                    respuesta.Comentario = "No hay raiz entre los valores";
                    respuesta.Converge = "No";
                    respuesta.Iteraciones = contador.ToString();
                    respuesta.Error = 1.ToString();
                }
                else
                {
                    double xr = (xi + xd) / 2;
                    double error = CalcularError(xr, xAnt);
                    Argument x = new Argument($"x={xr}");
                    Expression nuevaExpresion = new Expression($"funcion(x)", funcion, x);
                    ResultadoComprobacion resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);
                    while (resultado.Resultado != false)
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
                        x = new Argument($"nuevoArgumento={xr}");
                        nuevaExpresion = new Expression($"funcion(x)", funcion, x);
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
            if (funcion.calculate() == 0)
            {
                resultado.Resultado = false;
                resultado.Comentario = "xr es la raiz";
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
                        if (Math.Abs(funcion.calculate()) < tolerancia)
                        {
                            resultado.Comentario = "El valor es menor a la tolerancia";
                            resultado.Resultado = false;
                        }
                        else
                        {
                            resultado.Resultado = true;
                        }
                    }

                }

            }
            return resultado;
        }

        private double CalcularError(double xr, double xAnt)
        {
            return Math.Abs((xr - xAnt) / xr);
        }
        public Respuesta CalculoReglaFalsa(Function funcion, int Xi, int Xd, int numeroIteraciones, double Tolerancia)
        {
            Respuesta ReglaFalsa = new Respuesta();
            int cont = 1;
            double Xanterior = 0;
            Expression Xizquierda = new Expression();
            Expression Xderecha = new Expression();
            double funcionXizquierda = Xizquierda.calculate();
            double funcionXderecha = Xderecha.calculate();
            if (funcionXizquierda * funcionXderecha == 0)
            {
                if (funcionXizquierda == 0)
                {
                    cont += 1;
                    ReglaFalsa.Raiz = Xizquierda.ToString();
                    ReglaFalsa.Comentario = "Xizquierda es raìz";
                }
                else
                {
                    ReglaFalsa.Raiz = Xderecha.ToString();
                    ReglaFalsa.Comentario = "Xderecha es raìz";

                }
                ReglaFalsa.Converge = "Si";
                ReglaFalsa.Iteraciones = cont.ToString();
                return ReglaFalsa;
            }
            else
                if (funcionXizquierda * funcionXderecha > 0)
            {
                ReglaFalsa.Raiz = "-";
                ReglaFalsa.Comentario = "no hay raìz";
                ReglaFalsa.Converge = "No";
                ReglaFalsa.Iteraciones = cont.ToString();
            }
            else
            {
                // double Xr=(funcionXderecha*Xizquierda-funcionXizquierda*Xderecha)/funcionXDerecha-funcionXizquierda)
            }
            return null;

        }
    }
}

