namespace DevFrameWork.Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        // Bu data bizim productımız
        T Data { get; }
    }
}
