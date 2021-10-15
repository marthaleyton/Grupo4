using System;
using System.Collections.Generic;


namespace Ganaderia.App.Dominio
{
    public class HistoriaClinica : Solicitudes
    {
       public int Id { get; set; }
       public DateTime Fecha { get; set; }
       public Ejemplares Ejemplares { get; set; }  
       public string Diagnostico {get;set;}
       public string Tratamiento { get; set; }
       public string Vacuna { get; set;}
       public List<Vacuna> Vacunas { get; set; }
       public string Observaciones { get; set;}

    }

}