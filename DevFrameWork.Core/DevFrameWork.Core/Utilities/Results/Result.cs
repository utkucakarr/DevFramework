namespace DevFrameWork.Core.Utilities.Results
{
    public class Result : IResult // IResult resultun referansını tutuyor.
    {
        // c#'da this demek class'ın kendisi demek yani Result
        // burada this ile şunu dedik Result'un constructure'una ama tek parametreli olan constructure'una success'i yolla
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
