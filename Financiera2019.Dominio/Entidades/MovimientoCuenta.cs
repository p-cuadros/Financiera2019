using System;

namespace Financiera2019.Dominio.Entidades
{
    public class MovimientoCuenta //: EntidadBase
    {
        public int NumeroMovimiento { get; private set; }
        public DateTime FechaMovimiento { get; private set; }
        public byte CodigoTipoOperacion { get; private set; }
        public decimal MontoMovimiento { get; private set; }
        public byte EstadoMovimiento { get; private set; }
        public int IdentificadorCuenta { get; private set; }
        public virtual CuentaAhorro Cuenta { get; private set; }

        public static MovimientoCuenta Generar(byte abyCodigoTipoOperacion, decimal adcMontoOperacion, CuentaAhorro aoCuenta)
        {
            return new MovimientoCuenta()
            {
                FechaMovimiento = DateTime.Now,
                CodigoTipoOperacion = abyCodigoTipoOperacion,
                MontoMovimiento = adcMontoOperacion,
                EstadoMovimiento = 0,
                Cuenta = aoCuenta,
                IdentificadorCuenta = aoCuenta.IdentificadorCuenta
            };
        }
    }
}
