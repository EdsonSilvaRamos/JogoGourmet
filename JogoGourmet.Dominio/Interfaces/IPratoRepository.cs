using JogoGourmet.Dominio.Entidades;
using System.Collections.Generic;

namespace JogoGourmet.Dominio.Interfaces
{
    public interface IPratoRepository
    {
        void AdicionaPrato(List<Prato> listaPrato, Prato prato);
        List<Prato> RetornaListaPratos();
    }
}