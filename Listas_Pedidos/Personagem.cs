using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Personagem 
{
    
    public List<Atributos> _itens;
    public int _registros = 0;



   
    public Personagem()
    {
        _itens = new List<Atributos>();
    }

    public void AdicionarPersona(Atributos item)
    {        
        this._itens.Add(item);
        _registros++;
    }
    public void removerPersona(int num)
    {
        this._itens.Remove(this[num]);
        this._registros--;
    }



    public Atributos this[int indice]
    {
        get
        {
            if (indice < this._itens.Count)
                return this._itens[indice];
            else
                throw new IndexOutOfRangeException("O índice está fora dos limites.");
        }

        set
        {
            this._itens[indice] = value;
        }
    }

    


}
