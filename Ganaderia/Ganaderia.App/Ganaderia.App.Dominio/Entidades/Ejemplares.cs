using System;
using System.Collections.Generic;

//permitir git
namespace Ganaderia.App.Dominio
{
    public class Ejemplares
    {
    
       public int Id { get; set; }
       public DateTime FechaRegistro { get; set; }
       public int Edad {get;set;}
       public float Peso { get; set; }
       public string Raza { get; set;}
       public string Genero { get; set;}
       public string Ubicacion{ get; set;}
       public Veterinario Veterinario { get; set; }
       public List<Vacuna> Vacunas { get; set; }
       public List<HistoriaClinica> historiaClinica { get; set; }


    }

}