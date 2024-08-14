using System;

public class Produto {
    public string Nome {
        get { return _nome; }
        set { 
            if (value != null && value.Length > 1) {
                _nome = value;}
            }
        }
    }
    
    public double Preco {
        get { return _preco; }
    }
    
    public int Quantidade {
        get { return _preco; }
    }
}
