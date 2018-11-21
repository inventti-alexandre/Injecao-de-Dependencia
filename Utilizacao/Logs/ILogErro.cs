using System;

namespace Utilizacao.Logs
{
    public interface ILogErro
    {
        void Logar(Exception ex);
    }
}
