using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Atributos : Personagem 
{
    public int _força;
    public int _magia;
    public int _destreza;
    public string _person ;
    public int _pontos = 5  ;


    //Indexadores

    public int Pontos
    {
        get { return _pontos; }
        set { _pontos = value; }
    }
    public string Personagem
    {
        
        get { return _person; }
        set { _person = value; }
    }
    public int Força
    {
        get { return _força; }
        set { _força = value; }
    }

    public int Magia
    {
        get { return _magia; }
        set { _magia = value; }
    }

    public int Destreza
    {
        get { return _destreza; }
        set { _destreza = value; }
    }


  

    

}