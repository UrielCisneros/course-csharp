namespace TaskMaster
{
    public static class Utils
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N")[..7];
        }
    }
}