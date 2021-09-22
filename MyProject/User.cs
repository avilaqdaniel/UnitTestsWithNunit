using System.Collections.Generic;

namespace MyProject
{
    public class User
    {
        public IEnumerable<string> Roles { get; set; }
        
        public IEnumerable<string> ManagedCountries { get; set; }
    }
}
