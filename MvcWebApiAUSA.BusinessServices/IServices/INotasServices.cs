using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcWebApiAUSA.BusinessServices.IService
{
    public interface INotasServices
    {
        string ReadNotaUrl(string id, string not_str_archivo);
    }
}
