using System;
using System.Collections.Generic;
using System.Text;
using CBA.Training.Talmate.EntityModels;

namespace CBA.Training.Talmate.Services.UserService
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
