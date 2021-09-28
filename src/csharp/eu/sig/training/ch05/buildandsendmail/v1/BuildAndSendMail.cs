namespace eu.sig.training.ch05.buildandsendmail.v1
{
    public class BuildAndSendMail
    {

        // tag::buildAndSendMail[]
        public void DoBuildAndSendMail(MailMan m, Person person, string subject, MailFont font, Message message)
        {
            // Format the email address
            string mId = $"{firstName[0]}.{lastName.Substring(0, 7)}" +
                $"@{division.Substring(0, 5)}.compa.ny";
            // Format the message given the content type and raw message
            MailMessage mMessage = FormatMessage(font,
                message1 + message2 + message3);
            // Send message
            m.Send(mId, subject, mMessage);
        }
        // end::buildAndSendMail[]


        public class Message
        {
            public string Subject { get; set; }
            public string Message1 { get; set; }
            public string Message2 { get; set; }
            public string Message3 { get; set; }

        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastNAme { get; set; }
            public string Division { get; set; }
        }

        public MailMessage FormatMessage(MailFont font, string s)
        {
            return null;
        }

        public class MailMan
        {

            public void Send(string mId, string subject, MailMessage mMessage) { }

        }

        public class MailFont
        {

        }

        public class MailMessage
        {

        }

    }
}
