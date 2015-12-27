using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Data.Services.Interfaces;
using BaseApp.Domain.Managers.Interfaces;
using BaseApp.Model.Models.Domain;

namespace BaseApp.Domain.Managers
{
    public class MemberManager : IMemberManager
    {
        private readonly IMembershipService _membershipService;

        public MemberManager(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        public User GetUserById(string userId)
        {
            return _membershipService.GetById(userId);
        }
    }
}
