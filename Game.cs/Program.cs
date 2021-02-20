using Game.cs.Abstract;
using Game.cs.Concrate;
using Game.cs.Entities;
using System;

namespace Game.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            { DateOfBirth = new DateTime(2002, 4, 8), FirstName = "Sümeyra", LastName = "Karsavran", Id = 1, NationalityId = "2737123" };
            BaseGamerManager gamerManager = new GamerManager(new PersonCheckManager());
            gamerManager.Save(gamer);

            Campaign campaign = new Campaign { CampaignName = "%20 indirim", CampaignRate = 0.2 };

            Product product1 = new Product { Id = 1, ProductName = "Sims4", ProductPrice = 120 };
            Product product2 = new Product { Id = 2, ProductName = "PUBG", ProductPrice = 100 };

            ISalesService salesService = new SalesManager();
            salesService.CampaignSale(product1, gamer, campaign);

        }
    }
}
