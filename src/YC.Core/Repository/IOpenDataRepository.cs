using System.Collections.Generic;
using L.Models;

namespace L.Repository
{
    public interface IOpenDataRepository
    {
        void Delete(int id);
        void Insert(OpenData item);
        List<OpenData> SelectAll(string name);
        void Update(OpenData item);
    }
}