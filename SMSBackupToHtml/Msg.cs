using System;
using System.Collections.Generic;
using System.Text;

namespace SMSBackupToHtml
{
    abstract class Msg
    {
        public bool RightSide { get; protected set; }

        public static long targetAddress;
        public string Color => RightSide ? "#ffcccc" : "#ccccff";
        public string Side => RightSide ? "right" : "left";
        public string Contact { protected set;  get; }
        public string Body { protected set; get; }
        public DateTime Date { protected set; get; }
        public virtual bool FromFirst { get; protected set; }

        public abstract void WriteToHtml(StringBuilder builder, bool showDate);

    }
}
