using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace MNhat_DotNetCore.Models.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Vui lòng nhập kí tự ")]
        [MinLength(2, ErrorMessage = " Nhập ít nhất là 2 kí tự ")]
        [MaxLength(10, ErrorMessage = " Nhập không quá 10 kí tự ")]
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
