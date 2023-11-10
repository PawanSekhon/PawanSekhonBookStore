﻿using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace PawanBooks.DataAccess.Repository.IRepository
{
    interface ISP_Call : IDisposable
    {
        //e.g. first column of first row int he result set 
        T Single<T>(string procedurename, DynamicParameters param = null);
        //execute something to the database but not retrieve anything 
        void Execute(string procedurename, DynamicParameters param = null);
        //retrieves the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        //get all of the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //stored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedure, DynamicParameters, DynamicParameters param = null);
    }
}
