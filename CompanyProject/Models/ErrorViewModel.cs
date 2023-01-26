namespace CompanyProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string RequestedUrl { get; set; }

        public string RedirectUrl { get; set; }

        public string ExceptionMessage { get; set; }
    }
}