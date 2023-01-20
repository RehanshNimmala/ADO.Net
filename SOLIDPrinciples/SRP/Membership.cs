using System;

namespace SRP
{
    public class Membership
    {
        int a = 10;
        int b = 10;
        public void Add()
        {
            try

            {
                int c = a + b;
            }

            catch (Exception ex)
            {
                // FileLogger fileLogger = new FileLogger();
                //fileLogger.ErrorLOgger(ex.Message);
                //File.WriteAllText(@"c:\Error.txt", ex.Message);
                FileLogger.ErrorLOgger(ex.Message);
            }
        }
    }
}
