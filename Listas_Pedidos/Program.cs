using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_personas
{
    internal class Program

    {

        static void Main(string[] args)
        {


            try
            {


                bool retorna = true;
                bool loop = true;
                Personagem persona = new Personagem();
                Atributos atrib = new Atributos();

                void exibirTabelas()
                {
                    Console.WriteLine("ID" + "  " + "Personagem" + "   " + "Força" + "   " + "Magia" + "   " + "Destreza");
                    for (int i = 0; i < persona._registros; i++)
                    {
                        string id = (i + 1).ToString();                        
                        Console.WriteLine(id + "     " + persona[i].Personagem.ToString() + "         " + persona[i].Força.ToString() + "         " + persona[i].Magia.ToString() + "         " + persona[i].Destreza.ToString());
                        Console.WriteLine("-----------------------------------------------------------------------");

                    }
                }
                void exibeTabela(string n)
                {                                       
                        string id = n;
                        int x = int.Parse(n);
                        int i = (x-1);
                        Console.WriteLine("ID" + "  " + "Personagem" + "   " + "Força" + "   " + "Magia" + "   " + "Destreza");
                        Console.WriteLine(id + "     " + persona[i].Personagem.ToString() + "         " + persona[i].Força.ToString() + "         " + persona[i].Magia.ToString() + "         " + persona[i].Destreza.ToString());
                        Console.WriteLine("-----------------------------------------------------------------------");
                                        
                }
                void AdicionarPontos(string l,int i) {

                    if (atrib._pontos > 0)
                    {
                        if (l == "F")
                        {

                            persona[i].Força++;
                            atrib._pontos--;

                        }
                        else if (l == "M")
                        {
                            persona[i].Magia++;
                            atrib._pontos--;
                        }
                        else if (l == "D")
                        {
                            persona[i].Destreza++; ;
                            atrib._pontos--;
                        }
                    }
                    else
                        Console.WriteLine("\nOs pontos de atributo acabaram");
                }
               




                Console.WriteLine("                                            ---GAMA RPG---");



                while (retorna == true)
                {

                    Console.WriteLine("\nDigite a CLASSE do personagem:");
                    string classe = Console.ReadLine();

                    Console.WriteLine("\nDigite os pontos de FORÇA do personagem:");
                    int força = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite os pontos de MAGIA do personagem:");
                    int magia = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite os pontos de DESTREZA do personagem:");
                    int destrreza = int.Parse(Console.ReadLine());

                    persona.AdicionarPersona(new Atributos()
                    {
                        Personagem = classe,
                        Força = força,
                        Magia = magia,
                        Destreza = destrreza
                    });


                    Console.WriteLine("\nDeseja adicionar mais personagens? digite S ou N");
                    string resp = Console.ReadLine().ToUpper();
                    if (resp == "N")
                        retorna = false;

                }
                    Console.Clear();
                    exibirTabelas();


                Console.WriteLine($"O jogo tem {persona._registros} personagens ");
                Console.WriteLine($"\nDigite C para customizar ou R para remover ");
                string opt = Console.ReadLine();
                if (opt == "C")
                {
                    Console.WriteLine("Digite o ID que deseja customizar");
                    string ind = Console.ReadLine();
                    while (loop)
                    {
                        Console.Clear();
                        exibeTabela(ind);

                        Console.WriteLine($"\nVoce  possui {atrib.Pontos} pontos de atributo para adicionar a esse perssonagem");

                        Console.WriteLine("\n digite F para adicionar Força, M para Magia ou D para Destreza");

                        string letra = Console.ReadLine().ToUpper();
                        int i = int.Parse(ind);
                        int x = (i - 1);
                        AdicionarPontos(letra, x);

                        Console.Clear();

                        exibeTabela(ind);
                        Console.WriteLine($"\nVoce tem {atrib.Pontos} pontos de atributo. Deseja continuar nesse personagem? S ou N  ");
                        string res = Console.ReadLine().ToUpper();
                        if (res == "S")
                            loop = true;
                        else if (res == "N")
                            loop = false;
                    }
                }
                else 
                {
                    Console.WriteLine("Digite o ID que deseja remover");
                    string indice = Console.ReadLine();
                    int ind = int.Parse(indice);
                    
                    persona.removerPersona(ind-1);
                    

                }
                Console.Clear();
                exibirTabelas();

                Console.ReadLine();





            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }


            Console.ReadLine();
        }
    }
    }

