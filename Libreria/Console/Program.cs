using CDatos.Contexts;
using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Implementations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#region configuraciones
// Configuración de DbContextOptions para usar el contexto
var optionsBuilder = new DbContextOptionsBuilder<LibreriaContext>();
// Aquí puedes configurar tu cadena de conexión o cualquier otra configuración necesaria
optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibreriaProg2024;Integrated Security=True;TrustServerCertificate=true;");

LibreriaContext context = new LibreriaContext(optionsBuilder.Options);

// Crear instancias de los repositorios con el contexto
IPersonaRepository personaRepository = new PersonaRepository(context);
IAutorRepository autorRepository = new AutorRepository(context);
//IClienteRepository usuarioRepository = new ClienteRepository(context);
//IEmpleadoRepository materiaRepository = new EmpleadoRepository(context);

// Crear instancias de las lógicas pasando los repositorios necesarios
PersonaLogic personaLogic = new PersonaLogic(personaRepository);
AutorLogic autorLogic = new AutorLogic(autorRepository);


#endregion

#region llamada a metodos

#region usuario
Autor autorAgregar = new Autor()
{

};
Persona personaAgregar = new Persona()
{
    TipoDocumento = "DNI",
    Documento = "46368342",
    Nombre = "Valentino",
    Apellido = "Carignano",
    Nacionalidad = "Argentina",
    Telefono = "+543493441292",
    //Autor = autorAgregar
};



Persona personaActualizar = new Persona()
{
    TipoDocumento = "DNI",
    Documento = "46368342",
    Nombre = "Valentino",
    Apellido = "Carignano",
    Nacionalidad = "Argentina",
    Telefono = "+543493441292",
};

personaLogic.AltaPersona(personaAgregar);
//usuarioLogic.BajaPersona(dni);
//usuarioLogic.ActualizacionPersona("46368342", usuarioActualizar);
#endregion
#region materia
//var profesorExistente = context.Profesor.SingleOrDefault(r => r.Usuario.DNI == "46368342");
//var horarioMateria1 = context.DiaHorario.SingleOrDefault(r => r.ID == 12);
//var horarioMateria2 = context.DiaHorario.SingleOrDefault(r => r.ID == 20);

//Materia materiaAgregar = new Materia()
//{
//    Nombre = "Programacion",
//    Anio = 2,
//    Modalidad = "TeoricoPractica",
//    Profesores = new List<Profesor> { profesorExistente },
//    DiaHorario = new List<DiaHorario> { horarioMateria1, horarioMateria2 }
//};
//Materia materiaActualizar = new Materia()
//{
//    Nombre = "Programacion",
//    Anio = 2,
//    Modalidad = "teorica",
//    Profesores = new List<Profesor> { profesorExistente },
//    DiaHorario = new List<DiaHorario> { horarioMateria1, horarioMateria2 }
//};
//materiaLogic.AltaMateria(materiaAgregar);
//materiaLogic.BajaMateria("Programacion");
//materiaLogic.ActualizacionMateria("Programacion", materiaActualizar);
#endregion
#region examen
//var materiaExistente = context.Materia.SingleOrDefault(r => r.Nombre == "Programacion");
//var horarioMateria1 = context.DiaHorario.SingleOrDefault(r => r.ID == 12);
//var horarioMateria2 = context.DiaHorario.SingleOrDefault(r => r.ID == 20);

//Examen examenAgregar = new Examen()
//{
//    Tipo = "Parcial",
//    Materia = materiaExistente,
//    DiaHorario = horarioMateria1
//};
//Examen examenActualizar = new Examen()
//{
//    Tipo = "Parcial",
//    Materia = materiaExistente,
//    DiaHorario = horarioMateria2
//};

////examenLogic.AltaExamen(examenAgregar);
////examenLogic.BajaExamen(2, 12);
////examenLogic.ActualizacionExamen(2, 12, examenActualizar);
#endregion

var lista = personaLogic.ObtenerPersonas().GetAwaiter().GetResult();
var jsonSerializerSettings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
foreach (var item in lista)
{
    Console.WriteLine(JsonConvert.SerializeObject(item, jsonSerializerSettings));
    Console.WriteLine(" ");
}
#endregion
