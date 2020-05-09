using System;
using System.Collections.Generic;
using System.Text;

namespace SMSBackupToHtml
{
    class TxtMsg : Msg
    {

        public TxtMsg(smsesSms sms)
        {
            if (targetAddress == 0)
                targetAddress = sms.address;
            RightSide = sms.type == 2;

            FromFirst = sms.address == targetAddress;
            Body = sms.body;
            Date = DateTime.Parse(sms.readable_date);  
        }
        public override void WriteToHtml(StringBuilder builder, bool showDate)
        {

            if (showDate)
                builder.Append($"<p width=100% style=\"text-align:center\">{Date.ToString()}</p>");

            builder.Append($"<p width=100% style=\"text-align:{Side};background-color:{Color}\">{Body}</p>");
        }
    }
}
