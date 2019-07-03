namespace CRUD_MySQL_CSharp_2 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.d_gGrid = new System.Windows.Forms.DataGridView();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.bttEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.d_gGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Livro :";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(96, 83);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(156, 20);
            this.txtNomeLivro.TabIndex = 3;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(1, 269);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 8;
            this.bttSave.Text = "Salvar";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // d_gGrid
            // 
            this.d_gGrid.AllowUserToAddRows = false;
            this.d_gGrid.AllowUserToDeleteRows = false;
            this.d_gGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_gGrid.Location = new System.Drawing.Point(322, 103);
            this.d_gGrid.Name = "d_gGrid";
            this.d_gGrid.ReadOnly = true;
            this.d_gGrid.Size = new System.Drawing.Size(477, 189);
            this.d_gGrid.TabIndex = 3;
            this.d_gGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_gGrid_CellContentClick);
            this.d_gGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_gGrid_CellDoubleClick);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(96, 131);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(156, 20);
            this.txtAutor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autor :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(78, 188);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(174, 61);
            this.txtDescricao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição : ";
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(159, 269);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 9;
            this.bttDelete.Text = "Excluir";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(240, 269);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 10;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(258, 33);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(304, 20);
            this.txtProcurar.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Procurar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Livro:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(100, 51);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(53, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(78, 269);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 13;
            this.bttEdit.Text = "Editar";
            this.bttEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 341);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d_gGrid);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MySQL CRUD APP";
            ((System.ComponentModel.ISupportInitialize)(this.d_gGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.DataGridView d_gGrid;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button bttEdit;
    }
}

