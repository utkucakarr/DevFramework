namespace DevFrameWork.Core.Utilities.Results
{
    // Temel voidler için başlangıç
    // İçerisinde bir tane işlem sonucu ve kullanıcıyı bilgilendirme için mesaj olucak
    public interface IResult
    {
        bool Success { get; } // sadece okunabilir yaptık. Get'ler readonly'dir constructurede set edilebilir

        string Message { get; }
    }
}
