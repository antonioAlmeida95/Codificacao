﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioConsulta
    {
        private static List<Consulta_M> listaConsultas;

        static RepositorioConsulta()
        {
            listaConsultas = new List<Consulta_M>();
        }

        public Consulta_M Adicionar(Consulta_M consulta)
        {
            consulta.Id = listaConsultas.Count + 1;
            listaConsultas.Add(consulta);
            return consulta;
        }

        public void Editar(Consulta_M consulta)
        {
            int posicao = listaConsultas.FindIndex(e => e.Id == consulta.Id);
            listaConsultas[posicao] = consulta;
        }

        public void Remover(Consulta_M consulta)
        {
            int posicao = listaConsultas.FindIndex(e => e.Id == consulta.Id);
            listaConsultas.RemoveAt(posicao);
        }

        public Consulta_M Obter(Func<Consulta_M, bool> where)
        {
            return listaConsultas.Where(where).FirstOrDefault();
        }

        public List<Consulta_M> ObterTodos()
        {
            return listaConsultas;
        }
    }
}
