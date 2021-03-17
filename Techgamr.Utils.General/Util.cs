namespace Techgamr.Utils.General
{
    public static class Util
    {
        public static string ArrayToString(object[] array, string separator = ", ") => $"[{string.Join(separator, array)}]";
    }
}
