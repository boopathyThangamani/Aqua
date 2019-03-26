using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaContext;
using AquaVM;
using AutoMapper;
using AquaContext = AquaContext.AquaContext;
using System.ComponentModel;

namespace AquaBL
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            ConfigureMapper();
        }

        /// <summary>
        /// Automapper mappings for read only view models
        /// </summary>
        public static void ConfigureMapper()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<UserMaster, UserMasterVM>()
                .ForMember(uvm => uvm.DepartmentName, opt => opt.MapFrom(u => u.DepartmentMaster.Name))
                .ReverseMap();

                x.CreateMap<global::AquaContext.DepartmentMaster, DepartmentMasterVM>()
                .ReverseMap();

                x.CreateMap<UserModuleEntitlementMapping, UserModuleEntitlementMappingVM>()
                .ForMember(umevm => umevm.UserName, opt => opt.MapFrom(u => u.UserMaster.Name))
                .ForMember(umevm => umevm.ModuleName, opt => opt.MapFrom(u => u.ModuleReference.ModuleDescription))
                .ForMember(umevm => umevm.ModuleCode, opt => opt.MapFrom(u => u.ModuleReference.ModuleCode))
               .ReverseMap();

                x.CreateMap<UserMasterVM, UserLoginVM>()
                .ReverseMap();

                x.CreateMap<AccountMaster, AccountMasterVM>()
                .ForMember(umevm => umevm.AccountGroupMasterName, opt => opt.MapFrom(u => u.AccountGroupMaster.Name))
                .ForMember(umevm => umevm.AccountTypeMasterName, opt => opt.MapFrom(u => u.AccountTypeMaster.Name))
               .ReverseMap();

                x.CreateMap<global::AquaContext.AccountTypeMaster, AccountTypeMasterVM>()
                .ReverseMap();

                x.CreateMap<global::AquaContext.AccountGroupMaster, AccountGroupMasterVM>()
                .ReverseMap();

                x.CreateMap<SalaryDeclaration, SalaryDeclarationVM>()
                .ForMember(uvm => uvm.UserName, opt => opt.MapFrom(u => u.UserMaster.Name))
                .ReverseMap();

                x.CreateMap<global::AquaContext.SalaryPayment, SalaryPaymentVM>()
                .ForMember(uvm => uvm.UserName, opt => opt.MapFrom(u => u.UserMaster.Name))
                //.ForMember(uvm => uvm.isCash, opt => opt.MapFrom(u => Convert.ToBoolean(Convert.ToInt32(u.IsCash))))
                //.ForMember(uvm => Convert.ToBoolean(Convert.ToInt32(uvm.IsCash)), opt => opt.MapFrom(u => u.IsCash))

                .ReverseMap();

                x.CreateMap<Journal, JournalVM>().ReverseMap();

                //mapping for accountmaster while saving user
                //x.CreateMap<UserMasterVM, AccountMaster>()
                //    .ForMember(am => am.Name, opt => opt.MapFrom(uvm => uvm.Name))
                //    .ForMember(am=>am.OpeningBalance, opt => opt.MapFrom((uvm=>uvm.OpeningBalance)))
                //    .ForMember(am => am.OpeningBalanceType, opt => opt.MapFrom((uvm => uvm.OpeningBalanceType)));
                //    .ForMember(am => am.CreatedBy, opt => opt.MapFrom((uvm => uvm.CreatedBy)))
                //    .ForMember(am => am.CreatedDateTime, opt => opt.MapFrom((uvm => uvm.CreatedDateTime)))
                //.ForMember(am => am.ModifiedBy, opt => opt.MapFrom((uvm => uvm.ModifiedBy)));
            });
        }
    }
}
