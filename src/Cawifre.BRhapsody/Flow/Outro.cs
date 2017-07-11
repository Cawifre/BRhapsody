using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Flow
{
    public sealed class Outro : IVerse
    {
        public Outro(TextWriter output, TextReader input)
        {
            Output = output;
            Input = input;
        }

        private TextWriter Output { get; }
        private TextReader Input { get; }

        public void Play()
        {
            Output.WriteLine("....."); //TODO: Finish outro
        }
    }
}
