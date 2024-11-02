using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using MongoDB.Driver;
using HandyApp.Services;
using HandyApp.Buyer;
using HandyApp.Seller;
using HandyApp.Messages;
using HandyApp.Orders;

namespace HandyApp.MongoDB;

[ConnectionStringName("Default")]
public class HandyAppMongoDbContext : AbpMongoDbContext
{

    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    public IMongoCollection<Service> Services => Collection<Service>();
    public IMongoCollection<BuyerProfile> Buyers => Collection<BuyerProfile>();
    public IMongoCollection<SellerProfile> Sellers => Collection<SellerProfile>();
    public IMongoCollection<Message> Messages => Collection<Message>();
    public IMongoCollection<Order> Orders => Collection<Order>();
    //public IMongoCollection<SellerProfile> Sellers => Collection<SellerProfile>();



    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
