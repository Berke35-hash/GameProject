using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { BirthYear = 1999, FirstName = "Berke", LastName = "Özden", ID = 1, IdendityNumber = 123123 });

            Sale saleGame = new Sale{ Id = 1, GameName = " Fifa21", GamePrice = 350};
            Sale saleGame2 = new Sale{ Id = 2, GameName = " NBA 2K 2021", GamePrice = 210};

            Campaign campaign = new Campaign { ID = 1, CampaignName = "Herkese Ucuz Oyun", CampaignDetail = "%50 indirim" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            if(campaign.ID == 1)
            {
                ICampaignService campaignService = new DiscountCampaignManager();
                campaignService.Apply(campaign, saleGame);
                campaignService.Apply(campaign, saleGame2);
            }
            else
            {
                SalesManager saleManager = new SalesManager();
                saleManager.Buy(saleGame);
            }


        }
    }
}
