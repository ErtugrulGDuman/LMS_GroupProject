using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.SiteArea.RegisterArea
{
    public class RegisterSubject
    {
        public int RegisterSubjectId { get; set; }
        public string SubjectName { get; set; }
        public int RegisterId { get; set; }
        public virtual Register Register { get; set; }
    }
}
