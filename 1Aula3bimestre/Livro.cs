using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _1Aula3bimestre.Livro;

namespace _1Aula3bimestre
{
    public class Livro
    {
        
            private int _ID;
            private string _Nomelivro;
            private string _Autor;
            private string _Genero;

            public Livro(int id, string livro, string autor, string genero)
            {
                this.ID = id;
                this.Nomelivro = livro;
                this.Autor = autor;
                this.Genero = genero;
              
            }
            public Livro(string livro, string autor, string genero)
            {
               Nomelivro = livro;
                Autor = autor;
                Genero = genero;

            }
            public string Nomelivro
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new ArgumentException("O campo nome está vazio!");

                    _Nomelivro = value;
                }
                get { return _Nomelivro; }
            }

            public string Autor
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new ArgumentException("O campo email está vazio!");

                    _Autor = value;
                }
                get { return _Autor; }
            }
            public string Genero
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new ArgumentException("O campo senha está vazio!");

                    _Genero = value;
                }
                get { return _Genero; }
            }
            public int ID
            {
                set { _ID = value; }
                get { return _ID; }
            }
        }
    }

