namespace Poc.MediatR.Dtos
{
    public class HandlersResponse
    {
        public bool Success { get; set; }
        public IList<string> Errors { get; set; } = new List<string>();

        public HandlersResponse(bool success)
        {
            Success = success;
        }

        public HandlersResponse(IList<string> errors)
        {
            Success = false;
            Errors = errors;
        }
    }
}
