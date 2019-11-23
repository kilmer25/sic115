using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicProyecto.Module.BusinessObjects
{
    

    class @enum
    {
        public enum RubrosContables
        {
            Pasivo,
            Activo,
            Patrimonio,
            Ingresos,
            Gastos,
            Resultados
        }
        public enum Saldo
        {
            Deudor,
            Acreedor
        }
        public enum TipoCuenta
        {
            Activo,
            Pasivo,
            Patrimonio,
            Ingreso,
            Gasto,
            Resultado
        }
        public enum EstadoPartidaContable
        {
            Borrador = 0,
            Mayorizada = 1,
            Anulada = 2
        }
        public enum TipoPartida
        {
            Ninguno = 0,
            Liquidacion = 1,
            CierreAnual = 2
        }
        public enum TipoDetalleEstadoFinanciero
        {
            Ingresos = 0,
            RebajasYDevoluciones = 1,
            CostoDeVenta = 2,
            Gastos = 3,
            GastosFinancieros = 4,
            OtrosIngresos = 5
        }
    }
}
