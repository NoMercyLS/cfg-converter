using System;
using System.IO;
using static CfgConverter.Constants;

namespace CfgConverter
{
    internal static class Program
    {
        private static void ParseArguments(string[] args)
        {
            if (args == null) throw new ArgumentNullException(ArgumentNullExceptionMessage);
            if (args.Length > 2 || args.Length < 1) throw new ArgumentException(InvalidArgumentsExceptionMessage);
            }
        
        public static void Main(string[] args)
        {
            try
            {
                ParseArguments(args);
                var input = new StreamReader(args[0]);
                var output = args.Length == 2 ? new StreamWriter(args[1]) : Console.Out;
                var converter = new Converter(input, output);
                converter.Convert();
                input.Close();
                output.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}