using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Flow
{
    public sealed class VerseTwo : IVerse
    {
        public VerseTwo(TextWriter output)
        {
            Output = output;
        }

        private TextWriter Output { get; }

        public void Play()
        {
            Output.WriteLine(".."); //TODO: Finish verse 2
        }
    }
}
