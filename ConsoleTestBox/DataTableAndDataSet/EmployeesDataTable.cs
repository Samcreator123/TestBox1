using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace ConsoleTestBox.DataTableAndDataSet
{
    public class Employee
    {
        public readonly DataTable _data = new DataTable();
        public Employee InitTable()
        {

            _data.Columns.Add("ID");
            _data.Columns.Add("NAME");
            _data.Columns.Add("AGE");
            _data.Columns.Add("HEIGHT");
            _data.Columns.Add("WEIGHT");

            return this;
        }

    }
}
