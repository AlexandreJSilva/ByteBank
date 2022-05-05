using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Byte Bank 1");
            Console.WriteLine();

            new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 1234;
            contaDaGabriela.numero = 123456789;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titurar: "+contaDaGabriela.titular);
            Console.WriteLine("Agência: "+contaDaGabriela.agencia);
            Console.WriteLine("Conta Corrente: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo atual R$"+contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.WriteLine();
            Console.WriteLine("Olá "+ contaDaGabriela.titular+" sua conta é "
            + contaDaGabriela.numero+" e seu saldo atualizado é de R$"+ contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
