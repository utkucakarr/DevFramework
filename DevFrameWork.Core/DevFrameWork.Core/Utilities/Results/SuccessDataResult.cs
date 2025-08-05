namespace DevFrameWork.Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        // Mesaj, data ve işlem sonucunu döndürür.
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        // Data ve işlem sonucunu döndürür.
        public SuccessDataResult(T data) : base(data, true)
        {

        }

        // Datayı default haliyle dönmek ister ise
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        // Hiçbir şey vermek istemez isek yani datayı döndürmüyoruz.
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}