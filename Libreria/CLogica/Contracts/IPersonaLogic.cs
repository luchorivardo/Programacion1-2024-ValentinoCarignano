using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        void AltaPersona(Persona persona);
        void BajaPersona(string documento);
        void ActualizacionPersona(string documento, string nombre, string apellido);
    }
}
