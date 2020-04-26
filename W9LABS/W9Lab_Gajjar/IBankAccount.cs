using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9Lab_Gajjar
{
    public interface IBankAccount
    {
        void debit(int i);
        void credit(int i);
        int balance();
    }
}
