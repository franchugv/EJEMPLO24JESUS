using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R24_JesusCG_V1
{
    public class CuentaPlatino : Cuenta
    {


        private const float SALDO_MIN = 100000;
        private const byte EDAD_MIN = 26;



        public override void Retirar(double importe)
        {
            ValidarImporte(importe);

            if (importe > (Cantidad - SALDO_MIN)) throw new Exception();

            _cantidad -= importe;
        }

    }
}
