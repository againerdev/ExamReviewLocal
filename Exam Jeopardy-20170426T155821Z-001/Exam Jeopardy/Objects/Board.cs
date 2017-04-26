using System.Xml.Serialization;

namespace Exam_Jeopardy.Objects
{
    [XmlRoot("board")]
    class Board
    {
        [XmlElement("rounds")]
        private readonly Round[] _rounds;

        public Board(int numRounds, bool finalJeopardy)
        {
            _rounds = new Round[numRounds];
            for (int i = 0; i < (finalJeopardy ? numRounds : numRounds - 1); i++)
            {
                _rounds[i] = new Round();
            }
            if (finalJeopardy)
            {
                _rounds[_rounds.Length - 1] = new FinalRound();
            }
        }

        public Round GetRound(int roundNumber)
        {
            return _rounds[roundNumber];
        }

        public int GetNumRounds()
        {
            return _rounds.Length;
        }
    }
}
