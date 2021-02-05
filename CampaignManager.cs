using System;

namespace MyGame
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
