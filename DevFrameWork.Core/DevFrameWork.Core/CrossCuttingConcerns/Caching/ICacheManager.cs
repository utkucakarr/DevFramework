namespace DevFrameWork.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        // cache time : Data cache'de ne kadar kalıcak
        void Add(string key, object data, int cacheTime);

        bool IsAdd(string key); // Daha önceden cache eklenmiş mi

        void Remove(string key);

        void RemoveByPattern(string pattern); // Regular expression'a bakarak silme

        void Clear();
    }
}
