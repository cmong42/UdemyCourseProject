using System;
using AutoMapper;
using Vidly.Models;
namespace Vidly2.Dtos
{
    public class MappingProfile: Profile 
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
