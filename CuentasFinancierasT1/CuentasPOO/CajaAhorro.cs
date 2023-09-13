using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasFinancierasT1.CuentasPOO
{
    public class CajaAhorro : Cuentas
    {
        private int LimiteDiario;
        private string TipoCuentaCorriente;
        public CajaAhorro(int _CuentaNum, 
            string _Titular, int _Saldo,
            string _Moneda, int _Monto,
            int _LimiteDiario,
            string _TipoCuentaCorriente ) :base(_CuentaNum: _CuentaNum,
                                                _Titular: _Titular,
                                                _Saldo: _Saldo,
                                                _Moneda: _Moneda,
                                                _Monto: _Monto)
        {
          this.LimiteDiario = _LimiteDiario;
          this.TipoCuentaCorriente = _TipoCuentaCorriente;

        }
    }
}