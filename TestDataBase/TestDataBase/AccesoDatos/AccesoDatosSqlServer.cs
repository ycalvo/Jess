using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace TestDataBase.AccesoDatos
{
    public class AccesoDatosSqlServer : IAccesoDatos
    {
        // Constructor
        public AccesoDatosSqlServer(String servidor, String usuario, String contrasena, String baseDatos)
        {
            this.LimpiarEstado();
            Conexion = new SqlConnection("Data Source=" + servidor + ";UID=" + usuario + ";PWD=" + contrasena + ";Initial Catalog=" + baseDatos);

            Instancias += 1;
            // no puede haber + de una instancia de la clase
            if (Instancias > 1)
                return;
            try
            {
                Conexion.Open();
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error de Conexión \n";
                ErrorDescripcion += error.Message;
                Instancias = 0;
            }
        }

        // destructor
        ~AccesoDatosSqlServer()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error de Desconexión \n";
                ErrorDescripcion += error.Message;
            }
        }

        #region Métodos de conexion

        // Indica el estado de la persistencia
        public Boolean Estado()
        {
            string mensaje = "";
            this.LimpiarEstado();
            // estado dela conexión
            switch (Conexion.State)
            {
                case System.Data.ConnectionState.Broken: mensaje = "Quebrada";
                    break;
                case System.Data.ConnectionState.Closed: mensaje = "Cerrada";
                    break;
                case System.Data.ConnectionState.Connecting: mensaje = "Conectandose";
                    break;
                case System.Data.ConnectionState.Executing: mensaje = "Ejecutando";
                    break;
                case System.Data.ConnectionState.Fetching: mensaje = "Extrayendo";
                    break;
                case System.Data.ConnectionState.Open: mensaje = "Abierta";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            ErrorDescripcion = mensaje;

            if ((Conexion.State == ConnectionState.Open) ||
                  (Conexion.State == ConnectionState.Executing) ||
                  (Conexion.State == ConnectionState.Fetching))
                return true;
            return false;
        }

        public DataSet EjecutarConsultaSql(String sql)
        {
            this.LimpiarEstado();
            var oDataSet = new DataSet();
            try
            {
                var oDataAdapter = new SqlDataAdapter(sql, Conexion);
                if (this.HayTransaccion)
                {
                    oDataAdapter.SelectCommand.Transaction = this.Transaccion;
                }
                oDataAdapter.Fill(oDataSet);
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarConsultaSQL \n";
                ErrorDescripcion += error.Message;
            }
            return oDataSet;
        }

        public DataSet EjecutarConsultaSql(String sql, IEnumerable parametros)
        {
            this.LimpiarEstado();
            var oDataSet = new DataSet();
            try
            {
                var oDataAdapter = new SqlDataAdapter(sql, Conexion);
                var cmd = new SqlCommand(sql, Conexion);
                foreach (SqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
                oDataAdapter.SelectCommand = cmd;

                if (this.HayTransaccion)
                {
                    oDataAdapter.SelectCommand.Transaction = this.Transaccion;
                }
                oDataAdapter.Fill(oDataSet);
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarConsultaSQL \n";
                ErrorDescripcion += error.Message;
            }
            return oDataSet;
        }

        public void EjecutarSql(string sql, IEnumerable parametros)
        {
            try
            {
                this.LimpiarEstado();
                var cmd = new SqlCommand(sql, Conexion);
                foreach (SqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
                if (this.HayTransaccion)
                {
                    cmd.Transaction = this.Transaccion;
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarSQL \n";
                ErrorDescripcion += error.Message;
            }
        }

        // Método para manipular DQL (Select) Para busquedas escalares SUM(), Count(), Etc.
        public Int32 EjecutarScalarSql(String pSql)
        {
            int resultado = 0;
            var cmd = new SqlCommand(pSql, Conexion);
            this.IsError = false;

            // capturar la excepción
            try
            {
                resultado = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarConsultaSQL \n";
                ErrorDescripcion += error.Message;
            }
            return resultado;
        }

        // Método para manipular DQL (Select) Exclusivo para carga de listas y combos
        public DataSet EjecutarSqlListas(String sql, String tabla)
        {
            var vDatos = new SqlDataAdapter(sql, Conexion);
            var dsTabla = new DataSet();
            this.IsError = false;

            // capturar la excepción
            try
            {
                vDatos.Fill(dsTabla, tabla);

            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarConsultaSQL \n";
                ErrorDescripcion += error.Message;
            }
            return dsTabla;
        }

        #endregion

        #region Set & Gets

        public Boolean IsError { set; get; }

        public String ErrorDescripcion { set; get; }

        public static int Instancias { set; get; }

        public bool HayTransaccion { set; get; }

        public SqlTransaction Transaccion { set; get; }

        public SqlConnection Conexion { set; get; }

        #endregion

        #region Métodos de la clase

        public ContextDataBase ContextDataBase
        {
            get { return ContextDataBase.SqlServer; }
        }

        public void LimpiarEstado()
        {
            this.ErrorDescripcion = "";
            this.IsError = false;
        }

        public void IniciarTransaccion()
        {
            if (this.HayTransaccion == false)
            {
                this.Transaccion = this.Conexion.BeginTransaction();
                this.HayTransaccion = true;
            }
        }

        public void CommitTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Commit();
                this.HayTransaccion = false;
            }
        }

        public void RollbackTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Rollback();
                this.HayTransaccion = false;
            }
        }

        #endregion
    }
}