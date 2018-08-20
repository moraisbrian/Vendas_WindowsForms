using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVendas.BLL
{
    class Produto
    {
        private int _cod;
        private string _descricao;
        private double _valorUnit;
        private int _qtd;

        public int Cod
        {
            get
            {
                return _cod;
            }

            set
            {
                _cod = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }

        public double ValorUnit
        {
            get
            {
                return _valorUnit;
            }

            set
            {
                _valorUnit = value;
            }
        }

        public int Qtd
        {
            get
            {
                return _qtd;
            }

            set
            {
                _qtd = value;
            }
        }
    }
}
