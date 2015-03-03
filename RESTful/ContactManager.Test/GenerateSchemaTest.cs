using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using ContactManager.Models;
using NHibernate.Tool.hbm2ddl;

namespace ContactManager.Test
{
    [TestClass]
    public class GenerateSchemaTest
    {
        [TestMethod]
        public void CanGenerateSchema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Product).Assembly);

            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}
