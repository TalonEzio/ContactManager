using AutoMapper;
using ContactManager.Domain.Entities;

namespace ContactManager.App.ViewModels
{
    public class MapperClass : Profile
    {
        public MapperClass()
        {

            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<Phone, PhoneViewModel>().ReverseMap();
            CreateMap<Email, EmailViewModel>().ReverseMap();


            CreateMap<EmailModelType, EmailType>().ReverseMap();
            CreateMap<PhoneModelType, PhoneType>().ReverseMap();


        }
    }
}
