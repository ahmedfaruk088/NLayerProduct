using Class.DataAccessLayer.Abstract;
using Class.DataAccessLayer.Repositories;
using Class.EntitLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DataAccessLayer.EntityFramework
{
    public class EFCategoryDal: GenericRepository<Category>, ICategoryDal
    {
    }
}
