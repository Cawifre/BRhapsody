using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Flow
{
    public sealed class VerseThree : IVerse
    {
        public VerseThree(TextWriter output)
        {
            Output = output;
        }

        private TextWriter Output { get; }

        public void Play()
        {
            Output.WriteLine("..."); //TODO: Finish verse 3
        }
    }
}
