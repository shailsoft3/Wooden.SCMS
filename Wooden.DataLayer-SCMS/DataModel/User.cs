using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wooden.DataLayer_SCMS.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }=String.Empty;
        public string? MiddleName { get; set; }
    }
}
