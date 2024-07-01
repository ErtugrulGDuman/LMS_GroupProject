using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Conrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string MailAdresi { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
