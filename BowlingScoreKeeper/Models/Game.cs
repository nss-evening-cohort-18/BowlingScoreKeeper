using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreKeeper.Models;

public class Game
{
    public Game()
    {
        Frames = new Frame[11];
    }

    public Frame[] Frames { get; set; }
    public int TotalScore => Frames.Sum(f => f.Score);

}
