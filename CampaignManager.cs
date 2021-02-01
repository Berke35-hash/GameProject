using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Apply(Campaign campaign, Sale sale)
        {
            Console.WriteLine(campaign.CampaignName + " uygunaldı");
        }

        public void Delete(int ıd)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(int ıd)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
