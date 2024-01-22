using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.Dul.Data
{
    public interface IBreadShop<T> where T : class
    {
        T Browse(int id); // 상세
        List<T> Read(); // 출력
        bool Edit(T model); // 수정
        T Add(T model);
        bool Delete(int id);
        List<T> Search(string query);
        int Has();
        IEnumerable<T> Ordering(OrderOption orderOption);
        List<T> Paging(int pageNumber, int pageSize);
    }
}
