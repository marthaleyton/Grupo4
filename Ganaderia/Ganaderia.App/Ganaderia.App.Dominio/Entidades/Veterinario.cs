namespace Ganaderia.App.Dominio
{
    public class Veterinario : Persona
    {
       public string TarjetaProfesional{ get; set;}
       public string Especialidad{ get; set; }
       public float Latitud {get;set;}
       public float Longitud {get;set;}
    }

}