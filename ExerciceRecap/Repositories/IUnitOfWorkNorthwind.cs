using ExerciceRecap.Entities;

namespace ExerciceRecap.Repositories
{
    public interface IUnitOfWorkNorthwind
    {
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<Order> OrderRepository { get; }
    }
}
