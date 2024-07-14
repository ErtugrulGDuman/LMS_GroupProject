using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer._2_AdminAreaDto.InstructorDto.ForumDto
{
    public class UpdateForumDto
    {
        public int ForumId { get; set; }
        public string GeneralQuestions { get; set; }
        public string LessonQuestions { get; set; }
        public string ScoreBoard { get; set; }
    }
}
