using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";


            Console.WriteLine(contaDoBruno.titular);

            bool resultadoiSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoiSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);

            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo da contado Bruno R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da contado Gabriela R$" + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo da contado Bruno R$"+contaDoBruno.saldo);
            Console.WriteLine("Saldo da contado Gabriela R$" + contaDaGabriela.saldo);

            Console.WriteLine("Resultado da transferência é: "+ resultadoTransferencia);

            Console.WriteLine();

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo da contado Bruno" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da contado Gabriela" + contaDaGabriela.saldo);

            Console.WriteLine("Saldo da contado Bruno R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da contado Gabriela R$" + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
