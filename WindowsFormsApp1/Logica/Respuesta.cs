using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Respuesta
    {
        
        public string Raiz { get; set; }
        public string Converge { get; set; }
        public string Comentario { get; set; }
        public string Error { get; set; }
        public string Iteraciones { get; set; }
        

        /*public Respuesta(string raiz, string comentario, string converge, string error, string iteraciones)
        {
            this.Raiz = raiz;
            this.Comentario = comentario;
            this.Converge = converge;
            this.Error = error;
            this.Iteraciones = iteraciones;
        }

        public Respuesta(bool resultado, string comentario)
        {
            this.Resultado = resultado;
            this.Comentario = comentario;
        }*/

    }
}
