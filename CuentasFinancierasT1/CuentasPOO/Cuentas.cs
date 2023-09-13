using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasFinancierasT1.CuentasPOO
{
    public class Cuentas
    {
        private int CuentaNum;
        private string Titular;
        private int Saldo;
        private string Moneda;
        private int Monto;
        public Cuentas(int _CuentaNum,string _Titular, int _Saldo, string _Moneda, int _Monto)
        {
            this.CuentaNum = _CuentaNum;
            this.Titular = _Titular;
            this.Saldo = _Saldo;
            this.Moneda = _Moneda;
            this.Monto = _Monto;
        }
        // Método Set para realizar un depósito.
        public void Depositar(int _Monto, int _Moneda)
        {
            if (_Moneda == 1)
            {
                Console.WriteLine("Hola Sr/sra  " + this.Titular + " Estás depositando en guaranies el siguiente monto: " + _Monto + "Gs");
                this.Saldo += _Monto;
                Console.WriteLine("Tu Saldo Actual es: " + Saldo + "Gs");
            }
            else if (_Moneda == 2)
            {
                Console.WriteLine("Hola Sr/sra  " + this.Titular + " Estás depositando en Dolares el siguiente monto: " + _Monto + "$");
                this.Saldo += _Monto;
                Console.WriteLine("Tu Saldo Actual es: " + Saldo + "$");
            }
            else
            {
                Console.WriteLine("El Tipo de Moneda debe ser 1 para Guaranies o 2 para Dolares.");
            }
        }
        // Método Get para retirar.
        public int Retirar(int _Monto, int _Moneda)
        {
            if ((_Monto > Saldo))
            {
                Console.WriteLine("Su monto supera al Saldo Actual que es:" + Saldo);
            }
            if ((_Moneda != 1 && _Moneda != 2))
            {

                Console.WriteLine("El Tipo de Moneda debe ser 1 para Guaranies o 2 para Dolares.");
            }
            else if (_Moneda == 1)
            {
                this.Saldo -= _Monto;
                Console.WriteLine("Haz Retirado el Siguiente monto: " + _Monto + "Gs" + " Tu Saldo Actual es: " + Saldo + "Gs");
            }
            else
            {
                this.Saldo -= _Monto;
                Console.WriteLine("Haz Retirado el Siguiente monto: " + _Monto + "$" + " Tu Saldo Actual es: " + Saldo + "$");
            }

            return _Monto;
        }

    }
}

