using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scoreList = null;
    public HighScores(List<int> list) => _scoreList = list.ToList();
    public List<int> Scores() =>_scoreList;
    public int Latest() => _scoreList.LastOrDefault();

    public int PersonalBest() => _scoreList.Max();
    public List<int> PersonalTopThree() => _scoreList.OrderByDescending(x => x).Take(3).ToList();
}

