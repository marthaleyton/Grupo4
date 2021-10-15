using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System;


namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        void AddVeterinario(Veterinario veterinario);
        
        IEnumerable<Veterinario> GetAllVeterinarios();
        
    }
}
