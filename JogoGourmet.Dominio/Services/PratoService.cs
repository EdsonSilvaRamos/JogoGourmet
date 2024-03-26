using JogoGourmet.Dominio.Entidades;
using JogoGourmet.Dominio.Interfaces;
using JogoGourmet.Dominio.Repositorios;
using System.Collections.Generic;

namespace JogoGourmet.Dominio.Services
{
    public class PratoService : IPratoService
    {
        private readonly IPratoRepository _pratoRepository;

        public PratoService()
        {
            _pratoRepository = new PratoRepository();
        }

        public void AdicionaPrato(List<Prato> listaPrato, Prato prato)
        {
            _pratoRepository.AdicionaPrato(listaPrato, prato);
        }

        public List<Prato> RetornaListaPratos()
        {
            return _pratoRepository.RetornaListaPratos();
        }
    }
}