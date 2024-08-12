using System.Globalization;
namespace Course {
    class Produto {
        private string _nome; // Private não permite alterações, apenas pelo metodo Get e Set
        private double _preco;
        private int _quantidade;
        public Produto() {
        }

        //Em private se usa o padrão de "_" e letra inicial minúscula no c#
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome() {
            return _nome;
        }

        //Condicional para permitir apenas nomes acima de 1 caractere e que não seja vazio
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        //Void pois não retorna apenas executa uma ação
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        //O override permite que você altere ou estenda o comportamento de métodos herdados de uma classe base
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}



