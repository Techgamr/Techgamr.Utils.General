namespace Techgamr.Utils.General
{
    public static class Util
    {
        public static string ArrayToString(object[] array, string separator = ", ") => $"[{string.Join(separator, array)}]";

        // ReSharper disable once ParameterTypeCanBeEnumerable.Global
        public static string ArrayToString<TArray>(TArray[] array, string separator = ", ") => $"[{string.Join(separator, array)}]";
    }
}
