using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorClient.Shared
{
    public class ChatModel
    {
        public string From { get; set; }
        public string Message { get; set; }
        public DateTime Sent { get; set; }
    }
}
