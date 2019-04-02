using System;

namespace Financiera2019.Dominio.Entidades
{
    public class MovimientoCuenta //: EntidadBase
    {
        public int NumeroMovimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public byte CodigoTipoOperacion { get; set; }
        public decimal MontoMovimiento { get; set; }
        public byte EstadoMovimiento { get; set; }
        public int IdentificadorCuenta { get; set; }
        virtual public CuentaAhorro Cuenta { get; set; }

        private MovimientoCuenta()
        {
        }
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
