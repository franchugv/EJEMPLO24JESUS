using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R24_JesusCG_V1
{
    public class CuentaOro : Cuenta
    {


        private const float RETIRAAR_MAX = 1000;
        private const byte EDAD_MIN = 26;

        public override void Retirar(double importe)
        {

            ValidarImporte(importe);

            if (importe > RETIRAAR_MAX)
                throw new OverflowException($"Error: No piede ser superior a {RETIRAAR_MAX}");

            // Comprobar si tiene saldo
            if (importe > Cantidad) throw new ArithmeticException("Error, sin saldo");


            // Procesar la retirada de dinero
            _cantidad -= importe;

        }


        protected override void ValidarFecha(DateTime fecha)
        {
            base.ValidarFecha(fecha);

            // COMPROBAR SI es mayor de la esdad mímina permitida
            if (fecha < DateTime.Today.AddYears(-EDAD_MIN)) throw new Exception("Edad incorrecta");

          

        }
    }
}
