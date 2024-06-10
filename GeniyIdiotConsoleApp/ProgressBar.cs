using System.Text;

namespace GeniyIdiotConsoleApp
{
    public class ProgressBar
    {
        public int Length { get; private set; }
        private int currentProgress;
        public int MaxValue { get; private set; } 
        private int fillPosition;

        public ProgressBar()
        {
            Length = 30;
            currentProgress = 0;
            MaxValue = 1000;
        }

        public void IncreaseProgresse(int value)
        {
            currentProgress += value;
            fillPosition = currentProgress * Length / MaxValue;
        }

        public string GetProgressBar()
        {
            var result = new StringBuilder(Length);

            for (int i = 0; i < Length; i++)
            {
                if (i < fillPosition)
                {
                    result.Append('\u2588');
                }
                else result.Append('\u2591');
            }
            return result.ToString();
        }
    }
}
