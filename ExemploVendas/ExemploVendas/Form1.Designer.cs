namespace ExemploVendas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblDescricaoProd = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimparItens = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.nudQtdRemover = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRemover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(27, 28);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(61, 13);
            this.lblCodCli.TabIndex = 0;
            this.lblCodCli.Text = "Cod Cliente";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(134, 28);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(70, 13);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome Cliente";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(27, 114);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(66, 13);
            this.lblCodProd.TabIndex = 2;
            this.lblCodProd.Text = "Cod Produto";
            // 
            // lblDescricaoProd
            // 
            this.lblDescricaoProd.AutoSize = true;
            this.lblDescricaoProd.Location = new System.Drawing.Point(134, 114);
            this.lblDescricaoProd.Name = "lblDescricaoProd";
            this.lblDescricaoProd.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoProd.TabIndex = 3;
            this.lblDescricaoProd.Text = "Descrição";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(30, 44);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(77, 20);
            this.txtCodCli.TabIndex = 4;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCli.Location = new System.Drawing.Point(137, 44);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(170, 20);
            this.txtNomeCli.TabIndex = 5;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(30, 130);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(77, 20);
            this.txtCodProd.TabIndex = 6;
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(137, 130);
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(115, 20);
            this.txtDescricaoProd.TabIndex = 7;
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarCliente.Location = new System.Drawing.Point(30, 70);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(277, 23);
            this.btnSelecionarCliente.TabIndex = 8;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarProduto.Location = new System.Drawing.Point(30, 157);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(275, 23);
            this.btnSelecionarProduto.TabIndex = 9;
            this.btnSelecionarProduto.Text = "Selecionar Produto";
            this.btnSelecionarProduto.UseVisualStyleBackColor = true;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(217, 209);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(30, 238);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(275, 169);
            this.dgvItens.TabIndex = 11;
            // 
            // nudQtd
            // 
            this.nudQtd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtd.Location = new System.Drawing.Point(258, 131);
            this.nudQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(49, 20);
            this.nudQtd.TabIndex = 12;
            this.nudQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(217, 413);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(88, 23);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimparItens
            // 
            this.btnLimparItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparItens.Location = new System.Drawing.Point(32, 413);
            this.btnLimparItens.Name = "btnLimparItens";
            this.btnLimparItens.Size = new System.Drawing.Size(75, 23);
            this.btnLimparItens.TabIndex = 14;
            this.btnLimparItens.Text = "Limpar Itens";
            this.btnLimparItens.UseVisualStyleBackColor = true;
            this.btnLimparItens.Click += new System.EventHandler(this.btnLimparItens_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(115, 417);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total: R$ 00,00";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(32, 209);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(84, 23);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // nudQtdRemover
            // 
            this.nudQtdRemover.Location = new System.Drawing.Point(122, 212);
            this.nudQtdRemover.Name = "nudQtdRemover";
            this.nudQtdRemover.Size = new System.Drawing.Size(44, 20);
            this.nudQtdRemover.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 462);
            this.Controls.Add(this.nudQtdRemover);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimparItens);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSelecionarProduto);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.txtDescricaoProd);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblDescricaoProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblCodCli);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 501);
            this.MinimumSize = new System.Drawing.Size(352, 501);
            this.Name = "Form1";
            this.Text = "Projeto Venda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRemover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblDescricaoProd;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimparItens;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.NumericUpDown nudQtdRemover;
    }
}

