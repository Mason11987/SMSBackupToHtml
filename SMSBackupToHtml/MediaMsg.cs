using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSBackupToHtml
{
    class MediaMsg : Msg
    {
        
        public MediaMsg(smsesMms mediamsg)
        {
            RightSide = mediamsg.addrs[0].address == targetAddress;
            Date = DateTime.Parse(mediamsg.readable_date);

            Parts = mediamsg.parts.Select(x => new Part(x)).ToArray();
            if (Parts.Length == 4 && Parts[1].FileName == Parts[2].FileName && Parts[1].Type == Parts[2].Type)
            {
                Parts = Parts.ToList().Take(1).Union(Parts.ToList().Skip(2)).ToArray();
            }
            if (Parts.Length == 3 && Parts[1].FileName == Parts[2].FileName && Parts[1].Type == Parts[2].Type)
            {
                Parts = Parts.ToList().Take(1).Union(Parts.ToList().Skip(2)).ToArray();
            }

            if (Parts.Length == 3)
            {
                if (Parts[0].Type == "Smil")
                {
                    if ((Parts[1].Type == "Jpeg" || Parts[1].Type == "Gif") && Parts[2].Type == "Text")
                    {
                        ImageBytes = Parts[1].Bytes;
                        ImageFileName = Parts[1].FileName;
                        ImageCaption = Parts[2].MsgText;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else if (Parts.Length == 0)
            {
                
            }
            else if (Parts.Length == 2)
            {
                if (Parts[0].Type == "Smil")
                {
                    if (Parts[1].Type == "Jpeg" || Parts[1].Type == "Gif")
                    {
                        ImageBytes = Parts[1].Bytes;
                        ImageFileName = Parts[1].FileName;
                        ImageCaption = "";
                    }
                    else if (Parts[1].Type == "Text")
                    {
                        ImageCaption = Parts[1].MsgText;
                    }
                    else
                    {

                    }
                }
                else
                {
                    if ((Parts[0].Type == "Jpeg" || Parts[0].Type == "Gif") && Parts[1].Type == "Text")
                    {
                        ImageBytes = Parts[0].Bytes;
                        ImageFileName = Parts[0].FileName;
                        ImageCaption = Parts[1].MsgText;
                    }
                    else if ((Parts[1].Type == "Jpeg" || Parts[1].Type == "Gif") && Parts[0].Type == "Text")
                    {
                        ImageBytes = Parts[1].Bytes;
                        ImageFileName = Parts[1].FileName;
                        ImageCaption = Parts[0].MsgText;
                    }
                    else
                    {

                    }
                }
            }
            else if (Parts.Length == 1)
            {
                if (Parts[0].Type == "Jpeg" || Parts[0].Type == "Gif")
                {
                    ImageBytes = Parts[0].Bytes;
                    ImageFileName = Parts[0].FileName;
                    ImageCaption = "";
                }
                else if (Parts[0].Type == "Text")
                {
                    ImageCaption = Parts[0].MsgText;
                }
                else
                {

                }
            }
            else
            {

            }
            if (string.IsNullOrEmpty(ImageCaption) && ImageBytes == null)
            {

            }
        }

        public Part[] Parts { get; private set; }
        public byte[] ImageBytes { get; private set; }
        public string ImageFileName { get; private set; }
        public string ImageCaption { get; private set; }
        public long FromAddress { get; private set; }

        public override void WriteToHtml(StringBuilder builder, bool showDate)
        {
            if (showDate)
                builder.Append($"<p width=100% style=\"text-align:center\">{Date.ToString()}</p>");

            if (ImageBytes != null)
            {
                builder.Append($"<img style=\"float: {Side};border:5px solid {Color}\" height=400px src=\"{ImageFileName}\"></img></div>");
            }
            builder.Append($"<div style=\"clear: {Side}\">");
            if (!string.IsNullOrEmpty(ImageCaption))
                builder.Append($"<p width=100% style=\"text-align:{Side};background-color:{Color}\">{ImageCaption}</p>");
            builder.Append($"</div>");
        }
    }
}
