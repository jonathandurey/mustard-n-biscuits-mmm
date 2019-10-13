using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBModels.Models
{
    public class Response:BaseViewModel
    {
        public override Response Validate()
        {
            return new Response() { IsSuccess = true };
        }
        public bool IsSuccess { get; set; }

    }
}
