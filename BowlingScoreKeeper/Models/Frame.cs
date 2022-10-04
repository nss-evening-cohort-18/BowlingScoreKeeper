using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreKeeper.Models;

public class Frame
{
    public Frame(int firstBall, int secondBall)
    {
        FirstBallScore = firstBall;
        SecondBallScore = secondBall;
    }
    public int FirstBallScore { get; set; }
    public int SecondBallScore { get; set; }
    public int ExtraThrows { get; set; }
    public int Score => FirstBallScore + SecondBallScore + ExtraThrows;
    public bool IsStrike => FirstBallScore == 10;
    public bool IsSpare => !IsStrike && (FirstBallScore + SecondBallScore == 10);
}
