using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class SQLQuery
    {
        // All arguments (unless empty) should end in a space
        static public string appendQuery(string queryType, string statement, string newStatement)
        {
            if (statement == "")
            {
                return queryType + newStatement;
            }

            else
            {
                return statement += "AND " + newStatement;
            }
        }
    }
}
