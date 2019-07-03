using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CRUD_MySQL_CSharp_2.Classes.System;
using CRUD_MySQL_CSharp_2.Conexao.System;
using CRUD_MySQL_CSharp_2.Properties;

namespace CRUD_MySQL_CSharp_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Salvar(Livro L) {
            L = new Livro(txtNomeLivro.Text, txtAutor.Text, txtDescricao.Text);
            txtAutor.Text = L.Autor;
            txtDescricao.Text = L.Descricao;
            txtNomeLivro.Text = L.NomeLivro;
           
            L.Salvar(L);
        }

        private void bttSave_Click(object sender, EventArgs e) {
            Livro l = new Livro();
            Salvar(l);
        }
    }
}
