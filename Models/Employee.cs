using System;    
using System.Collections.Generic;    
using System.ComponentModel.DataAnnotations;    
using System.Linq;    
using System.Threading.Tasks;    
    
namespace EmployeeList_DotNetCore_ADO_DotNET.Models    
{    
    public class Employee    
    {    
        public int ID { get; set; }    
        [Required]    
        public string Name { get; set; }    
        [Required]    
        public string Gender { get; set; }    
        [Required]    
        public string Department { get; set; }    
        [Required]    
        public string City { get; set; }    
    }    
}  
