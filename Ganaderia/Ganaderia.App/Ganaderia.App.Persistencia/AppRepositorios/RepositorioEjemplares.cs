using System;
using System.Collections.Generic;
using System.Linq;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioEjemplares : IRepositorioEjemplares
    {
        private readonly AppContext _appContext;

        public RepositorioEjemplares(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioEjemplares.AddEjemplares(Ejemplares ejemplar)
        {
            _appContext.ejemplares.Add(ejemplar);
            _appContext.SaveChanges();
        }

        
    

        Ejemplares IRepositorioEjemplares.AsignarVeterinarioAEjemplares(int IdEjemplares, int IdVeterinario)
        {
            var ejemplarEncontrado = _appContext.ejemplares.FirstOrDefault(e => e.Id == IdEjemplares);
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(e => e.Id == IdVeterinario);

            if (ejemplarEncontrado!= null && veterinarioEncontrado!= null) {
                ejemplarEncontrado.Veterinario = veterinarioEncontrado;
                _appContext.SaveChanges();

            }
            return ejemplarEncontrado;
        }    
    }

}
    