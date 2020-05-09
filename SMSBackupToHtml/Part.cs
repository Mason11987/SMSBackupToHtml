using System;
using System.IO;

namespace SMSBackupToHtml
{
    internal class Part
    {

        public Part(smsesMmsPart part)
        {
            switch (part.ct)
            {
                case "text/plain":
                    MsgText = part.text;
                    FileName = part.name;
                    Type = "Text";
                    break;
                case "image/jpeg":
                    Type = "Jpeg";
                    FileName = part.name == "null" ? part.cl : part.name;
                    Bytes = Convert.FromBase64String(part.data);
                    File.WriteAllBytes(FileName, Bytes);
                    break;
                case "image/gif":
                    Type = "Gif";
                    FileName = part.name == "null" ? part.cl : part.name;
                    Bytes = Convert.FromBase64String(part.data);
                    File.WriteAllBytes(FileName, Bytes);
                    break;
                case "application/smil":
                    Type = "Smil";
                    MsgText = part.text;
                    if (MsgText.Contains("img src=\""))
                    {
                        var start = MsgText.IndexOf("img src=\"") + "img src=\"".Length;
                        var end = MsgText.IndexOf("\"/>", start);
                        ImgSrc = MsgText.Substring(start, end - start);
                    }
                    if (MsgText.Contains("text src=\""))
                    {
                        var start = MsgText.IndexOf("text src=\"") + "text src=\"".Length;
                        var end = MsgText.IndexOf("\"/>", start);
                        TxtSrc = MsgText.Substring(start, end - start);
                    }
                    break;
                default:
                    break;
            }
        }

        public string MsgText { get; private set; }
        public string Type { get; private set; }
        public string FileName { get; private set; }
        public byte[] Bytes { get; private set; }
        public string ImgSrc { get; private set; }
        public string TxtSrc { get; private set; }
    }
}