using EStoreAdminModel.Brands;
using EStoreAdminModel.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace EStoreAdminModule.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        /// <summary>
        /// Initializes a new instance of the BrandController class.
        /// </summary>
        /// <param name="brandService">Service for managing brand operations.</param>
        public BrandController(IBrandService brandService)
        {
            this._brandService = brandService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            List<BrandModel> brandModels = null;

            brandModels = this._brandService.ListBrands();

            //ModelBinding / ViewModel
            return View(brandModels);
        }

        [HttpGet]
        [Route("CreateBrand")]
        public IActionResult CreateBrand()
        {
            return View("CreateBrand");
        }

        [HttpPost]
        [Route("CreateBrand")]
        public IActionResult CreateBrand(CreateBrandModel createBrandModel)
        {

            this._brandService.CreateBrand(createBrandModel);

            return RedirectToAction("Index");
        }
    }
}
