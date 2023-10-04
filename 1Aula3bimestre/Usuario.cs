using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Aula3bimestre
{
    internal class Usuario
    {
        private int _Id;
        private string _Nome;
        private string _Email;
        private string _Senha;

        public Usuario( string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public string Nome
        {
            set { Nome = value; }
            get { return _Nome; }
        }

        public string Email
        {
            set { Email = value; }
            get { return _Email; }
        }
        public string Senha
        {
            set { Senha = value; }
            get { return _Senha; }
        }
        public string ID
        {
            set { Id = value; }
            get { return _Id; }
        }
    }
}
