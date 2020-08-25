namespace CSharpBasics.Extension
{
    public static class IntExtention
    {
        public static string GetEmployeeCodeWithCompanyName(this string value, string append)
        {
            return $"{value}---{append}";
        }

        public static string GetService(this NeedsExtension needsExtension)
        {
            return "NeedsExtension";
        }

        public static string ToString(this string value)
        {
            return "override existing ToString()";
        }
    }
}
