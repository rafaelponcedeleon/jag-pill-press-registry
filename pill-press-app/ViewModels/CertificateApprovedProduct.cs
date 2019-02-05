﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Gov.Jag.PillPressRegistry.Public.ViewModels
{    

    public class CertificateApprovedProduct
    {
        public string id { get; set; }

        public string name { get; set; }        
    }
}
