using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_de_contatos
{
    internal class Contato
    {
        private String nome;
        private String telefone;
        private String email;

        public Contato()
        {
        }

        public String getNome()
        {
            return nome;
        }
        public String getTelefone()
        {
            return telefone;
        }
        public String getEmail()
        {
            return email;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public override string ToString()
        {
            return this.nome + " | " + this.telefone + " | " + this.email;
        }
    }
}
