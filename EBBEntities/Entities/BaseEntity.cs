using System;
using System.Collections.Generic;
using System.Text;

namespace EBBEntities.Entities
{
    public abstract class BaseEntity
    {
        public List<string> ErrorMessages { get; set; }
        public BaseEntity()
        {
            ErrorMessages = new List<string>();
        }
    }
}
