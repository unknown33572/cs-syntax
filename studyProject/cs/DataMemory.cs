using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class DataMemory
    {

    }

    public interface ITableRepository
    {
        string GetAll();
    }

    public class TableInMemoryRepository : ITableRepository
    {
        public string GetAll()
        {
            return "인-메모리 데이터베이스 사용";
        }
    }

    public class TableSqlRepository : ITableRepository
    {
        public string GetAll() => "SQL Server 데이터베이스 사용";
    }

    public class TableXmlRepository : ITableRepository
    {
        public string GetAll() => "XML 데이터베이스 사용";
    }

    class RepositoryPatternDemo
    {
        static void Main()
        {
            String repo = "InMemory";

            ITableRepository repository;

            if(repo == "InMemory")
            {
                repository = new TableInMemoryRepository();
            }
            else if(repo == "XML")
            {
                repository = new TableXmlRepository();
            }
            else
            {
                repository = new TableSqlRepository();
            }

            Console.WriteLine(repository.GetAll());
        }
    }
}
