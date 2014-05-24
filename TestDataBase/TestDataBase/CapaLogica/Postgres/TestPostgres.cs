using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using NpgsqlTypes;
using Npgsql;
using TestDataBase.CapaLogica.SQL;

namespace TestDataBase.CapaLogica.Postgres
{
    public class TestPostgres : ITestSql
    {
        public bool IsError { get; set; }
        public string ErrorDescripcion { get; set; }


        public void Test()
        {
            var sql = new StringBuilder();

            sql.AppendLine(" select * from MyInsert(@param1,@param2,@param4,@param5,@param6,@param7) ");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "param1",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  3
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param2",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = 3
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param4",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = DateTime.Now
                        }
                       ,
                        new NpgsqlParameter
                            {
                            ParameterName = "param5",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = DateTime.Now
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param6",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = 44
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param7",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                            NpgsqlValue = false
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSql(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void Test(int sno, int eid, DateTime sd, DateTime ed, int sid, bool status)
        {
            var sql = new StringBuilder();

            sql.AppendLine(" select * from MyInsert(@param1,@param2,@param4,@param5,@param6,@param7) ");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "param1",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  sno
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param2",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = eid
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param4",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = sd
                        }
                       ,
                        new NpgsqlParameter
                            {
                            ParameterName = "param5",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = ed
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param6",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = sid
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "param7",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                            NpgsqlValue = status
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSql(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }


        public void Eliminar_Test(int sno)

        {
            var sql = new StringBuilder();

            sql.AppendLine(" select * from Mydelete(@param1)");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "param1",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  sno
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSql(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }
        public DataSet GetInfo()
        {

            var sql = new StringBuilder();

            sql.AppendLine(" select * from app_for_leave");

            DataSet datos= AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSql(sql.ToString());
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
            return datos;
        }
    }
}
