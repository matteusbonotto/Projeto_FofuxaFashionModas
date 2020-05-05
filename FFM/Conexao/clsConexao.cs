using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Conexao
{
    class clsConexao
    {
        public MySqlCommand cmd;
        public MySqlConnection con;
        public string sGlob_Conexao;
        private string host = "localhost";
        private string database = "dbFofuxaFashion;";
        private string username = "root";
        private string password = "";

        public clsConexao()
        {
            string connectionString =
                "SERVER=" + host + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);
            sGlob_Conexao = connectionString;
        }

        public clsConexao(string host, string database, string username, string password)
        {
            string connectionString =
                "SERVER=" + host + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            // Inicializa uma conexão para realizar uma query.
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir conexão: " + ex.Message, "Erro");
                return false;
            }
        }
        private bool CloseConnection()
        {
            // Finaliza uma conexão após realizar uma query.
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão: " + ex.Message, "Erro");
                return false;
            }
        }

        public bool ExecutarQuery(string sqlQuery)
        {
            bool retorno = false;

            try
            {
                if (OpenConnection())
                {
                    cmd = new MySqlCommand(sqlQuery, con);
                    int resposta = cmd.ExecuteNonQuery();

                    if (resposta != 0)
                    {
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString(), "Erro ao executar query",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return retorno;
        }
        public DataTable ListarTabela(string sqlQuery)
        {
            DataTable tbRetorno = null;
            try
            {
                if (OpenConnection())
                {
                    cmd = new MySqlCommand(sqlQuery, con);

                    // Objeto de resposta padrão de uma execução de query
                    MySqlDataReader data = cmd.ExecuteReader();
                    List<string> registros = new List<string>();

                    // Convertendo o DataReader para um DataTable (formato de visualização melhor)
                    DataTable tbEsquema = data.GetSchemaTable();
                    tbRetorno = new DataTable();
                    if (data != null && tbEsquema != null)
                    {
                        // Criando as colunas
                        foreach (DataRow linha in tbEsquema.Rows)
                        {
                            if (!tbRetorno.Columns.Contains(linha["ColumnName"].ToString()))
                            {
                                DataColumn col = new DataColumn()
                                {
                                    ColumnName = linha["ColumnName"].ToString(),
                                    Unique = Convert.ToBoolean(linha["IsUnique"]),
                                    AllowDBNull = Convert.ToBoolean(linha["AllowDBNull"]),
                                    ReadOnly = Convert.ToBoolean(linha["IsReadOnly"])
                                };
                                tbRetorno.Columns.Add(col);
                            }
                        }

                        // Lendo linha a linha os registros da tabela de retorno
                        while (data.Read())
                        {
                            DataRow novaLinha = tbRetorno.NewRow();
                            // Populando as colunas de resposta com os valores do DB
                            for (int i = 0; i < tbRetorno.Columns.Count; i++)
                            {
                                novaLinha[i] = data.GetValue(i);
                            }
                            tbRetorno.Rows.Add(novaLinha);
                        }

                        data.Close();

                        for (int i = 0; i < registros.Count; i++)
                            Console.WriteLine(registros[i]);
                    }
                    CloseConnection();

                    // Tudo ocorreu corretamente e estamos retornando a tabela com as informações.
                    return tbRetorno;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Listar tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // A query não possuía uma resposta, então não se retorna nada.
            return null;
        }
    }
}
