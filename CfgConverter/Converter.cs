using System.IO;

namespace CfgConverter
{
    public class Converter
    {
        private readonly TextReader _input;
        private readonly TextWriter _output;

        public Converter(TextReader input, TextWriter output)
        {
            _input = input;
            _output = output;
        }

        public void Convert()
        {
            var consoleLine = "";
            string buffer;
            while ((buffer = _input.ReadLine()) != null)
            {
                if (buffer.Length <= 0) continue;
                buffer += ';';
                consoleLine += buffer;
            }
            _output.WriteLine(consoleLine);
        }
    }
}