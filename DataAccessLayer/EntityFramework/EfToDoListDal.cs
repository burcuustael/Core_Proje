using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.EntityFramework
{
    public class EfToDoListDal : GenericRepository<ToDoList>, IToDoListDal
    {
    }
}
