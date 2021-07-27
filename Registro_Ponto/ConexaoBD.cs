﻿using System.Configuration;
using MySql.Data.MySqlClient;

namespace Registro_Ponto
{
    class ConexaoBD
    {
        private static readonly ConexaoBD instanciaMySQL = new ConexaoBD();

        public static ConexaoBD getInstancia()
        {
            return instanciaMySQL;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
