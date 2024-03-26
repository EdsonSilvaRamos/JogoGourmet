using JogoGourmet.Dominio.Entidades;
using System.Collections.Generic;

namespace JogoGourmet.Dominio.Interfaces
{
    public interface IPratoService
    {
        void AdicionaPrato(List<Prato> listaPrato, Prato prato);
        List<Prato> RetornaListaPratos();
    }
}
