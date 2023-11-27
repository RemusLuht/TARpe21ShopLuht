using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopLuht.Core.Dto;

namespace TARpe21ShopLuht.Core.ServiceInterface
{
    public interface IEmailService
    {
        void SendEmail(EmailDto dto);
    }
}
