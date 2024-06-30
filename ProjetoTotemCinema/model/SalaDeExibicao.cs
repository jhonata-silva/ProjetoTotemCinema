using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTotemCinema.model
{
    internal class SalaDeExibicao
    {
        private String nome;
        private String assentos;
        private int id;

        public SalaDeExibicao(string nome, string assentos, int id)
        {
            this.nome = nome;
            this.assentos = assentos;
            this.id = id;
        }
        public SalaDeExibicao(String nome, String assentos)
        {
            this.nome=nome;
            this.assentos = assentos;
        }

        public String getNome()
        {
            return this.nome;
        }
        public String getAssentos()
        {
            return this.assentos;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setAssentos(String assentos)
        {
            this.assentos = assentos;
        }
    }
}
