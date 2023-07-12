using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ispat.Helper
{
    public class ApiError
    {
        public ApiError(long ErrorCode, string ErrorMessage, string ErrorDetails = null)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.ErrorDetails = ErrorDetails;
        }
        public long ErrorCode{ get; set; }
        public string ErrorMessage{ get; set; }
        public string ErrorDetails{ get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
