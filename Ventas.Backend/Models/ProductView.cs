using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas.Backend.Models
{
    using System.Web;
    using Common.Models;

    public class ProductView : Product
    {
        public HttpPostedFileBase ImageFile { get; set; }
    }
}