using System;
using System.Collections.Generic;


namespace Ganaderia.App.Dominio
{
    public class Vacuna
    {
       public int Id { get; set; }
       public string Nombre {get;set;}
       public string Laboratorio { get; set; }
       public DateTime FechaVencimiento { get; set;}
       public string Descripcion { get; set; }
       public List<Vacuna> Vacunas { get; set; }

    }

}