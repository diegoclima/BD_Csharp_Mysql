using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD_MySQL_CSharp_2.Conexao.System {
    /// <summary>
    /// Classe de conexao com o bd
    /// </summary>
    public class BDConnect {
        
        private static string StringConexao = "DATABASE=biblioteca; SERVER=localhost; UID=root; PWD=";
        protected static MySqlConnection MysqlCon;
        protected static MySqlCommand Comando;
        public BDConnect() { }
        protected static void AbrirConexao() {
            try {
                MysqlCon = new MySqlConnection(StringConexao);
                
                MysqlCon.Open();

            }
            catch (Exception ex) {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        protected static void FecharConexao() {
            try {
                MysqlCon.Close();
            }
            catch (Exception ex) {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        //protected static int ComandoInsertDeleteUpdate(MySqlCommand comando) {
        //    int result = 0;
        //}

        
    }
}
