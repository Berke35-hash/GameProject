using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class DiscountCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("İndirimli kampayna eklendi");
        }

        public void Apply(Campaign campaign, Sale sale)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası" + sale.GameName + " e uygulanmıştır "+" Ürünün fiyatı:"+ sale.GamePrice );
        }

        public void Delete(int ıd)
        {
            Console.WriteLine("İndirimli kampayna silindi");
        }

        public void Update(int ıd)
        {
            Console.WriteLine("İndirimli kampayna güncellendi");
        }
    }
}
