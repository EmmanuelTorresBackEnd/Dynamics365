using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace DynacoopConsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IOrganizationService service = ConnectionFactory.GetService();


            //CONTA
            Entity conta = new Entity("account");
            Console.WriteLine("Por Favor informe o nome da conta");
            conta["name"] = Console.ReadLine();

            Console.WriteLine($"Digite seu Telefone ex:(DDD)99999-9999");
            conta["telephone1"] = Console.ReadLine();

            Console.WriteLine($"Digite seu E-mail");
            conta["emailaddress1"] = Console.ReadLine();

            Console.WriteLine($"Possui Fax? se não Aperte ENTER!");
            conta["fax"] = Console.ReadLine();

            Console.WriteLine($"Digite seu WebSite");
            conta["websiteurl"] = Console.ReadLine();

            Guid accountId = service.Create(conta);

            Console.WriteLine($"Caso queira criar um Contato prossiga com o cadastro, caso não queira tecle ENTER em todos os campos!");

            //CONTATO
            Entity contato = new Entity("contact");
            Console.WriteLine($"Digite o primeiro nome");

            contato["firstname"] = Console.ReadLine();
            Console.WriteLine($"Digite o sobrenome");

            contato["lastname"] = Console.ReadLine();
            Console.WriteLine($"Digite sobrenome2");

            contato["jobtitle"] = Console.ReadLine();
            Console.WriteLine($"Digite sua Profissão");

            contato["accountid"] = new EntityReference("account" , accountId);

            service.Create(contato);


            Console.WriteLine($"Obrigado por utilizar nosso sistema!!");

            Console.Write("Finalizando");
            Thread.Sleep(1000);
            for (var i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

        }

    }

}

    





            

 
