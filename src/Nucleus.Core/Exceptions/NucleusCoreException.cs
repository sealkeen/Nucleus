using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nucleus.Core.Exceptions
{
    public class NucleusCoreException : ISimpleEntity
    {
        [Key]
        public long Id { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public NucleusCoreException(string message)
        {
            Message = message;
        }
    }
}
