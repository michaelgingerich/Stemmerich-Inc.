using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawMaterialsThresholdNotifier
{
    [Serializable()]
    class EmailAddress
    {
        //Container for e-mail addresses and the selected state of each.
        public static List<EmailAddress> emailAddressList = new List<EmailAddress>();
        String emailAddress;
        Boolean emailAddressIsChecked;

        public EmailAddress(String emailAddressParam, Boolean emailAddressIsCheckedParam)
        {
            this.emailAddress = emailAddressParam;
            this.emailAddressIsChecked = emailAddressIsCheckedParam;
        }

        public String getEmailAddress()
        {
            return this.emailAddress;
        }

        public void setEmailAddress(String emailAddressParam)
        {
            this.emailAddress = emailAddressParam;
        }

        public Boolean getEmailAddressIsChecked()
        {
            return this.emailAddressIsChecked;
        }

        public void setEmailAddressIsChecked(Boolean emailAddressIsCheckedParam)
        {
            this.emailAddressIsChecked = emailAddressIsCheckedParam;
        }
    }
}
