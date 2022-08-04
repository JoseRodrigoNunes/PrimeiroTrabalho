﻿using Microsoft.Xrm.Sdk;
using System;
using Trabalho1.Connections;
using Trabalho1.Services;

namespace Trabalho1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewAccount();
        }

        private static void CreateNewAccount()
        {
            IOrganizationService service = ConnectionFactory.GetService();

            Entity account = AccountService.GetAccount();

            Guid accountId = service.Create(account);
            Console.WriteLine("\nVocê deseja criar um contato para essa conta ? (S / N)");
            string c = Console.ReadLine().ToUpper();

            switch (c)
            {
                case "S":
                    Entity contact = ContactService.GetContact(accountId);
                    service.Create(contact);
                    break;
                case "N":
                    Console.WriteLine("\nEncerrando o Programa...");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

            Console.WriteLine("\nPresione qualquer tecla para encerra o programa...");
            Console.ReadLine();
        }
    }
}
