using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SicProyecto.Module.BusinessObjects.Chocoloat
{

    public partial class SaldoCuentas
    {
        public SaldoCuentas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
