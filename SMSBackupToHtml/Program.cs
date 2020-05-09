using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SMSBackupToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;
            if (args.Length != 2)
            {
                Console.Write("Input path:");
                input = Console.ReadLine();
                if (!File.Exists(input))
                    throw new FileNotFoundException("Input File doesn't exist", input);
                Console.Write("Output file:");
                output = Console.ReadLine();
            }
            else
            {
                input = args[0];
                output = args[1];
            }

            XmlSerializer serializer = new XmlSerializer(typeof(smses));

            // Declare an object variable of the type to be deserialized.
            smses i;

            using (Stream reader = new FileStream(input, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (smses)serializer.Deserialize(reader);
            }

            List<Msg> Messages = new List<Msg>();
            foreach (var sms in i.sms)
            {
                Messages.Add(new TxtMsg(sms));
            }

            foreach (var mediamsg in i.mms)
            {
                var media = new MediaMsg(mediamsg);
                if (media.Parts.Length > 0)
                    Messages.Add(media);
            }
            var ordered = Messages.OrderBy(x => x.Date).ToList();

            //var orderred = Messages.OrderBy();
            var mediatext = new StringBuilder();
            mediatext.Append("<html><head></head><body>");

            Msg lastMsg = null;
            foreach (var msg in ordered.Where(x => x.Date.Year == 2018))
            {
                msg.WriteToHtml(mediatext, lastMsg == null || lastMsg.Date.Day != msg.Date.Day);
                lastMsg = msg;
            }
            mediatext.Append("</body></html>");


            File.WriteAllText(output, mediatext.ToString());
            var proc = Process.Start(@"cmd.exe ", @"/c " + output);
        }
    }
}
