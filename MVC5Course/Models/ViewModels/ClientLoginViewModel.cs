using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ViewModels
{
    public class ClientLoginViewModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "{0} 最大不得超過 {1} 個字元")]
        [DisplayName("名")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "{0} 最大不得超過 {1} 個字元")]
        [DisplayName("中間名")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} 最大不得超過 {1} 個字元")]
        [DisplayName("姓氏")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("[MF]", ErrorMessage = "{0} 欄位只能輸入 M 或 F ")]
        [DisplayName("性別")]
        public string Gender { get; set; }


        [DisplayName("生日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

    }
}