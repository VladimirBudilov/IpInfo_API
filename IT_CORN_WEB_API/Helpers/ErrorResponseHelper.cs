namespace IT_CORN_WEB_API.Controller;

public class ErrorHelper
{
    public static async Task GeneraeError(HttpContext context, ErrorHelper.ErrorResponse? error)
    {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        await context.Response.WriteAsJsonAsync(error);
    }

    public class ErrorResponse
    {
        public int status { get; set; }
        public ErrorDetail error { get; set; }

        public class ErrorDetail
        {
            public string title { get; set; }
            public string message { get; set; }
        }
    }
}