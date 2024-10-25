using HandyApp.Buyer;
using HandyApp.HandymanApplicationCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.FirstInstall
{
    public class BuyerProfileDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<BuyerProfile, Guid> _buyerProfileRepository;

        public BuyerProfileDataSeederContributor(IRepository<BuyerProfile, Guid> buyerProfileRepository)
        {
            _buyerProfileRepository = buyerProfileRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _buyerProfileRepository.GetCountAsync() <= 0)
            {
                var buyer = new BuyerProfile
                {
                    Name = "Jane Smith",
                    UserType = UserType.Buyer,
                    CreatedDate = DateTime.Now,
                    PastRequestedServices = new List<Services.Service>()
                };

                await _buyerProfileRepository.InsertAsync(buyer, autoSave: true);
            }
        }
    }
}
