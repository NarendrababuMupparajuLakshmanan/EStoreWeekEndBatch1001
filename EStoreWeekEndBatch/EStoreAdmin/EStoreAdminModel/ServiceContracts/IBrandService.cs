using EStoreAdminModel.Brands;

namespace EStoreAdminModel.ServiceContracts
{
    public interface IBrandService
    {
        List<BrandModel> ListBrands();

        void CreateBrand(CreateBrandModel createBrandModel);
    }
}
