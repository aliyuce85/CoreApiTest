using CoreDeneme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IMailSender
    {
        Task<MailSendResult> SendMailAsync(MailMessageData emailMessage);
    }
}
