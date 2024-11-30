using System;

namespace Score
{
    public sealed class ScoreCounter
    {
        public event Action OnScoreChanged;

        public int Score { get; private set; }

        public void AdScore(int score)
        {
            Score += score;
            OnScoreChanged?.Invoke();
        }
    }
}