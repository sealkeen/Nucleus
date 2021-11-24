using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nucleus.Core.Exceptions
{
    public class NucleusCoreException : Exception, ISimpleEntity
    {
        public NucleusCoreException(string message) : base(message)
        {

        }
        [Key]
        public long Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
