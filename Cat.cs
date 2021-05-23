using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    /// <summary>
    /// Nowe przeciążanie metod virtualnych
    /// </summary>
    public class Cat
    {
        public virtual Cat GetCat()
        {
            return new Cat();
        }
    }

    public class Tigger : Cat
    {
        public override Cat GetCat()
        {
            return new Tigger();
        }
    }

    public class Tigger2 : Cat
    {
        // METODA PRZECIAZONA Z INNYM TYPEM ZWRACANYM NIZ BASE METHOD !!! 
        public override Tigger2 GetCat()
        {
            return new Tigger2();
        }
    }
}
