using System;
using System.Collections.Generic;

namespace Financiera2019.Dominio.Entidades
{
    public class CuentaAhorro //: EntidadBase
    {
        public int IdentificadorCuenta { get; private set; }
        public string NumeroCuenta { get; private set; }
        public int CodigoCliente { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime FechaApertura { get; private set; }
        public byte EstadoCuenta { get; private set; }
        public virtual Cliente Propietario { get; private set; }
        public virtual ICollection<MovimientoCuenta> Movimientos { get; private set; }

        public CuentaAhorro()
        {
            Movimientos = new List<MovimientoCuenta>();
        }

        public static CuentaAhorro Aperturar(string asNumeroCuenta, Cliente aoCliente)
        {
            var cuenta = new CuentaAhorro()
            {
                NumeroCuenta = asNumeroCuenta,
                Propietario = aoCliente,
                CodigoCliente = aoCliente.CodigoCliente,
                Saldo = 0.00M,
                FechaApertura = DateTime.Now,
                EstadoCuenta = 0
            };
            var movimiento = MovimientoCuenta.Generar(1, 0.00M, cuenta);
            cuenta.Movimientos.Add(movimiento);
            return cuenta;
        }
        public void Activar()
        {
            EstadoCuenta = 1;
            var movimiento = MovimientoCuenta.Generar(2, 0.00M, this);
            Movimientos.Add(movimiento);
        }
        public void Bloquear()
        {
            EstadoCuenta = 2;
            var movimiento = MovimientoCuenta.Generar(3, 0.00M, this);
            Movimientos.Add(movimiento);
        }
        public void Desbloquear()
        {
            EstadoCuenta = 1;
            var movimiento = MovimientoCuenta.Generar(4, 0.00M, this);
            Movimientos.Add(movimiento);
        }
        public void Cancelar()
        {
            EstadoCuenta = 3;
            var movimiento = MovimientoCuenta.Generar(5, Saldo, this);
            Movimientos.Add(movimiento);
            Saldo = 0.00M;
        }
        public void Depositar(decimal adcMonto)
        {
            Saldo += adcMonto;
            var movimiento = MovimientoCuenta.Generar(6, adcMonto, this);
            Movimientos.Add(movimiento);
        }
        public void Retirar(decimal adcMonto)
        {
            Saldo -= adcMonto;
            var movimiento = MovimientoCuenta.Generar(7, adcMonto, this);
            Movimientos.Add(movimiento);
        }
    }
}
