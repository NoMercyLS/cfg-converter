namespace CfgConverter
{
    public struct Constants
    {
        public const string InvalidArgumentsExceptionMessage =
            "Invalid arguments count!\nUsage: CfgConverter.exe \"<input file>\" \"<output file>\"\nThe output file is optional, if there is no output file name, the converted cfg will be output to the console\n";

        public const string ArgumentNullExceptionMessage =
            "Null argument.\nUsage: CfgConverter.exe \"<input file>\" \"<output file>\"\n";
    }
}