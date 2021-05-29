using _09_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09_Crud.DbTools
{
    public class DbInstance
    {
        private static NorthwindEntities _dbInstance;

        public DbInstance()
        {

        }

        public static NorthwindEntities NorthwindInstance { 
            get 
            {
                if (_dbInstance==null)
                {
                    _dbInstance = new NorthwindEntities();
                }
                return _dbInstance;
            }
        }

    }
}