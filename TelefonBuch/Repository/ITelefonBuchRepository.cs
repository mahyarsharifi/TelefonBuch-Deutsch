using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBuch
{
    interface ITelefonBuchRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int kontaktId);
        DataTable Search(string parameter);
        bool Insert(string name, string familie, string handynummer, string email, int age, string anschrift);
        bool Update(int kontaktId, string name, string familie, string handynummer, string email, int age, string anschrift);
        bool Delete(int kontaktId);
    }
}
