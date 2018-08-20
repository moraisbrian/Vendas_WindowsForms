using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploVendas.BLL;

namespace ExemploVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularTotal()
        {
            double total = 0;
            foreach (BLL.Produto item in listaProdutos)
            {
                total = +item.Qtd * item.ValorUnit;
            }
            lblTotal.Text = "Total: R$ " + total.ToString("n");
        }

        List<BLL.Produto> listaProdutos = new List<Produto>();

        private BLL.Cliente clienteBLL = new BLL.Cliente();
        private BLL.Produto produtoBLL = new BLL.Produto();

        internal Cliente ClienteBLL
        {
            get
            {
                return clienteBLL;
            }

            set
            {
                clienteBLL = value;
            }
        }

        internal Produto ProdutoBLL
        {
            get
            {
                return produtoBLL;
            }

            set
            {
                produtoBLL = value;
            }
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            UI.frmBusca tela = new UI.frmBusca(false);
            tela.Text = "Busca de Clientes";
            tela.ShowDialog();

            if(clienteBLL.Cod != 0)
            {
                txtCodCli.Text = clienteBLL.Cod.ToString();
                txtNomeCli.Text = clienteBLL.Nome;
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            UI.frmBusca tela = new UI.frmBusca(true);
            tela.Text = "Busca de Produtos";
            tela.ShowDialog();

            if(produtoBLL.Cod != 0)
            {
                txtCodProd.Text = produtoBLL.Cod.ToString();
                txtDescricaoProd.Text = produtoBLL.Descricao;
                nudQtd.Maximum = produtoBLL.Qtd;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            BLL.Produto p = new BLL.Produto();
            p.Cod = Convert.ToInt16(txtCodProd.Text);
            p.Descricao = txtDescricaoProd.Text;
            p.Qtd = Convert.ToInt16(nudQtd.Value);
            p.ValorUnit = produtoBLL.ValorUnit;

            if(listaProdutos.Exists(x=> x.Cod == p.Cod))
            {
                p = listaProdutos.First(x => x.Cod == p.Cod);
                if(p.Qtd + Convert.ToInt16(nudQtd.Value) <= nudQtd.Maximum)
                {
                    p.Qtd = p.Qtd + Convert.ToInt16(nudQtd.Value);
                }
                else
                {
                    MessageBox.Show("Quantidade máxima não permitida");
                }
                
            }
            else
            {
                listaProdutos.Add(p);
            }
        
            dgvItens.DataSource = null;
            dgvItens.DataSource = listaProdutos;

            CalcularTotal();
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            listaProdutos.Clear();
            dgvItens.DataSource = null;
            lblTotal.Text = "Total: R$ 00,00";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvItens.SelectedRows.Count > 0)
            {
                int cod;
                cod = Convert.ToInt16(dgvItens.SelectedRows[0].Cells["Cod"].Value);

                BLL.Produto p = listaProdutos.First(x => x.Cod == cod);
                if(p.Qtd <= nudQtdRemover.Value)
                {
                    listaProdutos.Remove(listaProdutos.First(x => x.Cod == cod));
                }
                else
                {
                    p.Qtd -= Convert.ToInt16(nudQtdRemover.Value);
                }

                listaProdutos.Remove(listaProdutos.First(x=> x.Cod == cod));

                dgvItens.DataSource = null;
                dgvItens.DataSource = listaProdutos;

                CalcularTotal();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DAL.VendaDAL vDAL = new DAL.VendaDAL();
            BLL.Venda venda = new Venda();
            List<BLL.VendaItens> itensVenda = new List<VendaItens>();

            foreach (BLL.Produto p in listaProdutos)
            {
                BLL.VendaItens vItem = new VendaItens();
                vItem.CodProduto = p.Cod;
                vItem.Qtd = p.Qtd;
                vItem.ValorUnit = p.ValorUnit;

                itensVenda.Add(vItem);
            }

            venda.CodCliente = clienteBLL.Cod;
            venda.ListaDeItens = itensVenda;

            try
            {

                vDAL.Cadastrar(venda);
                MessageBox.Show("Venda Registrada");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
