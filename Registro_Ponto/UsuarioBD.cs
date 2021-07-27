using MySql.Data.MySqlClient;

namespace Registro_Ponto
{
    class UsuarioBD
    {
        MySqlConnection conexao = ConexaoBD.getInstancia().getConexao();
    }
}
