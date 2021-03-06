﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class RegisterHostModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

    }


    public class RegisterGuestModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }   

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Pin")]
        public string Pin { get; set; }
    }

    public class RegisterAdminModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }


    public class LoginModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; }



    }

    public class ReturnHostModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
            

        [Display(Name = "Events")]
        public IEnumerable<EventModel> Events { get; set; }
    }

    public class ChangePassModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        //[Compare("Current Password", ErrorMessage = "The new password must be different from the old one.")]
        public string NewPassword { get; set; }
    }


    public class ChangeEmailModel
    {
        [Required]
        [Display(Name = "Old Email")]
        public string OldEmail { get; set; }

        [Required]
        [Display(Name = "New Email")]
        public string NewEmail { get; set; }
    }
}
