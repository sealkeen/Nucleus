using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nucleus.Core
{
    public interface ISimpleEntity
    {
        public DateTime CreationDate { get; set; }
    }
}