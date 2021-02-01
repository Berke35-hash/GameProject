using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(int ıd);
        void Update(int ıd);
        void Apply(Campaign campaign, Sale sale);
    }
}
