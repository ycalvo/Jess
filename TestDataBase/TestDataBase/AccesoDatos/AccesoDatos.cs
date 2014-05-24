using System;
using System.Configuration;

namespace TestDataBase.AccesoDatos
{
    public class AccesoDatos
    {
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<AccesoDatos> instance = new Lazy<AccesoDatos>(() => new AccesoDatos());
        public IAccesoDatos accesoDatos;

        // Constructor privado para evitar la instanciación directa
        private AccesoDatos()
        {
            ContextDataBase contextDataBase;
            Enum.TryParse(ConfigurationManager.AppSettings["ContextDataBase"], out contextDataBase);

            switch (contextDataBase)
            {
                case ContextDataBase.SqlServer:
                    accesoDatos = new AccesoDatosSqlServer(
                        ConfigurationManager.AppSettings["Server"],
                        ConfigurationManager.AppSettings["Usuario"],
                        ConfigurationManager.AppSettings["Password"],
                        ConfigurationManager.AppSettings["Database"]
                        );

                    break;
                case ContextDataBase.PostgreSql:
                    accesoDatos = new AccesoDatosPostgreSql(
                        ConfigurationManager.AppSettings["Server"],
                        ConfigurationManager.AppSettings["Puerto"],
                        ConfigurationManager.AppSettings["Usuario"],
                        ConfigurationManager.AppSettings["Password"],
                        ConfigurationManager.AppSettings["Database"]
                        );
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        // Propiedad para acceder a la instancia
        public static AccesoDatos Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}