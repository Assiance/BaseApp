using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Web.Infrastructure.Services.Interfaces
{
    public interface ICurrentUserService
    {
        User GetCurrentUser();
    }
}
