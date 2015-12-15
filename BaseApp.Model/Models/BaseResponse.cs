using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.Models
{
    public abstract class BaseResponse
    {
        private List<string> _errorMessages = new List<string>();

        public List<string> ErrorMessages
        {
            get { return _errorMessages; }
            set { _errorMessages = value ?? new List<string>(); }
        }

        public bool HasErrors => ErrorMessages.Any();
    }
}
