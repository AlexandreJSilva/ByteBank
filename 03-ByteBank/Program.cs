using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 321;
            contaDaGabriela.numero = 987654321;
            //contaDaGabriela.saldo = 100;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela Costa";
            contaDaGabrielaCosta.agencia = 321;
            contaDaGabrielaCosta.numero = 123456789;
            //contaDaGabrielaCosta.saldo = 100;

            /*Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);*/

            Console.WriteLine("Igualdade de tipo de REFERÊNCIA (contaDaGabriela == contaDaGabrielaCosta): " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de VALOR (contaDaGabriela == contaDaGabrielaCosta): " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine("Igualdade de tipo de REFERÊNCIA que aponta para mesmo local da MEMÓRIA " +
                "(contaDaGabriela = contaDaGabrielaCosta): " 
                + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine(); 


        }
    }
}
