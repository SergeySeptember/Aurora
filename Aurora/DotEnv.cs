namespace Aurora.Env
{
    public static class DotEnv
    {
        public static string LoadSettings()
        {
            string filePath = @"C:\Users\September\source\repos\Aurora\Aurora\.env";
            string connectionString = "";

            if (!File.Exists(filePath))
            {
                throw new Exception("File \"environment\" does not exist");
            }               

            string[] settings = File.ReadAllLines(filePath);

            foreach (string line in settings)
            {
                if (line.Contains("ConnectionString"))
                {
                    connectionString = line.Replace("ConnectionString=", "");
                }
            }
            return connectionString;
        }
    }
}
