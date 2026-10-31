using EStoreAdminModel.Brands;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository;

namespace EstoreAdminService
{
    public class BrandService : IBrandService
    {
        private readonly BrandRepository _brandRepository;

        public BrandService(BrandRepository brandRepository)
        {
            this._brandRepository = brandRepository;
        }

        public void CreateBrand(CreateBrandModel createBrandModel)
        {
            if (createBrandModel == null)
                throw new Exception("Create Brand Model Object is null or Empty");

            BrandModel brandModel = new BrandModel()
            {
                Id = Guid.NewGuid(),
                Name = createBrandModel.Name
            };

            this._brandRepository.Add(brandModel);
            this._brandRepository.SaveChanges();
        }

        public List<BrandModel> ListBrands()
        {
            List<BrandModel> brandModels = 
                this._brandRepository.Brands.ToList();

            return brandModels;
        }


    }
}
