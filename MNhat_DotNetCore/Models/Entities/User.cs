using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace MNhat_DotNetCore.Models.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Vui lòng nhập kí tự ")]
        [MinLength(2, ErrorMessage = " Nhập ít nhất là 2 kí tự ")]
        [MaxLength(10, ErrorMessage = " Nhập không quá 10 kí tự ")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Vui lòng nhập địa chỉ email vào ")]
        [MinLength(5, ErrorMessage = " Nhập ít nhất là 5 kí tự ")]
        [MaxLength(50, ErrorMessage = " Nhập không quá 50 kí tự ")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Vui lòng nhập kí tự ")]
        [MinLength(10, ErrorMessage = " Nhập ít nhất là 10 kí tự ")]
        [MaxLength(10, ErrorMessage = " Nhập không quá 10 kí tự ")]
        public string Phone { get; set; }
        [Required(ErrorMessage = " Vui lòng nhập địa chỉ vào ")]
        [MinLength(5, ErrorMessage = " Nhập ít nhất là 5 kí tự ")]
        [MaxLength(50, ErrorMessage = " Nhập không quá 50 kí tự ")]
        public string Address { get; set; }
    }
}
