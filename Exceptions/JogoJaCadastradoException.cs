using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalago.Exceptions
{
    public class JogoJaCadastradoException
    {
        public JogoJaCadastradoException()
           : base("Este já jogo está cadastrado")
        { }
    }
}
