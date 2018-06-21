using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormServiceApplication
{
    /*
    public class MyRequest
    {
        public string Text { get; set; }
    }


    // Response message type
    public class MyResponse
    {
        public int Length { get; set; }
    }*/
    public enum timespan { sample, minute, hour, day };
    public class MyRequest
    {
        public bool Ack { get; set; }
        public timespan TimeUnit { get; set; }
        public int numberOfTimeUnitsBack { get; set; }
    }

    // Response message type
    public class MyResponse
    {
        public Int32 Time { get; set; }
        public float Temperature { get; set; }

        public float Humidity { get; set; }

        public float Pressure { get; set; }
    }
}
