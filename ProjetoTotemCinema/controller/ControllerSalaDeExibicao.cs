using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTotemCinema.model;
using ProjetoTotemCinema.dao;

namespace ProjetoTotemCinema.controller
{
    internal class ControllerSalaDeExibicao

    {
        private daoSalaDeExibicao daoSalaDeExibicao;
        private SalaDeExibicao salaDeExibicao;
        public bool Salvar_SalaDeExibicao(String nome, String assentos)
        {
            bool retorno = true;
            if (VerificaDadosSala(nome, assentos) == false)
            {
                return false;
            }
            else
            {
                salaDeExibicao = new SalaDeExibicao(nome, assentos);
                daoSalaDeExibicao = new daoSalaDeExibicao();
                retorno = daoSalaDeExibicao.Salvar(salaDeExibicao);
              
            }
            return retorno;
        }

        public bool VerificaDadosSala(String nome, String assentos)
        {
            if (nome == "" && assentos == "")
            {
                return false;
            }
            else
            {
                daoSalaDeExibicao = new();
                if (daoSalaDeExibicao.ConsultaSalaDeExibicao(nome)==true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
