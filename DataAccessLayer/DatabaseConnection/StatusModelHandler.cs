using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    class StatusModelHandler : SqlMapper.TypeHandler<StatusModel>
    {
        //Handles how data deserialized into object
        public override StatusModel Parse(object value)
        {
            return new StatusModel(/*value.ToString()*/);
        }

        //Handles how data is saved into the database
        public override void SetValue(IDbDataParameter parameter, StatusModel value)
        {
            parameter.Value = value.ToString();
        }
    }
}
