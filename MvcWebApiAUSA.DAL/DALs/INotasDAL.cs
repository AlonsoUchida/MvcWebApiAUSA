﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcWebApiAUSA.DAL.IDALs
{
    public interface INotasDAL
    {
        string ReadNotaUrl(string id, string not_str_archivo);
    }
}
