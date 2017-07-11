using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Flow
{
    public sealed class Intro : IVerse
    {
        public Intro(TextWriter output)
        {
            Output = output;
        }

        private TextWriter Output { get; }

        public ILife Life { private get; set; }

        public void Play()
        {
            if (Life is RealLife)
            {
                Output.WriteLine($"It's {nameof(RealLife)}.");
            }
            else if (Life is FantasyLife)
            {
                Output.WriteLine($"It's {nameof(FantasyLife)}.");
            }
            else
            {
                throw new MissingLifeException("Need to get a life");
            }
            
            Output.WriteLine("Err... *Gentle humming*"); //TODO: Finish intro
        }
    }
}
