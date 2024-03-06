using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R24_JesusCG_V1
{
    public class CuentaJoven : Cuenta
    {

        // CONSTANTES

        private const float RETIRAAR_MAX = 500;
        private const byte EDAD_MIN = 18;
        private const byte EDAD_MAX = 26;

        // MÉTODOS

        /// <summary>
        /// ValidarFecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <exception cref="Exception"></exception>
        protected override void ValidarFecha(DateTime fecha)
        {
            base.ValidarFecha(fecha);

            // COMPROBAR SI es mayor de la esdad mímina permitida
           // if ((DateTime.Now.Year - fecha.Year) < EDAD_MIN) throw new Exception("Edad incorrecta");
             if (fecha < DateTime.Today.AddYears(-EDAD_MIN)) throw new Exception("Edad incorrecta");

             // AddYears Añdade años, en este caso resta, 6/3/2024 - 18 --> 6/3/2006, esa es la edad mínima

            // Comprobar si es menor de la edad máxima permitida
            // if ((DateTime.Now.Year - fecha.Year) > EDAD_MAX) throw new Exception("Edad incorrecta");
            if (fecha > DateTime.Today.AddYears(EDAD_MAX)) throw new Exception("Edad incorrecta");

        }


        /// <summary>
        /// Retirar
        /// </summary>
        /// <param name="importe"></param>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="ArithmeticException"></exception>
        public override void Retirar(double importe)
        {
            ValidarImporte(importe);

            // COMPROBAR LIMITE

            if (importe > RETIRAAR_MAX)
                throw new OverflowException($"Error: No piede ser superior a {RETIRAAR_MAX}");

            // Comprobar si tiene saldo
            if (importe > Cantidad) throw new ArithmeticException("Error, sin saldo");


            // Procesar la retirada de dinero
            _cantidad -= importe;
        }


    }
}
