namespace Exam_Jeopardy.Objects
{
    public class Round
    {
        private const int NumberOfRows = 5;
        private const int NumberOfCols = 6;
        private readonly Question[,] _questions;
        private readonly string[] _categories;

        public Round()
        {
            _questions = new Question[NumberOfRows, NumberOfCols];
            _categories = new string[NumberOfCols];
            for (int i = 0; i < NumberOfCols; i++)
            {
                _categories[i] = "Not set";
                for (int j = 0; j < NumberOfRows; j++)
                {
                    _questions[i, j] = new Question();
                }
            }
        }

        public virtual Question GetQuestion(int x, int y)
        {
            return _questions[x, y];
        }

        public virtual void SetQuestion(int x, int y, Question q)
        {
            _questions[x, y] = q;
        }

        public virtual string GetCategory(int x)
        {
            return _categories[x];
        }

        public virtual void SetCategory(int x, string c)
        {
            _categories[x] = c;
        }
    }
}
