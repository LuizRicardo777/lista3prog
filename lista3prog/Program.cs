using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lista3prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- exercicio 1");
            Console.WriteLine("2- exercicio 2");
            Console.WriteLine("3- exercicio 3");
            Console.WriteLine("4- exercicio 4");
            Console.WriteLine("5- exercicio 5");
            Console.WriteLine("==============");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    int dia;
                    Console.WriteLine("digite um numero para saber o dia da semana");
                    dia = int.Parse(Console.ReadLine());    
                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("o dia da semana é domingo");
                            break;
                        case 2:
                            Console.WriteLine("o dia da semana é segunda");
                            break;
                        case 3:
                            Console.WriteLine("o dia da semana é terça");
                            break;
                        case 4:
                            Console.WriteLine("o dia da semana é quarta");
                            break;
                        case 5:
                            Console.WriteLine("o dia da semana é quinta");
                            break;
                        case 6:
                            Console.WriteLine("o dia da semana é sexta");
                            break;
                        case 7:
                            Console.WriteLine("o dia da semana é sabádo");
                            break;
                        default:
                            Console.WriteLine("opção invalida");
                            break;
                    }

                    break; 
                    //==========================================================================
                case 2:
                    double valor, pagamento,res,desconto;
                    Console.WriteLine("qual o valor da compra?");
                    valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("qual a forma de pagamento?");
                    Console.WriteLine("1-PIX- 10% DE DESCONTO");
                    Console.WriteLine("2-Á VISTA - 15% DE DESCONTO");
                    Console.WriteLine("3- CARTÃO DE DÉBITO - 5% DE ACRESCIMO");
                    Console.WriteLine("4-CARTÃO DE CRÉDITO - 10% DE ACRESCIMO");
                    pagamento = double.Parse(Console.ReadLine());

                    switch (pagamento)
                    {
                        case 1:
                            desconto = valor * 0.10;
                            res = valor - desconto;
                            Console.WriteLine("o valor a ser pago é de: "+ res);
                            break;
                        case 2:
                            desconto = valor * 0.15;
                            res = valor - desconto;
                            Console.WriteLine("o valor a ser pago é de: " + res);
                            break;
                        case 3:
                            desconto = valor * 0.05;
                            res = valor + desconto;
                            Console.WriteLine("o valor a ser pago é de: " + res);
                            break;
                        case 4:
                            desconto = valor * 0.10;
                            res = valor + desconto;
                            Console.WriteLine("o valor a ser pago é de: " + res);
                            break;
                        default:
                            Console.WriteLine( "essa opção não existe");
                            break;
                    }

                    break;
                    //========================================================================
                case 3:
                    int ano,mes;
                    Console.WriteLine("ENTRE COM O NUMERO DO MÊS: ");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("8");
                    Console.WriteLine("9");
                    Console.WriteLine("10");
                    Console.WriteLine("11");
                    Console.WriteLine("12");
                
                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("1-JANEIRO e tem 31 dias");
                            break ;
                        case 2:
                            Console.WriteLine("informe o ano");
                            ano = int.Parse(Console.ReadLine());
                            if (ano % 4 == 0 && ano % 100 == 0 || ano % 400 == 0)
                            {
                                Console.WriteLine("2-FEVEREIRO e tem 29 dias");
                            }
                            else
                            {
                                Console.WriteLine("2-FEVEREIRO e tem 28 dias");
                            }
                            break;
                        case 3:
                            Console.WriteLine("3-MARÇO e tem 31 dias");
                            break;
                        case 4:
                            Console.WriteLine("4-ABRIL e tem 30 dias");
                            break;
                        case 5:
                            Console.WriteLine("5-MAIO e tem 31 dias");
                            break;
                        case 6:
                            Console.WriteLine("6-JUNHO e tem 30 dias");
                            break;
                        case 7:
                            Console.WriteLine("7-JULHO e tem 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("8-AGOSTO e tem 30 dias");
                            break;
                        case 9:
                            Console.WriteLine("9-SETEMBRO e tem 31 dias");
                            break;
                        case 10:
                            Console.WriteLine("10-OUTUBRO e tem 30 dias");
                            break;
                        case 11:
                            Console.WriteLine("11-NOVEMBRO e tem 31 dias");
                            break;
                        case 12:
                            Console.WriteLine("12 - DEZMBRO e tem 30 dias");
                            break;

                        default:
                            Console.WriteLine("opção indisponivel");
                            break;
                    }

                    break;
                    //===========================================================================================






            }

            Console.ReadKey();

        }
    }
}
