using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<AddressManager>().As<IAddressService>();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<CategoryHiearchyManager>().As<ICategoryHiearchyService>();
            builder.RegisterType<EfCategoryHiearchyDal>().As<ICategoryHiearchyDal>();

            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfCityDal>().As<ICityDal>();

            builder.RegisterType<CompanyContactManager>().As<ICompanyContactService>();
            builder.RegisterType<EfCompanyContactDal>().As<ICompanyContactDal>();

            builder.RegisterType<CompanyDetailManager>().As<ICompanyDetailSerivce>();
            builder.RegisterType<EfCompanyDetailDal>().As<ICompanyDetailDal>();

            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();

            builder.RegisterType<DistrictManager>().As<IDistrictService>();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>();

            builder.RegisterType<MainCategoryManager>().As<IMainCategoryService>();
            builder.RegisterType<EfMainCategoryDal>().As<IMainCategoryDal>();

            builder.RegisterType<OptionManager>().As<IOptionService>();
            builder.RegisterType<EfOptionDal>().As<IOptionDal>();

            builder.RegisterType<OptionGroupManager>().As<IOptionGroupService>();
            builder.RegisterType<EfOptionGroupDal>().As<IOptionGroupDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ProductBrandManager>().As<IProductBrandService>();
            builder.RegisterType<EfProductBrandDal>().As<IProductBrandDal>();

            builder.RegisterType<ProductCatHiearchyManager>().As<IProductCatHiearchyService>();
            builder.RegisterType<EfProductCatHiearchyDal>().As<IProductCatHiearchyDal>();

            builder.RegisterType<ProductOptionManager>().As<IProductOptionService>();
            builder.RegisterType<EfProductOptionDal>().As<IProductOptionDal>();

            builder.RegisterType<ProductProductImageManager>().As<IProductProductImageService>();
            builder.RegisterType<EfProductProductImageDal>().As<IProductProductImageDal>();

            builder.RegisterType<ProductReviewManager>().As<IProductReviewService>();
            builder.RegisterType<EfProductReviewDal>().As<IProductReviewDal>();

            builder.RegisterType<ProductImageManager>().As<IProductImageService>();
            builder.RegisterType<EfProductImageDal>().As<IProductImageDal>();

            builder.RegisterType<ProductMetaManager>().As<IProductMetaService>();
            builder.RegisterType<EfProductMetaDal>().As<IProductMetaDal>();

            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>();
            builder.RegisterType<EfSubCategoryDal>().As<ISubCategoryDal>();

            builder.RegisterType<UnitManager>().As<IUnitService>();
            builder.RegisterType<EfUnitDal>().As<IUnitDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}
