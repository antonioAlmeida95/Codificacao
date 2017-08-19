﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistence
{
    class RepositorioPeriograma
    {
        private static List<Periograma> listaPeriogramas;

        static RepositorioPeriograma()
        {
            listaPeriogramas = new List<Periograma>();
        }

        public Periograma Adicionar(Periograma periograma)
        {
            periograma.Id = listaPeriogramas.Count + 1;
            listaPeriogramas.Add(periograma);
            return periograma;
        }

        public void Editar(Periograma periograma)
        {
            int posicao = listaPeriogramas.FindIndex(e => e.Id == periograma.Id);
            listaPeriogramas[posicao] = periograma;
        }

        public void Remover(Periograma periograma)
        {
            int posicao = listaPeriogramas.FindIndex(e => e.Id == periograma.Id);
            listaPeriogramas.RemoveAt(posicao);
        }

        public Periograma Obter(Func<Periograma, bool> where)
        {
            return listaPeriogramas.Where(where).FirstOrDefault();
        }

        public List<Periograma> ObterTodos()
        {
            return listaPeriogramas;
        }
    }
}
