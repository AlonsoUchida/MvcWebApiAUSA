using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcWebApiAUSA.DAL.IDALs;
using MvcWebApiAUSA.DAL.DALs;
using MvcWebApiAUSA.BusinessServices.IService;

namespace MvcWebApiAUSA.BusinessServices.Services
{
    public class NotasServices : INotasServices
    {
        private INotasDAL dal;

        public NotasServices(INotasDAL dal)
        {
            this.dal = dal;
        }

        public string ReadNotaUrl(string id, string not_str_archivo) 
        {
            return dal.ReadNotaUrl(id, not_str_archivo);
        }
    }
}
