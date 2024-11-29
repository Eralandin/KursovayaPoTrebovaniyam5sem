using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaPoTrebovaniyam5sem.View.Interfaces
{
    public interface IAuth
    {
        event EventHandler LoginAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
    }
}
