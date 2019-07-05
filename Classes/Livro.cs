using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_MySQL_CSharp_2.Classes.System;
using CRUD_MySQL_CSharp_2.Conexao.System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRUD_MySQL_CSharp_2.Classes.System {
    public class Livro : BDConnect {
       
        private string nomeLivro;
        private string autor;
        private string descricao;
        private List<Livro> livros;
        private int idLivro;
        private string search;
        public Livro() { }
        public Livro(string nomeLivro, string autor, string descricao) {
            this.NomeLivro = nomeLivro;
            this.Autor = autor;
            this.Descricao = descricao;
        }
        public Livro(int id) {
            IdLivro = id;
        }
        public Livro(string nomeLivro, string autor, string descricao, string procurar) {
            this.NomeLivro = nomeLivro;
            this.Autor = autor;
            this.Descricao = descricao;
            this.Search = procurar;
        }
        public Livro(string proc) {
            this.Search = proc;
        }


        public string NomeLivro { get => nomeLivro; set => nomeLivro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public List<Livro> Livros { get => livros; set => livros = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public string Search { get => search; set => search = value; }

        public void Salvar(Livro l) {
            BDConnect.AbrirConexao();
            Comando = new MySql.Data.MySqlClient.MySqlCommand("livroAddEdit", MysqlCon);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("_livroID", l.IdLivro);
            Comando.Parameters.AddWithValue("_nomeLivro", l.NomeLivro);
            Comando.Parameters.AddWithValue("_Descricao", l.Descricao);
            Comando.Parameters.AddWithValue("_Autor", l.Autor);

            Comando.ExecuteNonQuery();
            MessageBox.Show("Livro Salvo com Sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            BDConnect.FecharConexao();
        }
        
       public DataTable Listar() {
            try {
                BDConnect.AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("livroView", MysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.Fill(dt);
                return dt;


            }
            catch (Exception ex) {

                throw new Exception("Erro " + ex.Message);
            }
            finally {
                BDConnect.FecharConexao();
            }


        }

        //public void Editar(Livro l) {
        //    BDConnect.AbrirConexao();
        //    Comando = new MySqlCommand("livroAddEdit", MysqlCon);

        //    Comando.CommandType = CommandType.StoredProcedure;
        //    Comando.Parameters.AddWithValue("_livroID", l.IdLivro);
        //    Comando.Parameters.AddWithValue("_nomeLivro", l.NomeLivro);
        //    Comando.Parameters.AddWithValue("_Descricao", l.Descricao);
        //    Comando.Parameters.AddWithValue("_Autor", l.Autor);

        //    Comando.ExecuteNonQuery();
        //    MessageBox.Show("Livro Salvo com Sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //    BDConnect.FecharConexao();
        //}
        public void Pesquisar(Livro l) {
            try {
                BDConnect.AbrirConexao();
                 Comando = new MySqlCommand("livroSearchByValue", MysqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("_procuraPorValor", Search);
                Comando.ExecuteNonQuery();
                
                BDConnect.FecharConexao();
                

            }
            catch (Exception ex) {

                throw ex;
            }
        } 

        public void Excluir(Livro L) {
           
                Livro l = new Livro();
                l.IdLivro = IdLivro;
                BDConnect.AbrirConexao();
                Comando = new MySql.Data.MySqlClient.MySqlCommand("livroDeleteByID", MysqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("_livroID", l.IdLivro);
                //Comando.Parameters.AddWithValue("_nomeLivro", l.NomeLivro);
                //Comando.Parameters.AddWithValue("_Descricao", l.Descricao);
                //Comando.Parameters.AddWithValue("_Autor", l.Autor);

                Comando.ExecuteNonQuery();
                MessageBox.Show("Livro excluido com Sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BDConnect.FecharConexao();
         
        }

        public void BuscarLivro(Livro L) {
            try {
                BDConnect.AbrirConexao();

                Comando = new MySqlCommand("livroDeleteById", MysqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Clear();
            }
            catch (Exception ex) {

                throw ex;
            }
        }

    }
}
