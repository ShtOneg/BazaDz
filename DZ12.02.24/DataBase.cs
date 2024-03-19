using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ12._02._24
{
    public class NoSQLDatabase : IDatabaseOperation
    {

        public void Insert() {
            Console.WriteLine("\nВставить");
        }

        public void Update()
        {
            Console.WriteLine("\nОбновить");
        }

        public void Delete()
        {
            Console.WriteLine("\nУдалить");
        }

    }

    public class SQLDatabase : IDatabaseOperation
    {

        public void Insert()
        {
            Console.WriteLine("INSERT INTO table_name\r\nVALUES (value1, value2, value3, ...); ");
        }

        public void Update()
        {
            Console.WriteLine("UPDATE table_name\r\nSET column1 = value1, column2 = value2, ...\r\nWHERE condition; ");
        }

        public void Delete()
        {
            Console.WriteLine("DELETE FROM table_name WHERE condition;");
        }

    }

    interface IDatabaseOperation {
        void Insert();
        void Update();
        void Delete();
    }
}
