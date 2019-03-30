using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Models
{
    public class Usuario
    {
        private string nome;
        private string senha;

        public Usuario(string nome, string senha)
        {
           
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        
       /* public bool verificar(string l, string s)
        {
            if (l == "" || s == "")
            {
                return null;
            }
        }*/

    }
}
