using Class.EntitLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.BusinessLayer.Abstract
{
    public interface IProductService: IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
        

        
    }
}
