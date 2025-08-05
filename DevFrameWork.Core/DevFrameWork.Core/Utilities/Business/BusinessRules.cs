using DevFrameWork.Core.Utilities.Results;

namespace DevFrameWork.Core.Utilities.Business
{
    // Business rules for business layer
    public class BusinessRules // Burası çıplak kaldı çünkü artık overdesing'a giriyor.
    {
        // params ile Run içerisin istediğimiz kadar IResılt parametresi verebiliyoruz.
        public static IResult Run(params IResult[] logics) // logic bizim methodlardaki kuralımızı ifade ediyor.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; // Kurala uymayanı döndürüyoruz.
                }
            }
            return null;
        }
    }
}
