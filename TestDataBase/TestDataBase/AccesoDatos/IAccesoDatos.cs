using System;
using System.Collections;
using System.Data;

namespace TestDataBase.AccesoDatos
{
    public interface IAccesoDatos
    {
        #region Métodos de conexion

        // Indica el estado de la persistencia
        Boolean Estado();

        DataSet EjecutarConsultaSql(String sql);

        DataSet EjecutarConsultaSql(String sql, IEnumerable parametros);

        void EjecutarSql(string sql, IEnumerable parametros);

        // Método para manipular DQL (Select) Para busquedas escalares SUM(), Count(), Etc.
        Int32 EjecutarScalarSql(String pSql);

        // Método para manipular DQL (Select) Exclusivo para carga de listas y combos
        DataSet EjecutarSqlListas(String sql, String tabla);

        #endregion

        #region Set & Gets

        Boolean IsError { set; get; }

        String ErrorDescripcion { set; get; }

        bool HayTransaccion { set; get; }

        ContextDataBase ContextDataBase { get; }

        #endregion

        #region Métodos de la clase

        void LimpiarEstado();

        void IniciarTransaccion();

        void CommitTransaccion();

        void RollbackTransaccion();

        #endregion
    }
}