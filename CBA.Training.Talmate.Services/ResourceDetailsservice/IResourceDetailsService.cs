using CBA.Training.Talmate.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Services.ResourceDetailsservice
{
    public interface IResourceDetailsService
    {
        Task<IQueryable<ResourceDetail>> Get();
        Task<bool> Post(ResourceShortlisted resource);
        Task<ResourceDetail> GetById(int id);
    }
}
