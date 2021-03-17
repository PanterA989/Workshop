using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.Models.Dictionaries
{
    public class StatusModel
    {
        public int Id { get; set; }
        public string Value { get; set; }

        //public StatusModel(string value)
        //{
        //    Value = value;
        //}

        public override string ToString()
        {
            return Value;
        }
    }
}
