using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System;


namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        void AddGanadero(Ganadero ganadero);
        
        void DeleteGanadero (int IdGanadero);

        IEnumerable<Ganadero> GetAllGanaderos();
    }
}
