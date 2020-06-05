using CBA.Training.Talmate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Services.ResourceShortlistService
{
    class ResourceShortlistService:IResourceShortlistService
    {

        private readonly TalmateDbContext _DbContext;
        public ResourceShortlistService(TalmateDbContext talmateDbContext)
        {
            _DbContext = talmateDbContext;
        }
        


    }
}
