using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Aula3bimestre
{
    public class Usuario
    {
        private int _Id;
        private string _Nome;
        private string _Email;
        private string _Senha;

        public Usuario( int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public Usuario( string nome, string email, string senha)
        {
        
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public string Nome
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O campo nome está vazio!");
                
                    _Nome = value;
            }
            get { return _Nome; }
        }

        public string Email
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O campo email está vazio!");

                _Email = value;
            }
            get { return _Email; }
        }
        public string Senha
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O campo senha está vazio!");

                _Senha = value; 
            }
            get { return _Senha; }
        }
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
    }
}
