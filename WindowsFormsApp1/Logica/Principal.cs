using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using System.Globalization;
using System.Windows.Forms;

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

        /////////////////////////////////// Cálculo Gauss Jordan ////////////////////////////////////////
        public RespuestaUnidad2 CaclularGaussJordan(double [,] arreglo, int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                double coef= arreglo[i, i];
                for (int j = 0; j < tamaño+1; j++)
                {
                    arreglo[i, j] = arreglo[i, j] / coef;
                }
                for (int x = 0; x < tamaño; x++)
                {
                    if (i!=x)
                    {
                        coef = arreglo[x, i];
                        for (int k = 0; k < tamaño+1; k++)
                        {
                            arreglo[x, k] = arreglo[x, k] - (coef * arreglo[i, k]);
                        }
                    }
                }
            }
            List<double> listaResultado = ObtenerResultados(arreglo, tamaño);
            RespuestaUnidad2 respuesta = new RespuestaUnidad2();
            respuesta.Posible = true;
            respuesta.Iteraciones = 0;
            respuesta.Valores = listaResultado;
            return respuesta;
            //MessageBox.Show($"Resultados {arreglo[]}");
        }

        /////////////////////////////////////// Obtener resultados de matriz /////////////////////////////////////
        private List<double> ObtenerResultados(double[,] arreglo, int tamaño)
        {
            List<double> lista = new List<double>();
            for (int i = 0; i < tamaño; i++)
            {
                lista.Add(arreglo[i, tamaño]);
            }
            return lista;
        }

        //////////////////////////////////// Cálculo Gauss Seidel ///////////////////////////////////////

        public RespuestaUnidad2 CalcularGaussSeidel(double[,] arreglo, int tamaño, int iteraciones, double tolerancia)
        {
            RespuestaUnidad2 respuesta = new RespuestaUnidad2();
            double[] resultados = new double[tamaño];
            double [] vectorAnterior=new double[tamaño];
            double [] vectorResultado=new double[tamaño];
            int contador = 0;
            while(iteraciones>=contador)
            {
                contador = contador+1;
                if (contador>1)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }
                for (int i = 0; i < tamaño; i++)
                {
                    double resultado = arreglo[i,tamaño];
                    double x = Convert.ToDouble(arreglo[i, i]);
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (i!=j)
                        {
                            resultado = resultado - (arreglo[i, j] * vectorResultado[j]);
                        }
                    }
                    x = Convert.ToDouble(resultado) / x;
                    vectorResultado[i] = x;
                }
                for (int i = 0; i < tamaño; i++)
                {
                    resultados[i] = Math.Abs(vectorResultado[i] - vectorAnterior[i]);
                    if (resultados[i]<tolerancia)
                    {
                        respuesta.Comentario = "El valor es menor a la tolerancia";
                        respuesta.Posible = true;
                        respuesta.Iteraciones = contador;
                        respuesta.Valores = SacarValores(vectorResultado,tamaño);
                        return respuesta;
                    }
                }
            }
            respuesta.Comentario = "Se superó el número de iteraciones";
            respuesta.Posible = false;
            respuesta.Iteraciones = contador;
            respuesta.Valores = SacarValores(resultados,tamaño);
            return respuesta;
        }

        //////////////////////////////// Obtener valores de vector ///////////////////////////////////
        public List<double> SacarValores(double[] resultados, int tamaño)
        {
            List<double> listaResultados = new List<double>();
            for (int i = 0; i < tamaño; i++)
            {
                listaResultados.Add(resultados[i]);
            }
            return listaResultados;
        }

        //////////////////////////////// Cálculo regresión lineal //////////////////////////////////////
        
        public ResultadoUnidad3 CalcularRegresionLineal(double[,] datos, int conteo)
        {
            ResultadoUnidad3 resultado = new ResultadoUnidad3();
            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumXC = 0;
            for (int i = 0; i < conteo; i++)
            {
                sumX = sumX + datos[i, 0];
                sumY = sumY + datos[i, 1];
                sumXY = sumXY + (datos[i,0]*datos[i,1]);
                sumXC = sumXC + Math.Pow(datos[i,0],2);
            }
            double pendiente= ((conteo * sumXY) - (sumX * sumY)) / ((conteo * sumXC) - (Math.Pow(sumX,2)));
            double ordenada = (sumY - (pendiente * sumX)) / conteo;
            string funcion = ($"y = {pendiente.ToString("###0.0000")}x + ( {ordenada.ToString("###0.0000")} )");

            double Sr = 0;
            double St = 0;
            double mediaY = sumY / conteo;

            for (int i = 0; i < conteo; i++)
            {
                Sr += Math.Pow((pendiente * datos[i, 0]) + ordenada - datos[i, 1], 2);
                St +=Math.Pow(mediaY - datos[i, 1], 2);
            }

            //// da raíz negativa y por lo tanto muestra NAN
            //double r = Math.Sqrt((St - Sr) / St) * 100;
            
            double r= Math.Sqrt(Math.Abs((St - Sr) / St)) * 100;
            
            string condicion ="";
            string ajuste ="";

            if (r < 80)
            {
                ajuste =r.ToString("###0.0000");
                condicion = "El ajuste no es aceptable";
            }
            else
            {
                ajuste = r.ToString("###0.0000");
                condicion = "El ajuste es aceptable";
            }
            
            resultado.Funcion = funcion;
            resultado.Condicion = condicion;
            resultado.PorcentajeAjuste =ajuste;

            return resultado;

        }
        
        /////////////////////////////// Cálculo regresión polinomial //////////////////////////////////
        public ResultadoUnidad3 CalcularRegresionPolinomial(double[,] datos, int grado, int cantidad)
        {
            double[] Vx = new double[cantidad];
            double[] Vy = new double[cantidad];
            double sumX = 0;
            double sumY = 0;
            double[,] M = new double[grado+1,grado+2];
            for (int i = 0; i < cantidad; i++)
            {
                Vx[i] = datos[i,0];
                sumX += Vx[i];
                Vy[i] = datos[i, 1];
                sumY += Vy[i];
                for (int j = 0; j < grado+1; j++)
                {
                    for (int k = 0; k < grado+1; k++)
                    {
                        M[j, k] += Math.Pow(Vx[i], j + k);
                    }
                    M[j, grado+1] += Vy[i] * Math.Pow(Vx[i],j);
                }
            }
            RespuestaUnidad2 resultadoGaussJordan = CaclularGaussJordan(M, grado+1);
            string funcion = "y =";
            int contador = 0;
            double a1 = 0;
            double a0 = 0;
            foreach (var item in resultadoGaussJordan.Valores)
            {
                if (contador==0)
                {
                    funcion = funcion + $" {item}";
                    a0 = item;
                }
                else
                {
                    if (contador==1)
                    {
                        funcion = funcion + $" {item}x";
                        a1 = item;
                    }
                    else
                    {
                        funcion = funcion + $" {item}x^{contador}";
                    }
                }
                contador+=1; 
            }
            ResultadoUnidad3 resultado = new ResultadoUnidad3();
            resultado.Funcion = funcion;
            /*string ajuste = "";
            string condicion = "";
            double Sr = 0;
            double St = 0;
            
            for (int i = 0; i < cantidad; i++)
            {
               Sr += Math.Pow((a1 * datos[i, 0]) + a0 - datos[i, 1], 2);
               St += Math.Pow((sumY / cantidad) - datos[i, 1], 2);
            }

            double r = Math.Sqrt(Math.Abs((St - Sr) / St)) * 100;
            if (r < 80)
            {
                ajuste = r.ToString("###0.0000");
                condicion = "El ajuste no es aceptable";
            }
            else
            {
                ajuste = r.ToString("###0.0000");
                condicion = "El ajuste es aceptable";
            }
            */
            return resultado;
        }

        //////////////////////////////// Cálculo método del trapecio /////////////////////////////////
        public double CalcularMetodoTrapecio(double xi, double xf, Function f)
        {
            Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionxf = new Expression("f(" + xf.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            double funcionxi = expresionxi.calculate();
            double funcionxf = expresionxf.calculate();
            double area = ((funcionxi + funcionxf) * (xf - xi)) / 2;
            return area;
        }

        /////////////////////////////// Cálculo método del trapecio múltiples ///////////////////////
        
        public double CalcularMetodoTrapeciosMultiples(double xi, double xf, Function f, double n)
        {
            double h = (xf - xi) / n;
            double xh = xi+h;
            Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionxf = new Expression("f(" + xf.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            double funcionxi = expresionxi.calculate();
            double funcionxf = expresionxf.calculate();
            double a = 0;
            for (int i = 0; i < n-1; i++)
            {
                Expression expresionxh = new Expression("f(" + xh.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                double funcionxh = expresionxh.calculate();
                a = a + funcionxh;
                xh = xh + h;
            }
            double area = (h / 2) * (funcionxi+2*a+funcionxf);
            return area;
        }

        ////////////////////////////// Cálculo método Simpson 1/3 ////////////////////////////////////
        
        public double CalcularSimpson(double x0, double x2, Function f)
        {
            double x1 = (x0 + x2) / 2;
            Expression expresionx0 = new Expression("f(" + x0.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionx2 = new Expression("f(" + x2.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionx1 = new Expression("f(" + x1.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            double funcionx0 = expresionx0.calculate();
            double funcionx2 = expresionx2.calculate();
            double funcionx1 = expresionx1.calculate();
            double h = (x2 - x0) / 2;
            double area = (h/3) * (funcionx0 + 4 * funcionx1 + funcionx2);
            return area;
        }

        ////////////////////////////// Cálculo método Simpson 1/3 múltiples //////////////////////////
        
        public double CalcularSimpsonMultiple(double x0, double x2, Function f, double n)
        {
            
            Expression expresionx0 = new Expression("f(" + x0.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            Expression expresionx2 = new Expression("f(" + x2.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
            double funcionx0 = expresionx0.calculate();
            double funcionx2 = expresionx2.calculate();
            double h = (x2 - x0) / n;
            double xi= x0 + h;
            double xp= xi + h;
            double sumI = 0;
            double sumP = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Pow(-1,i)>0)
                {
                    Expression expresionxp = new Expression("f(" + xp.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                    double funcionxp = expresionxp.calculate();
                    sumP = sumP + funcionxp;
                    xp = xp + 2 * h;
                }
                else
                {
                    Expression expresionxi = new Expression("f(" + xi.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")", f);
                    double funcionxi = expresionxi.calculate();
                    sumI = sumI + funcionxi;
                    xi = xi + 2 * h;
                }
                
            }
            double area = (h / 3) * (funcionx0 + 4 * sumI +2*sumP+ funcionx2);
            return area;
        }
    }
}
