using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using System.Globalization;


namespace Logica
{
    public class Principal
    {
        ///////////////////////////////// Bisección ////////////////////////////////////////////
        public Respuesta CalcularBiseccion(Function f, double xi, double xd, int numeroIteraciones, double tolerancia)
        {
            Respuesta respuesta = new Respuesta();
            int contador = 0;
            double xAnt = 0;
            Expression expresionxi = new Expression("f("+xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")", f);
            Expression expresionxd = new Expression("f("+xd.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")", f);
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
                respuesta.Error = "-";

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
                    respuesta.Error = "-";
                }
                else
                {
                    double xr = (xi + xd) / 2;
                    double error = CalcularError(xr, xAnt);
                    contador += 1;
                    Expression nuevaExpresion = new Expression("f("+xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))+")", f);
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
                            expresionxi = new Expression("f("+ xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))+")", f);
                        }
                        xAnt = xr;
                        xr = (xi + xd) / 2;
                        error = CalcularError(xr, xAnt);
                        contador += 1;
                        nuevaExpresion = new Expression("f("+xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))+")", f);
                        resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);

                    }
                    if (resultado.Comentario == "Se superó el número de iteraciones")
                    {
                        respuesta.Converge = "No";
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = "-";
                        respuesta.Raiz = "-";
                        respuesta.Iteraciones = contador.ToString();
                    }
                    else
                    {
                        respuesta.Converge = "Si";
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = error.ToString();
                        respuesta.Raiz = xr.ToString("###0.0000");
                        respuesta.Iteraciones = contador.ToString();
                    }
                    /*respuesta.Comentario = resultado.Comentario;
                    respuesta.Error = error.ToString();
                    respuesta.Raiz = xr.ToString("####.0000");
                    respuesta.Iteraciones = contador.ToString();*/
                }
                return respuesta;
            }
        }

        //////////////////////////////// Regla falsa ////////////////////////////////////////////
        public Respuesta CalcularReglaFalsa(Function f, double xi, double xd, int numeroIteraciones, double tolerancia)
        {
            Respuesta respuesta = new Respuesta();
            int contador = 0;
            double xAnt = 0;
            Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionxd = new Expression("f(" + xd.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
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
                respuesta.Error = "-";

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
                    respuesta.Error = "-";
                }
                else
                {
                
                    double xr = ((funcionxd * xi) - (funcionxi * xd)) / (funcionxd - funcionxi);
                    double error = CalcularError(xr, xAnt);
                    contador += 1;
                    Expression nuevaExpresion = new Expression("f("+xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")", f);
                    ResultadoComprobacion resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);
                    while (resultado.Resultado != false)
                    {
                        if (nuevaExpresion.calculate() * expresionxi.calculate() < 0)
                        {
                            xd = xr;
                            expresionxd = new Expression("f("+xd.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")", f);
                            funcionxd = expresionxd.calculate();
                        }
                        else
                        {
                            xi = xr;
                            expresionxi = new Expression("f("+xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")", f);
                            funcionxi = expresionxi.calculate();
                            
                        }
                        xAnt = xr;
                        xr = ((funcionxd * xi) - (funcionxi * xd)) / (funcionxd - funcionxi);
                        error = CalcularError(xr, xAnt);
                        contador += 1;
                        nuevaExpresion = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        resultado = ComprobarCondiciones(tolerancia, numeroIteraciones, contador, nuevaExpresion, error);
                    }

                    if (resultado.Comentario == "Se superó el número de iteraciones")
                    {
                        respuesta.Converge = "No";
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = "-";
                        respuesta.Raiz = "-";
                        respuesta.Iteraciones = contador.ToString();
                    }
                    else
                    {
                        respuesta.Converge = "Si";
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = error.ToString();
                        respuesta.Raiz = xr.ToString("###0.0000");
                        respuesta.Iteraciones = contador.ToString();
                    }
                    /*respuesta.Comentario = resultado.Comentario;
                    respuesta.Error = error.ToString();
                    respuesta.Raiz = xr.ToString("####.0000");
                    respuesta.Iteraciones = contador.ToString();*/
                }
                return respuesta;
            }
        }

        ///////////////////////////////// Newton Raphson /////////////////////////////////
        public Respuesta CalcularNewtonRaphson(Function f, double xi, int iteraciones, double tolerancia)
        {
            Respuesta respuesta = new Respuesta();
            int contador = 0;
            double xAnt = 0;
            Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionxitolerancia = new Expression("f(" + (xi + tolerancia).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            if (expresionxi.calculate()==0)
            {
                respuesta.Raiz = xi.ToString();
                respuesta.Comentario = "xi es la raíz";
                respuesta.Converge = "Si";
                respuesta.Error = "-";
                respuesta.Iteraciones = contador.ToString();
            }
            else
            {
                double derivadaXi = (expresionxitolerancia.calculate() - expresionxi.calculate()) / tolerancia;
                if (derivadaXi == 0)
                {
                    respuesta.Raiz = "-";
                    respuesta.Comentario = "No hay raiz";
                    respuesta.Converge = "No";
                    respuesta.Error = "-";
                    respuesta.Iteraciones = contador.ToString();
                }
                else
                {
                    double xr = xi - (expresionxi.calculate() / derivadaXi);
                    contador += 1;
                    double error = CalcularError(xr, xAnt);
                    Expression nuevaExpresion = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                    ResultadoComprobacion resultado = ComprobarCondiciones(tolerancia, iteraciones, contador, nuevaExpresion, error);
                    while (resultado.Resultado != false)
                    {
                        xAnt = xr;
                        xi = xr;
                        contador += 1;
                        expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        expresionxitolerancia = new Expression("f(" + (xi + tolerancia).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        derivadaXi = (expresionxitolerancia.calculate() - expresionxi.calculate()) / tolerancia;
                        xr = xi - (expresionxi.calculate() / derivadaXi);
                        error = CalcularError(xr, xAnt);
                        nuevaExpresion = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        resultado = ComprobarCondiciones(tolerancia, iteraciones, contador, nuevaExpresion, error);
                    }
                    if (resultado.Comentario== "Se superó el número de iteraciones")
                    {
                        respuesta.Converge = "No";
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = "-";
                        respuesta.Raiz = "-";
                        respuesta.Iteraciones = contador.ToString();
                    }
                    else
                    {
                        respuesta.Converge = "Si";
                        respuesta.Raiz = xr.ToString("###0.0000");
                        respuesta.Comentario = resultado.Comentario;
                        respuesta.Error = error.ToString();
                        respuesta.Iteraciones = contador.ToString();
                    }
                    
                }
            }
            return respuesta;
        }

        //////////////////////////////// Secante ///////////////////////////////////
        public Respuesta CalcularSecante(Function f, double xi, double xd,int iteraciones, double tolerancia)
        {
            //xd=xi
            //xi=xi+1
            Respuesta respuesta = new Respuesta();
            int contador = 0;
            double xAnt = 0;
            Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionxd = new Expression("f(" + xd.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            
            if (expresionxi.calculate()==0)
            {
                respuesta.Raiz = xi.ToString();
                respuesta.Comentario = "xi es la raiz";
                respuesta.Converge = "Si";
                respuesta.Error = "-";
                respuesta.Iteraciones = contador.ToString();
            }
            else
            {
                if (expresionxd.calculate()==0)
                {
                    respuesta.Raiz = xd.ToString();
                    respuesta.Comentario = "xd es la raiz";
                    respuesta.Converge = "Si";
                    respuesta.Error = "-";
                    respuesta.Iteraciones = contador.ToString();
                }
                else
                {
                    if (expresionxd.calculate() == expresionxi.calculate())
                    {
                        respuesta.Raiz = "-";
                        respuesta.Comentario = "No hay raiz";
                        respuesta.Converge = "No";
                        respuesta.Error = "-";
                        respuesta.Iteraciones = contador.ToString();
                    }
                    else
                    {
                        //double xr = (expresionxi.calculate() * xd - expresionxd.calculate() * xi) / (expresionxi.calculate() - expresionxd.calculate());
                        double xr = (expresionxd.calculate() * xi - expresionxi.calculate() * xd) / (expresionxd.calculate() - expresionxi.calculate());
                        contador += 1;
                        double error = CalcularError(xr, xAnt);
                        Expression nuevaExpresion = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                        ResultadoComprobacion resultado = ComprobarCondiciones(tolerancia, iteraciones, contador, nuevaExpresion, error);
                        while (resultado.Resultado != false)
                        {
                            xAnt = xr;
                            xd = xi;
                            xi = xr;

                            /*xAnt = xr;
                            xi = xd;
                            xd = xr;*/

                            expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                            expresionxd = new Expression("f(" + xd.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                            //xr = (expresionxi.calculate() * xd - expresionxd.calculate() * xi) / (expresionxi.calculate() - expresionxd.calculate());
                            xr = (expresionxd.calculate() * xi - expresionxi.calculate() * xd) / (expresionxd.calculate() - expresionxi.calculate());
                            contador += 1;
                            error = CalcularError(xr, xAnt);
                            nuevaExpresion = new Expression("f(" + xr.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                            resultado = ComprobarCondiciones(tolerancia, iteraciones, contador, nuevaExpresion, error);
                        }
                        
                        if (resultado.Comentario == "Se superó el número de iteraciones")
                        {
                            respuesta.Converge = "No";
                            respuesta.Raiz = "-";
                            respuesta.Comentario = resultado.Comentario;
                            respuesta.Error = "-";
                            respuesta.Iteraciones = contador.ToString();
                        }
                        else
                        {
                            respuesta.Converge = "Si";
                            respuesta.Raiz = xr.ToString("###0.0000");
                            respuesta.Comentario = resultado.Comentario;
                            respuesta.Error = error.ToString();
                            respuesta.Iteraciones = contador.ToString();
                        }
                    }
                }
            }
            return respuesta;
        }

        ////////////////////////////////////////////// Comprobación /////////////////////////////////
        private ResultadoComprobacion ComprobarCondiciones(double tolerancia, int iteraciones, int contador, Expression funcion, double error)
        {
            ResultadoComprobacion resultado = new ResultadoComprobacion();
            double valor = funcion.calculate();
            if (valor == 0)
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

        /////////////////////////////////// Cálculo error relativo //////////////////////////////////////
        private double CalcularError(double xr, double xAnt)
        {
            return (Math.Abs((xr - xAnt) / xr));
        }
    }
}
