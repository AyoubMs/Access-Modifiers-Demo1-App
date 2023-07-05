using DemoLibrary;

namespace AccessModifiersDemo1
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
