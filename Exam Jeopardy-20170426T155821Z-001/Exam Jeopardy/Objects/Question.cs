using System.Xml.Serialization;

namespace Exam_Jeopardy.Objects
{
    public class Question
    {
        [XmlElement("pointValue")]
        public int PointValue { get; set; }
        [XmlElement("text")]
        public string Text { get; set; }
        [XmlElement("answers")]
        public string[] Answers { get; set; }

        public Question()
        {
            PointValue = 0;
            Text = "Why haven't you defined a question yet?";
            Answers = new[] {"I haven't thought of one", "I just haven't typed them up yet"};
        }
    }
}
