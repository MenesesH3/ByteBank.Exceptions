using SecondByteBank;

namespace SecondByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarConta();

            Console.ReadLine();
        }


        private static void CarregarConta()
        {

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
            }
            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }


        private static void TesteExcecao()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 234123);
                ContaCorrente conta2 = new ContaCorrente(534, 896734);

                //conta2.Transferir(10000, conta);

                //conta.Depositar(50);
                //Console.WriteLine(conta.Saldo);
                conta.Sacar(10000);
                Console.WriteLine(conta.Saldo);

            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Excessão do tipo SaldoInsuficienteException");
            //}
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            //try
            //{
            //    Metodo();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Número não pode ser dividido por 0");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine("Aconteceu um erro");
            //}
        }


        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {

            try
            {
                ContaCorrente conta = null;
                Console.WriteLine(conta.Saldo);
                return numero / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exceção de número = " + numero + " dividido por = " + divisor);
                throw;
            }
        }

    }
}
