using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleTestBox.ErrorBox
{
    public static class ErrorRecorder
    {
        public static string ErrorMsgWithLineNumber(Exception ex)
        {
            return $"錯誤訊息 :{ex.Message} 錯誤行數 :{new StackTrace(ex,true).GetFrame(0).GetFileLineNumber()}";
        }

        public static string GetAllPropertiesOfException(Exception ex)
        {
            StringBuilder errorBuilder = new StringBuilder();

            errorBuilder.AppendLine("ex it self:" + ex );

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's Message:" + ex.Message);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's StackTrace:" + ex.StackTrace);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's Source:" + ex.Source);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's HResult:" + ex.HResult);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's HelpLink:" + ex.HelpLink);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's Data:" + ex.Data);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's InnerException:" + ex.InnerException);

            errorBuilder.AppendLine();

            errorBuilder.AppendLine("ex it's TargetSite:" + ex.TargetSite);

            return errorBuilder.ToString();
        }

    }
}
