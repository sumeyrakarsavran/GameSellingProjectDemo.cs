using Game.cs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Abstract
{
    public interface ISalesService
    {
        void Sell(Product product, Gamer gamer);
        void CampaignSale(Product product, Gamer gamer, Campaign campaign);
    }
}
