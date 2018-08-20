using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploVendas.UI
{
    public partial class frmBusca : Form
    {
        //Verifica se é busca de produtos
        bool produto;
        
        /// <summary>
        /// Metodo construtor que recebe true/false.
        /// true - Busca de produtos.
        /// false- Busca de clientes.
        /// </summary>
        /// <param name="p">true - produtos / false - clientes</param>
        public frmBusca(bool p)
        {
            InitializeComponent();
            produto = p;
        }

        DAL.ClienteDAL cDAL = new DAL.ClienteDAL();
        DAL.ProdutoDAL pDAL = new DAL.ProdutoDAL();
        BLL.Cliente clienteBLL = new BLL.Cliente();
        BLL.Produto produtoBLL = new BLL.Produto();

        private void frmBusca_Load(object sender, EventArgs e)
        {
            if (produto)
            {
                dgvResultado.DataSource = pDAL.Consultar();
            }
            else //Cliente
            {
                dgvResultado.DataSource = cDAL.Consultar();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (produto)
            {
                produtoBLL.Descricao = txtFiltro.Text;
                dgvResultado.DataSource = pDAL.Consultar(produtoBLL);
            }
            else //Cliente
            {
                clienteBLL.Nome = txtFiltro.Text;
                dgvResultado.DataSource = cDAL.Consultar(clienteBLL);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
                if (produto)
                {
                    produtoBLL.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);
                    produtoBLL.Descricao = dgvResultado.SelectedRows[0].Cells["Descricao"].Value.ToString();
                    produtoBLL.Qtd = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Qtd"].Value);
                    produtoBLL.ValorUnit = Convert.ToDouble(dgvResultado.SelectedRows[0].Cells["ValorUnit"].Value);

                    ((Form1)Application.OpenForms["Form1"]).ProdutoBLL = produtoBLL;

                }
                else //Cliente
                {
                    clienteBLL.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);
                    clienteBLL.Nome = dgvResultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                    ((Form1)Application.OpenForms["Form1"]).ClienteBLL = clienteBLL;
                }

                this.Close();
            }
        }
    }
}
