using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2001,
                FirstName = "ENES",
                LastName = "Ceylan",
                IdentityNumber = 12345
            }
            );
            Console.WriteLine("****************************************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaingId = 1,
                CampaignName = "If you buy this product second product 50% off",
                CampaingDetail = "The campaign will end at the end of July 2021."
            });
            Console.WriteLine("****************************************************" );

            OrderManager orderManager = new OrderManager();
            orderManager.MakeSale(new Products
            {
                ProductId = 1,
                ProductName = "E-Run",
                UnitPrice = 100,
                Stock = 250
            });
        }
    }

}
