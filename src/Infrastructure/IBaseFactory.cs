
namespace Infrastructure
{
    public interface IBaseFactory
    {
        T Resolve<T>();
    }
}
