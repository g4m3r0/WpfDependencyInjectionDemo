namespace WpfAppDI.StartupHelpers
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}