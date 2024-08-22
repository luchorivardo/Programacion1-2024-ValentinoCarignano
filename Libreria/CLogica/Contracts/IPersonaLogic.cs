using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        Persona AltaPersona(Persona personaAgregar);
        void BajaPersona(string documento);
        Persona ActualizacionPersona(Persona personaActualizar);
        Task<List<Persona>> ObtenerPersonas();
    }
}
