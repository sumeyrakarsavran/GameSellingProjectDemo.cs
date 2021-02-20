using Game.cs.Abstract;
using Game.cs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Concrate
{
    class SalesManager : ISalesService
    {
        public void CampaignSale(Product product, Gamer gamer, Campaign campaign)
        {
            double discountedSale = product.ProductPrice - (product.ProductPrice * campaign.CampaignRate);
            Console.WriteLine(product.ProductName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " adlı kullanıcıya " + campaign.CampaignName +
                              " kampanyası ile " + discountedSale + " fiyatla satıldı");
        }

        public void Sell(Product product, Gamer gamer)
        {
            Console.WriteLine(product.ProductName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " adlı kullanıcıya " + product.ProductPrice + " fiyatla satıldı");
        }
    }
}
