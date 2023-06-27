namespace SpaceGame.Interfaces
{
    public interface IBaseModel
    {
        object? GetProperty(string key);
        void SetProperty(string key, object newValue);
    }
}
