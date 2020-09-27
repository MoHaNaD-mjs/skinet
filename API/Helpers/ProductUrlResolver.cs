using API.Dtos;
using AutoMapper;
using Core.Entities;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _contfig;

        public ProductUrlResolver(IConfiguration contfig)
        {
            _contfig = contfig;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember,
         ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _contfig["ApiUrl"] +source.PictureUrl;
            }
            return null;
        }
    }
}