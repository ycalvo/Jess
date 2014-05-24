using System;
using System.Data;
using TestDataBase.AccesoDatos;
using TestDataBase.CapaLogica.Postgres;
using TestDataBase.CapaLogica.SQL;

namespace TestDataBase.CapaLogica
{
    public class TestCl
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public ITestSql ObtenerInstancia()
        {
            ITestSql testSql = null;
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    break;
                case ContextDataBase.PostgreSql:
                    testSql = new TestPostgres();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return testSql;
        }


        public void Test(int toInt32)
        {
            ITestSql testSql = this.ObtenerInstancia();
            testSql.Test();
            if (testSql.IsError)
            {
                this.IsError = testSql.IsError;
                this.ErrorDescripcion = testSql.ErrorDescripcion;
            }
        }

        public void Test(int sno, int eid, DateTime sd, DateTime ed, int sid, bool status)
        {
            ITestSql testSql = this.ObtenerInstancia();
            testSql.Test(sno, eid, sd, ed, sid, status);
            if (testSql.IsError)
            {
                this.IsError = testSql.IsError;
                this.ErrorDescripcion = testSql.ErrorDescripcion;
            }
        }

        public void Eliminar_Test(int sno)
        {
            ITestSql testSql = this.ObtenerInstancia();
            testSql.Eliminar_Test(sno);
            if (testSql.IsError)
            {
                this.IsError = testSql.IsError;
                this.ErrorDescripcion = testSql.ErrorDescripcion;
            }
        }

        public DataSet GetInfo()
        {
            ITestSql testSql = this.ObtenerInstancia();
            DataSet info= testSql.GetInfo();
            if (testSql.IsError)
            {
                this.IsError = testSql.IsError;
                this.ErrorDescripcion = testSql.ErrorDescripcion;
            }
            return info;
        }

    }
}
