using JogoGourmet.Dominio.Entidades;
using JogoGourmet.Dominio.Interfaces;
using System.Collections.Generic;

namespace JogoGourmet.Dominio.Repositorios
{
    public class PratoRepository : IPratoRepository
    {
        public void AdicionaPrato(List<Prato> listaPrato, Prato prato)
        {
            listaPrato.Add(prato);
        }

        public List<Prato> RetornaListaPratos()
        {
            return new List<Prato>
            {
                new Prato {Id = 1, Nome = "Bolo de Chocolate"},
                new Prato {Id = 2, Nome = "Lasanha", Tipo = "massa"}
            };
        }
    }
}
