using System;

namespace Lab2_13_2
{
    public class PhoneCall
    {
        public string PhoneNumber;

        public string TimeOfStartOfPhoneCall;

        public string TimeOfEndOfPhoneCall;

        public PhoneCall(string number, string start, string end)
        {
            PhoneNumber = number;
            TimeOfStartOfPhoneCall = start;
            TimeOfEndOfPhoneCall = end;
        }
    }
}
