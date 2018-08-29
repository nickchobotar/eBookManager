using System;

// use of extension methods 
//    extension methods need to be static in nature 
//    in order to act on the various objects defined by the extension methods

namespace eBookManager.Helper
{
    public static class ExtensionMethods
    {
        /// <summary>
        ///  take a string value and try to parse it to an integer value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultInteger"></param>
        /// <returns></returns>
        public static int ToInt(this string value, int defaultInteger = 0)
        {
            try
            {
                if (int.TryParse(value, out int validInteger))
                    // Out variables 
                    return validInteger;
                else
                    return defaultInteger;
            }
            catch
            {
                return defaultInteger;
            }
        }
    }
}
