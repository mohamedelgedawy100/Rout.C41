﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rout.C41.DAL.Model
{
    public class Department
    {
        public int Id { get; set; }
    
        public string Name { get; set; }


        public string Code { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}
