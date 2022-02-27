using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }
    }
}
