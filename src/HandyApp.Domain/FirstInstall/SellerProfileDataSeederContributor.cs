using HandyApp.HandymanApplicationCommon;
using HandyApp.Seller;
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
    public class SellerProfileDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<SellerProfile, Guid> _sellerProfileRepository;

        public SellerProfileDataSeederContributor(IRepository<SellerProfile, Guid> sellerProfileRepository)
        {
            _sellerProfileRepository = sellerProfileRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _sellerProfileRepository.GetCountAsync() <= 0)
            {
                var seller = new SellerProfile
                {
                    Name = "John Doe",
                    UserType = UserType.Seller,
                    CreatedDate = DateTime.Now,
                    PastOrders = new List<Services.Service>(),
                    CurrentOrders = new List<Services.Service>(),
                    MyGigs = new List<Services.Service>()
                };

                await _sellerProfileRepository.InsertAsync(seller, autoSave: true);
            }
        }
    }
}
