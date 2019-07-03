using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_MySQL_CSharp_2.Classes.System;
using CRUD_MySQL_CSharp_2.Conexao.System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_MySQL_CSharp_2.Classes.System {
    public class Livro : BDConnect {
        private string nomeLivro;
        private string autor;
        private string descricao;
        private List<Livro> livros;
        private int idLivro;
        public Livro() { }
        public Livro(string nomeLivro, string autor, string descricao) {
            this.NomeLivro = nomeLivro;
            this.Autor = autor;
            this.Descricao = descricao;
        }

        public string NomeLivro { get => nomeLivro; set => nomeLivro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public List<Livro> Livros { get => livros; set => livros = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }

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


        
       
    }
}
