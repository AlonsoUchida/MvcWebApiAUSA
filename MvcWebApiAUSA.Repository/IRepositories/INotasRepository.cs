using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcWebApiAUSA.Repository.IRepositories
{
    public interface INotasRepository
    {
        string ReadNotaUrl(string id, string not_str_archivo);
    }
}
