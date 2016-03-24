using System;

namespace USQLApplication1
{
    public static class Helpers
    {
        public static bool TryParseInt(string column)
        {
            int result;
            return Int32.TryParse(column, out result);
        }
    }
}
