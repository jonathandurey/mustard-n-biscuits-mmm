using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBModels.Models
{
    public abstract class BaseViewModel
    {
        public abstract Response Validate();
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public List<string> ErrorMessages { get; set; }
        public BaseViewModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
