using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        void AltaPersona(Persona personaAgregar);
        void BajaPersona(string documento);
        void ActualizacionPersona(string documento, Persona personaActualizar);
        Task<List<Persona>> GetAll();
    }
}
