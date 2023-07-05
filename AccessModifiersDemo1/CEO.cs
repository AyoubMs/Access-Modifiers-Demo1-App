using DemoLibrary;

namespace AccessModifiersDemo1
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();

            formerLastName = "test";
        }
    }
}
