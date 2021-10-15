using Ganaderia.App.Dominio;
using System;
using System.Collections.Generic;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();

        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }    
    
    }

}
