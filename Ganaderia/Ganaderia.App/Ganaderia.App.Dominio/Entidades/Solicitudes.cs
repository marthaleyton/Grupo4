using System;
using System.Collections.Generic;


namespace Ganaderia.App.Dominio
{
    public class Solicitudes
    {
       public int Id { get; set; }
       public DateTime Fecha { get; set; } 
       public string Descripcion {get;set;}
       public string Estado { get; set; }
      public Ganadero Ganadero{ get; set;}
      public Veterinario Veterinario{ get; set;}
      public Ejemplares Ejemplares { get; set; }

    }

}