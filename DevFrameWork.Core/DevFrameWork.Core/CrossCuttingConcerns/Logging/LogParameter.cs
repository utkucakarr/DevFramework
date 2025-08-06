namespace DevFrameWork.Core.CrossCuttingConcerns.Logging
{
    // Method paraterseninin ismi, tipi ve değeri tutulacak.
    public class LogParameter
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public object Value { get; set; }
    }
}