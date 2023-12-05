using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _1Aula3bimestre.Livro1;

namespace _1Aula3bimestre
{
    public class Livro1
    {
        
            private int _ID;
            private string Livro2;
            private string _Autor;
            private string _Genero;

            public Livro1(int id, string livro, string autor, string genero)
            {
                this.ID = id;
                this.Livro2 = livro;
                this.Autor = autor;
                this.Genero = genero;
              
            }
            public Livro1(string livro, string autor, string genero)
            {
                Livro2 = livro;
                Autor = autor;
                Genero = genero;

            }
            public string livro2
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new ArgumentException("O campo nome está vazio!");

                    Livro2 = value;
                }
                get { return Livro2; }
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

