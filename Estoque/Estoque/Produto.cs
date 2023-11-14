using System.Globalization;

namespace Estoque {
    internal class Produto {

        private string _descricao;
        public int Codigo { get; private set; }

        public double Valor {  get; set;}
        public int Quantidade {  get; set;}

        public string Descricao {
            get { return _descricao; }
            set {
                if(value != null && value.Length > 1) {
                    _descricao = value;
                }
            }
        }

        public Produto(int codigo, string descricao, double valor) {
            Codigo = codigo;
            Descricao = descricao;
            Valor = valor;
        }

        public Produto(int codigo, string descricao, double valor, int quantidade) : this(codigo, descricao, valor) {
            Entrada(quantidade);
        }

        public double ValorTotalEmEstoque() {
            return Valor * Quantidade;
        }
        public void Entrada(int entrada) {
            Quantidade += entrada;
        }

        public void Saida(int saida) {
            Quantidade -= saida;
        }

        public override string ToString() {
            return "------------------------------------------" +
                "\nCODIGO..................: "
                +Codigo
                +"\nDESCRICAO...............: "
                +Descricao
                +"\nVALOR...................: $ "
                +Valor.ToString("F2", CultureInfo.InvariantCulture)
                +"\nQNT.....................: "
                +Quantidade
                +"\nVALOR TOTAL EM ESTOQUE..: $ "
                +ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
