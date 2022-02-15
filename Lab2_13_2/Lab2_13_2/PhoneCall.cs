using System;

namespace Lab2_13_2
{
    public class PhoneCall
    {
        public string PhoneNumber { get; set; }

        public string TimeOfStartOfPhoneCall { get; }

        public string TimeOfEndOfPhoneCall { get; }

        public int PhoneCallLength { get; }

        public decimal PhoneCallCost { get; } // -> new segregated class

        private int TimeOfStartOfPhoneCallInMinutes; // -> new segregated class

        private int TimeOfEndOfPhoneCallInMinutes; // -> new segregated class

        private int MinutesOnLowestTariff; // -> new segregated class

        private int MinutesOnHighestTariff; // -> new segregated class


        public PhoneCall(string number, string start, string end)
        {
            PhoneNumber = number;
            TimeOfStartOfPhoneCall = start;
            TimeOfEndOfPhoneCall = end;
            TimeOfStartOfPhoneCallInMinutes = ConvertInMinutes(TimeOfStartOfPhoneCall);
            TimeOfEndOfPhoneCallInMinutes = ConvertInMinutes(TimeOfEndOfPhoneCall);
            PhoneCallLength = GetLengthOfPhoneCallInMinutes(TimeOfStartOfPhoneCallInMinutes, TimeOfEndOfPhoneCallInMinutes);
            MinutesOnHighestTariff = CountMinutesOnHighestTariff();
            MinutesOnLowestTariff = CountMinutesOnLowestTariff();
            PhoneCallCost = GetCostOfPhoneCall();
        }

        public decimal GetCostOfPhoneCall()
        {

            const decimal COST_OF_PHONE_CALL_BETWEEN_9_20 = 1.50M;
            const decimal COST_OF_PHONE_CALL_REGULAR = 0.90M;

            return MinutesOnHighestTariff * COST_OF_PHONE_CALL_BETWEEN_9_20 + MinutesOnLowestTariff * COST_OF_PHONE_CALL_REGULAR;
        }

        private int CountMinutesOnHighestTariff()
        {

            int NineAMInMinutes = ConvertInMinutes("9:00");
            int EigthPMInMinutes = ConvertInMinutes("20:00");

            if (TimeOfStartOfPhoneCallInMinutes < NineAMInMinutes)
            {
                if (TimeOfEndOfPhoneCallInMinutes < NineAMInMinutes)
                {
                    return 0;
                }
                else if (TimeOfEndOfPhoneCallInMinutes >= NineAMInMinutes && TimeOfEndOfPhoneCallInMinutes <= EigthPMInMinutes)
                {
                    return TimeOfEndOfPhoneCallInMinutes - NineAMInMinutes;
                }
                else
                {
                    return GetLengthOfPhoneCallInMinutes(NineAMInMinutes, EigthPMInMinutes);
                }

            }
            else if (TimeOfStartOfPhoneCallInMinutes >= NineAMInMinutes && TimeOfStartOfPhoneCallInMinutes <= EigthPMInMinutes)
            {
                if (TimeOfEndOfPhoneCallInMinutes >= NineAMInMinutes && TimeOfEndOfPhoneCallInMinutes <= EigthPMInMinutes)
                {
                    return PhoneCallLength;
                }
                else
                {
                    return EigthPMInMinutes - TimeOfStartOfPhoneCallInMinutes;
                }
            }
            else
            {
                return 0;
            }
        }

        private int CountMinutesOnLowestTariff()
        {
            return PhoneCallLength - MinutesOnHighestTariff;
        }

        private int GetLengthOfPhoneCallInMinutes(int intervalStart, int intervalFinish)
        {
            return 1440 - intervalStart - (1440 - intervalFinish);
        }

        private int ConvertInMinutes(string time)
        {
            string[] values = time.Split(":");
            return Convert.ToInt32(values[0]) * 60 + Convert.ToInt32(values[1]);
        }

        private bool IsAmountOfCostNonNegative()
        {
            return PhoneCallCost >= 0;
        }

        public override string ToString()
        {
            if (IsAmountOfCostNonNegative())
            {
                return "Phone number: " + PhoneNumber +
                "; \nStart of Phone Call: " + TimeOfStartOfPhoneCall +
                "; \nEnd of Phone Call: " + TimeOfEndOfPhoneCall +
                "; \nCost of Phone Call: " + PhoneCallCost +
                "; \nLength of Phone Call in Minutes: " + PhoneCallLength +
                ";";
            }
            else
            {
                return "Not appropriate input data: Phone call length cannot be less than 0 minutes";
            }
        }
    }
}
