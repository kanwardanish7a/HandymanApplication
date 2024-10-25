using AutoMapper;
using HandyApp.Buyer;
using HandyApp.Seller;
using HandyApp.Services;

namespace HandyApp;

public class HandyAppApplicationAutoMapperProfile : Profile
{
    public HandyAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<BuyerProfile, BuyerProfileDto>();
        CreateMap<SellerProfile, SellerProfileDto>();
        CreateMap<Services.Service, ServiceDto>();


        CreateMap<CreateUpdateBuyerProfileDto, BuyerProfileDto>();
        CreateMap<CreateUpdateSellerProfileDto, SellerProfileDto>();
        CreateMap<CreateUpdateServiceDto, ServiceDto>();


    }
}
