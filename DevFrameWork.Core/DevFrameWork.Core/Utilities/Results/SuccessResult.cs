namespace DevFrameWork.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // Buradaki base Result oluyor. Inherit edildiği sınıf.
        // Burada mesaj yollanıcak hali ve true dönücek.
        public SuccessResult(string message) : base(true, message)
        {

        }

        // Burası mesaj yollamıcak sadece true dönücek
        public SuccessResult() : base(true)
        {

        }
    }
}
