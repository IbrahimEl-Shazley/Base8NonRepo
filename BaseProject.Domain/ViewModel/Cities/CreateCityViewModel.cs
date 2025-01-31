﻿using System.ComponentModel.DataAnnotations;

namespace BaseProject.Domain.ViewModel.Cities
{
    public class CreateCityViewModel
    {
        [Required(ErrorMessage = "من فضلك ادخل اسم المدينة بالعربية ")]
        public string NameAr { get; set; }
        [Required(ErrorMessage = "من فضلك ادخل اسم المدينة بالانجليزية")]
        public string NameEn { get; set; }
    }
}
