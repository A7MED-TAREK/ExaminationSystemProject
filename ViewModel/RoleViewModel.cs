﻿using System.ComponentModel.DataAnnotations;

namespace ExaminationSystemProject.ViewModel
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
        public int UserID { get; set; }
    }
}
