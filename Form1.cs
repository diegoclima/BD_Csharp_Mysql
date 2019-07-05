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
        int livroID;
        public Form1() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            Listar();
            LimparCampos();
        }
        public void LimparCampos() {

            //txtMatricula.Clear();
            txtNomeLivro.Clear();
            txtDescricao.Clear();
            txtProcurar.Clear();
            txtAutor.Clear();
            txtDescricao.Clear();
            txtAutor.BackColor = Color.White;
            txtDescricao.BackColor = Color.White;
            txtNomeLivro.BackColor = Color.White;
           // txtMatricula.BackColor = Color.White;
            livroID = 0;
            bttSave.Text = "Salvar";


        }
        private void Salvar(Livro L) {
            if ((txtAutor.Text.Trim() == string.Empty) || (txtNomeLivro.Text == string.Empty)) {
                MessageBox.Show("Campos obrigatórios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeLivro.BackColor = Color.Yellow;
                txtAutor.BackColor = Color.Yellow;
            }
            else {
                L = new Livro(txtNomeLivro.Text, txtAutor.Text, txtDescricao.Text);
                txtAutor.Text = L.Autor;
                txtDescricao.Text = L.Descricao;
                txtNomeLivro.Text = L.NomeLivro;
               
                L.Salvar(L);
                LimparCampos();
                Listar();
            }
            
        }

        private void Excluir(Livro L) {
            //if ((txtAutor.Text.Trim() == string.Empty) || (txtNomeLivro.Text == string.Empty)) {
            //    MessageBox.Show("Campos obrigatórios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtNomeLivro.BackColor = Color.Yellow;
            //    txtAutor.BackColor = Color.Yellow;
            //}
            //else {
                Livro livro = new Livro(livroID);
               
                livro.Excluir(L);
              //  MessageBox.Show("Livro Excluído com Sucesso!");
                Listar();

            //}
        }

        private void bttSave_Click(object sender, EventArgs e) {
            Livro l = new Livro();
            Salvar(l);
            Listar();
        }

        private void Listar() {
            Livro l = new Livro();
            d_gGrid.DataSource = l.Listar();
            d_gGrid.Columns[1].HeaderText = "Nome do Livro";
            d_gGrid.Columns[2].HeaderText = "Autor";
            d_gGrid.Columns[3].HeaderText = "Descrição";
            d_gGrid.Columns[0].Visible = false;
            d_gGrid.Columns[1].Width = 200;
            d_gGrid.Columns[2].Width = 200;
            d_gGrid.Columns[3].Width = 200;


        }
        private void d_gGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Livro l = new Livro();
            l.Listar();

        }

        //private void d_gGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

           
           
        //  //  txtProcurar.Text = d_gGrid.CurrentRow.Cells[4].Value.ToString().ToUpperInvariant();
            
                
        //}

        //private void Editar(Livro L) {
        //    if ((txtAutor.Text.Trim()==string.Empty)||(txtNomeLivro.Text == string.Empty)) {
        //        MessageBox.Show("Campos obrigatórios!","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtNomeLivro.BackColor = Color.Yellow;
        //        txtAutor.BackColor = Color.Yellow;
        //    }
        //    else {
        //        L.Autor = txtAutor.Text;
        //        L.NomeLivro = txtNomeLivro.Text;
        //        L.Editar(L);
        //        MessageBox.Show("Dados alterados com sucesso!");
        //        Listar();

        //    }

        //    L = new Livro(txtNomeLivro.Text, txtAutor.Text, txtDescricao.Text);
        //    txtAutor.Text = L.Autor;
        //    txtDescricao.Text = L.Descricao;
        //    txtNomeLivro.Text = L.NomeLivro;
        //    L.Editar(L);
        //   // L.Salvar(L);
        //    L.Listar();
        //}

        //private void bttEdit_Click(object sender, EventArgs e) {
        //    Livro l = new Livro();
        //    Editar(l);
        //}

        private void bttCancelar_Click(object sender, EventArgs e) {
            LimparCampos();
            livroID = 0;
            bttSave.Text = "Salvar";
            bttDelete.Enabled = false;
            
        }
        /// <summary>
        /// Ao clicar 2x no gridView irá para atualizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        //private void d_gGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        //    if (d_gGrid.CurrentRow.Index != -1) {
        //        //  txtMatricula.Text = d_gGrid.CurrentRow.Cells[0].Value.ToString();
        //        txtNomeLivro.Text = d_gGrid.CurrentRow.Cells[1].Value.ToString();
        //        txtAutor.Text = d_gGrid.CurrentRow.Cells[2].ToString().ToUpper();
        //        txtDescricao.Text = d_gGrid.CurrentRow.Cells[3].ToString();
        //        livroID = Convert.ToInt32(d_gGrid.CurrentRow.Cells[0].Value.ToString());
        //        bttSave.Text = "Update";

        //    }
        //}

        private void Form1_Load(object sender, EventArgs e) {
            LimparCampos();
            Listar();
        }

        //private void d_gGrid_DoubleClick(object sender, EventArgs e) {
            
        //        //  txtMatricula.Text = d_gGrid.CurrentRow.Cells[0].Value.ToString();
               

            
        //}

        private void d_gGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            if (d_gGrid.CurrentRow.Index != -1) {
                txtNomeLivro.Text = d_gGrid.CurrentRow.Cells[1].Value.ToString();
                txtAutor.Text = d_gGrid.CurrentRow.Cells[2].Value.ToString().ToUpperInvariant();
                txtDescricao.Text = d_gGrid.CurrentRow.Cells[3].Value.ToString().ToUpperInvariant();
               // livroID = int.Parse(txtID.Text);
               livroID = Convert.ToInt32(d_gGrid.CurrentRow.Cells[0].Value.ToString());
               
                bttSave.Text = "Editar";
                bttDelete.Enabled = Enabled;
            }
            
        }

        private void bttDelete_Click(object sender, EventArgs e) {
           
            
            Livro l = new Livro(livroID);
            Excluir(l);
            LimparCampos();
        }

        private void Pesquisar(Livro l) {
            Livro livro = new Livro(txtProcurar.Text);
            livro.Search = txtProcurar.Text;
            
            livro.Pesquisar(l);
           
        }

        private void bttProcurar_Click(object sender, EventArgs e) {
            Livro l = new Livro(txtNomeLivro.Text);
            Pesquisar(l);
        }

        //private void button4_Click(object sender, EventArgs e) {
        //    Livro l = new Livro();
        //    l.Pesquisar(l);
        //}
    }
}
