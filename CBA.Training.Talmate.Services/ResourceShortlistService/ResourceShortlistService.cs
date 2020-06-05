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
        //public async Task<IQueryable<ResourceShortlistService>> GetResource()
        //{
        //    var resource = _DbContext.ResourceShortlist.AsQueryable().OrderBy(c => c.PrimarySkills);
        //    return await Task.FromResult(resource);


        //}

        //public async Task<bool> Post(ResourceShortlistService resourceShortlist)
        //{
        //    if (resourceShortlist != null)
        //    {
        //        _talmateDbContext.Demands.Add(resourceShortlist);
        //        var result = _talmateDbContext.SaveChanges();
        //        if (result > 0)
        //            return await Task.FromResult(true);
        //    }

        //    return await Task.FromResult(false);
        //}
    

}
}
