﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace Bai3.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy", 
                CultureInfo.CurrentCulture , 
                DateTimeStyles.None , 
                out dateTime);  
            return (isValid && dateTime > DateTime.Now);
        }
        

    }
}