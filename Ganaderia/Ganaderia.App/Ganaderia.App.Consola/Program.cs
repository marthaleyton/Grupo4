using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;
 


namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioEjemplares _repositorioEjemplares = new RepositorioEjemplares(new Persistencia.AppContext());
        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            //AddVeterinario();
            //AddEjemplares();
            //AsignarVeterinarioAEjemplares();
            //AddEjemplaresVacunaVeterinario();
            //DeleteGanadero(2);
            //GetAllVeterinarios();

        }

        private static void AddGanadero()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Martha",
                Apellidos = "Leyton",
                NumeroTelefono = "3165434131",
                Correo = "mleyton7@gmail.com",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5445
            } ;
            

            _repositorioGanadero.AddGanadero(ganadero);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Luz",
                Apellidos = "Leyton",
                NumeroTelefono = "3156781890",
                Correo = "lleyton7@gmail.com",
                Contrasena = "654321",
                TarjetaProfesional = "A8798",
                Especialidad = "Ganado en General",
                Latitud = 4554,
                Longitud = 5445
            } ;
            

            _repositorioVeterinario.AddVeterinario(veterinario);
        }

        private static void AddEjemplares()
        {
            var ejemplares = new Ejemplares
            {
                FechaRegistro = DateTime.Now,
                Edad = 1,
                Peso = 2,
                Raza = "desconocida",
                Genero = "Macho",
                Ubicacion = "Cochera",
                Vacunas = null,
                historiaClinica = null
            } ;
            

            _repositorioEjemplares.AddEjemplares(ejemplares);
        }
        
    private static void AddEjemplaresVacunaVeterinario()
        {   
           
            var veterinario = new Veterinario
            {
                Nombres = "Luna",
                Apellidos = "Leyton",
                NumeroTelefono = "3456781890",
                Correo = "lunaleyton7@gmail.com",
                Contrasena = "456789",
                TarjetaProfesional = "A8498",
                Especialidad = "Ganado en General",
                Latitud = 4554,
                Longitud = 5445
            } ;

            
            List<Vacuna> vacunas = new List<Vacuna>();
            
                     
            Vacuna vac1 = new Vacuna
            {
                Nombre = "Covid3",
                Laboratorio = "China",
                FechaVencimiento = DateTime.Now,
                Descripcion = "no se puede aplicar a porcino"
            } ;

            Vacuna vac2 = new Vacuna
            {
                Nombre = "Covid4",
                Laboratorio = "India",
                FechaVencimiento = DateTime.Now,
                Descripcion = "no se puede aplicar a peces"
            } ;
             
             Vacuna vac3 = new Vacuna
            {
                Nombre = "Covid5",
                Laboratorio = "Japonesa",
                FechaVencimiento = DateTime.Now,
                Descripcion = "no se puede aplicar a vacas"
            } ;     
           

            vacunas.Add(vac1);
            vacunas.Add(vac2);
            vacunas.Add(vac3);

             var ejemplares = new Ejemplares
            {
                FechaRegistro = DateTime.Now,
                Edad = 2,
                Peso = 22,
                Raza = "porcino",
                Genero = "Macho",
                Ubicacion = "Cochera",
                Veterinario = veterinario,
                Vacunas = vacunas,
                historiaClinica = null
            };

            _repositorioEjemplares.AddEjemplares(ejemplares);
        }

    private static void AsignarVeterinarioAEjemplares()
    {
        _repositorioEjemplares.AsignarVeterinarioAEjemplares(1, 4);
    }

     private static void DeleteGanadero(int idGanadero)
     {
          _repositorioGanadero.DeleteGanadero(idGanadero);
     }

     private static void GetAllVeterinarios()
        {
            var veterinarios = _repositorioVeterinario.GetAllVeterinarios();

            foreach (var veterinario in veterinarios)
            {
                Console.WriteLine(veterinario.Nombres + " - " + veterinario.Apellidos);
            }

        }


    }


}
