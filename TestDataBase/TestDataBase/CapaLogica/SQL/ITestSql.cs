using System;
using System.Data;

namespace TestDataBase.CapaLogica.SQL
{
    public interface ITestSql
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql
        
        void Test();

        void Test(int sno,int eid ,DateTime sd,DateTime ed ,int sid , bool status);
        void Eliminar_Test(int sno);
        DataSet GetInfo();

        #endregion
    }
}
