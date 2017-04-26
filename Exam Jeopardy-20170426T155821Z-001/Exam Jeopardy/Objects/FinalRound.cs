using System.Xml.Serialization;

namespace Exam_Jeopardy.Objects
{
    public class FinalRound : Round
    {
        [XmlElement("question")]
        private Question _question;
        [XmlElement("category")]
        private string _category;

        public FinalRound()
        {
            _question = new Question();
            _category = "Not set";
        }

        public override Question GetQuestion(int x, int y)
        {
            return _question;
        }

        public override void SetQuestion(int x, int y, Question q)
        {
            _question = q;
        }

        public override string GetCategory(int x)
        {
            return _category;
        }

        public override void SetCategory(int x, string c)
        {
            _category = c;
        }
    }
}