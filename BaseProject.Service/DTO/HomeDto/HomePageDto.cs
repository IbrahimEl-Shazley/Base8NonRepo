using BaseProject.Services.DTO.CategoryDto;
using BaseProject.Services.DTO.ProductDto;
using BaseProject.Services.DTO.RegionDto;

namespace BaseProject.Services.DTO.HomeDto
{
    public class HomePageDto
    {
        public IReadOnlyList<CategoryListDto> CategoryListDtos { get; set; }
        public IReadOnlyList<CategoryListDto> CategoryListSideMenuDtos { get; set; }
        public IReadOnlyList<RegionListDto> RegionListDtos { get; set; }
        public IReadOnlyList<ProductListDto> ProductListDtos { get; set; }

    }
}
