﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SicProyecto.Module.BusinessObjects.Chocoloat
{

    public partial class EstadoDeResultado : XPObject
    {
        Parametros fParametro;
        [Association(@"EstadoDeResultadoReferencesParametros")]
        public Parametros Parametro
        {
            get { return fParametro; }
            set { SetPropertyValue<Parametros>(nameof(Parametro), ref fParametro, value); }
        }
        CatalogoCuentas fCuenta;
        public CatalogoCuentas Cuenta
        {
            get { return fCuenta; }
            set { SetPropertyValue<CatalogoCuentas>(nameof(Cuenta), ref fCuenta, value); }
        }
        Module.BusinessObjects.SicEnum.TipoDetalleEstadoFinanciero fTipo;
        public Module.BusinessObjects.SicEnum.TipoDetalleEstadoFinanciero Tipo
        {
            get { return fTipo; }
            set { SetPropertyValue<Module.BusinessObjects.SicEnum.TipoDetalleEstadoFinanciero>(nameof(Tipo), ref fTipo, value); }
        }
    }

}