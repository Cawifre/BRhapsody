using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Flow
{
    public sealed class VerseOne : IVerse
    {
        public VerseOne(TextWriter output)
        {
            Output = output;
        }

        private TextWriter Output { get; }

        public void Play()
        {
            Output.WriteLine("."); //TODO: Finish verse 1
        }
    }
}
