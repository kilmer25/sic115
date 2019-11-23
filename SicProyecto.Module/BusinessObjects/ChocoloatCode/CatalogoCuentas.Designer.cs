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

    public partial class CatalogoCuentas : XPObject
    {
        string fCuentaContable;
        public string CuentaContable
        {
            get { return fCuentaContable; }
            set { SetPropertyValue<string>(nameof(CuentaContable), ref fCuentaContable, value); }
        }
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        CatalogoCuentas fCuentaPadre;
        [Association(@"CatalogoCuentasReferencesCatalogoCuentas")]
        public CatalogoCuentas CuentaPadre
        {
            get { return fCuentaPadre; }
            set { SetPropertyValue<CatalogoCuentas>(nameof(CuentaPadre), ref fCuentaPadre, value); }
        }
        Module.BusinessObjects.SicEnum.TipoCuenta fTipoCuenta;
        public Module.BusinessObjects.SicEnum.TipoCuenta TipoCuenta
        {
            get { return fTipoCuenta; }
            set { SetPropertyValue<Module.BusinessObjects.SicEnum.TipoCuenta>(nameof(TipoCuenta), ref fTipoCuenta, value); }
        }
        Module.BusinessObjects.SicEnum.Saldo fSaldo;
        public Module.BusinessObjects.SicEnum.Saldo Saldo
        {
            get { return fSaldo; }
            set { SetPropertyValue<Module.BusinessObjects.SicEnum.Saldo>(nameof(Saldo), ref fSaldo, value); }
        }
        Module.BusinessObjects.SicEnum.RubrosContables fRubro;
        public Module.BusinessObjects.SicEnum.RubrosContables Rubro
        {
            get { return fRubro; }
            set { SetPropertyValue<Module.BusinessObjects.SicEnum.RubrosContables>(nameof(Rubro), ref fRubro, value); }
        }
        [Association(@"CatalogoCuentasReferencesCatalogoCuentas")]
        public XPCollection<CatalogoCuentas> CatalogoCuentasCollection { get { return GetCollection<CatalogoCuentas>(nameof(CatalogoCuentasCollection)); } }
    }

}