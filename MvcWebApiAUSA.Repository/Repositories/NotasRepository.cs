using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcWebApiAUSA.Repository.IRepositories;
using MvcWebApiAUSA.DAL.IDALs;
using MvcWebApiAUSA.DAL.DALs;

namespace MvcWebApiAUSA.Repository.Repositories
{
    public class NotasRepository : INotasRepository
    {
        private INotasDAL dal;

        public NotasRepository(INotasDAL dal)
        {
            this.dal = dal;
        }

        public string ReadNotaUrl(string id, string not_str_archivo) 
        {
            return dal.ReadNotaUrl(id, not_str_archivo);
        }
    }
}
