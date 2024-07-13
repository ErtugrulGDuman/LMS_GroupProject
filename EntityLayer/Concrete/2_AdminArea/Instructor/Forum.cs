using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.EntityLayer.Concrete
{
    public class Forum
    {
        public int ForumId { get; set; }
        public string GeneralQuestions { get; set; }
        public string LessonQuestions { get; set; }
        public string ScoreBoard { get; set; }
    }
}
