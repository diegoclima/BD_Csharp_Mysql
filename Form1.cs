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
            Listar();
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
            Listar();
        }

        private void Listar() {
            Livro l = new Livro();
            d_gGrid.DataSource = l.Listar();
            d_gGrid.Columns[0].HeaderText = "Id Livro";
            d_gGrid.Columns[1].HeaderText = "Nome do Livro";
            d_gGrid.Columns[2].HeaderText = "Autor";
        }
        private void d_gGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Livro l = new Livro();
            l.Listar();

        }

        private void d_gGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
           txtMatricula.Text = d_gGrid.CurrentRow.Cells[0].Value.ToString();
            txtNomeLivro.Text = d_gGrid.CurrentRow.Cells[1].Value.ToString().ToUpperInvariant();
            txtAutor.Text = d_gGrid.CurrentRow.Cells[2].ToString().ToUpper().ToUpperInvariant();
            txtDescricao.Text = d_gGrid.CurrentRow.Cells[3].ToString().ToUpperInvariant();
            txtProcurar.Text = d_gGrid.CurrentRow.Cells[4].Value.ToString().ToUpperInvariant();
            
                
        }

        private void Editar(Livro L) {
            L = new Livro(txtNomeLivro.Text, txtAutor.Text, txtDescricao.Text);
            txtAutor.Text = L.Autor;
            txtDescricao.Text = L.Descricao;
            txtNomeLivro.Text = L.NomeLivro;
            L.Salvar(L);
        }
    }
}
