using CBA.Training.Talmate.EntityModels;
using CBA.Training.Talmate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Services.ResourceDetailsservice
{
  public  class ResourceDetailsservice : IResourceDetailsService
    {
        private readonly TalmateDbContext _talmateDbContext;
        public ResourceDetailsservice(TalmateDbContext talmateDbContext)
        {
            _talmateDbContext = talmateDbContext;
        }
        public async Task<IQueryable<ResourceDetail>> Get()
        {
            var resource = _talmateDbContext.ResourceDetails.AsQueryable();
            return await Task.FromResult(resource);
            // return await Task.FromResult(_talmateDbContext.Users.AsQueryable());
        }
        public async Task<ResourceDetail> GetById(int id)
        {
            var resource = _talmateDbContext.ResourceDetails.AsQueryable().FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(resource);
        }
        public async Task<bool> Post(ResourceShortlisted resource)
        {
            if (resource != null)
            {
                _talmateDbContext.ResourceShortlist.Add(resource);
                var result = _talmateDbContext.SaveChanges();
                if (result > 0)
                    return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }







    }
}
