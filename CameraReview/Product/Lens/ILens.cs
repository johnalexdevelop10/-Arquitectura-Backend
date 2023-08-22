using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReview.Product.Lens
{
    public interface ILens : IProduct //aqui extiende las prop/ en comun de Iprodcut a lens 
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string SKU { get; set; }
    }
}
