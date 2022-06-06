using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractico1
{
    public interface IPersonForm
    {
        void SharePersonData(int personId, string name, string surname, DateTime birth, string address, string action);
        void ShareDeleteData(int personId, Boolean confirmDelete);
    }
}
