using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using OpenPop.Common;
using OpenPop.Mime;
using OpenPop.Pop3;
using System.IO;

namespace myProgram
{
    class Loader
    {
        public void GetAttach(DateTime date)//получение аттачментов
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daBranch = new SqlDataAdapter("Select * from Branch", s);
            daBranch.Fill(ds, "Branch");
            DataTable dtBranch = ds.Tables["Branch"];

            var emailBrach = dtBranch.AsEnumerable()
                        .Select(t => t.Field<string>("email"));

            using (Pop3Client client = new Pop3Client())
            {
                client.Connect("pop3.mail.ru", 110, false);
                client.Authenticate("magazin_ulstu_2014@mail.ru", "mag17012014");

                List<string> listIdMsg = client.GetMessageUids();//получаем список id всех писем

                for (int i = 1; i <= listIdMsg.Count(); i++)
                {
                    OpenPop.Mime.Message msg = client.GetMessage(i); //получаум письмо по Id;
                    string address = msg.Headers.From.Address.ToString(); //получаем адрес отправителя
                    DateTime dateMsg = DateTime.Parse(msg.Headers.Date); //получаем дату сообщения

                    List<MessagePart> listAttach = msg.FindAllAttachments(); //получаем все аттачменты сообщения

                    foreach (var elem in emailBrach)
                    {
                        if (address.Substring(0, address.Length) == elem && dateMsg.ToString().Substring(0, 10) == date.ToString().Substring(0, 10))
                        {
                            if (listAttach.Count > 0)
                            {
                                foreach (MessagePart attach in listAttach)
                                {
                                    string filePath = Path.Combine(@"D:\MailBranch", attach.FileName);
                                    attach.Save(new FileInfo(filePath));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
