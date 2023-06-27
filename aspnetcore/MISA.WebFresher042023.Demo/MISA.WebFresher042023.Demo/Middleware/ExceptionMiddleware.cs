//using System.Text.Json;
//namespace MISA.WebFresher042023.Demo.Middleware
//{
//    public class ExceptionMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public ExceptionMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task InvokeAsync(HttpContext context)
//        {
//            try
//            {
//                // Xử lý request bình thường
//                await _next(context);
//            }

//            catch (NotFoundException ex)
//            {
//                // Xử lý lỗi NotFoundException
//                context.Response.StatusCode = StatusCodes.Status404NotFound; // Not Found
//                context.Response.ContentType = "application/json";

//                // Tạo đối tượng BaseException từ NotFoundException
//                var baseException = new BaseException
//                {
//                    ErrorCode = context.Response.StatusCode,
//                    DevMessage = ex.Message,
//                    UserMessage = "Không tìm thấy dữ liệu",
//                    TraceId = context.TraceIdentifier,
//                    MoreInfo = ex.HelpLink,
//                };

//                // Gửi thông tin lỗi về cho client
//                await context.Response.WriteAsync(baseException.ToString());

//            }
//            catch (Exception ex)
//            {
//                // Xử lý các loại lỗi khác
//                context.Response.StatusCode = StatusCodes.Status500InternalServerError; // Internal Server Error
//                context.Response.ContentType = "application/json";
//                // Tạo đối tượng BaseException từ NotFoundException
//                var baseException = new BaseException
//                {
//                    ErrorCode = context.Response.StatusCode,
//                    DevMessage = ex.Message,
//                    UserMessage = "Lỗi hệ thống ",
//                    TraceId = context.TraceIdentifier,
//                    MoreInfo = ex.HelpLink,
//                };
//                // Gửi thông tin lỗi về cho client
//                await context.Response.WriteAsync(JsonSerializer.Serialize(ex));

//            }
//        }
//    }
//}

