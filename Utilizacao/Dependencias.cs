using InjecaoDependencia;
using Utilizacao.Logs;

namespace Utilizacao
{
    class Dependencias : IDependencias
    {
        public void Mapear()
        {
            DI.Instancia.Registrar<ILogErro, LogErroSimplificado>();            
        }
    }
}
