using System;

namespace Lab2_13_2
{

    public class PhoneCallProcessor
    {
        // Public static methods block

        public static string Stringify(PhoneCall phoneCall)
        {
            decimal PhoneCallCost = GetCostOfPhoneCall(phoneCall);
            int PhoneCallLength = GetPhoneCallLength(phoneCall);
            if (IsAmountOfCostNonNegative(phoneCall))
            {
                return "Phone number: " + phoneCall.PhoneNumber +
                "; \nStart of Phone Call: " + phoneCall.TimeOfStartOfPhoneCall +
                "; \nEnd of Phone Call: " + phoneCall.TimeOfEndOfPhoneCall +
                "; \nCost of Phone Call: " + PhoneCallCost +
                "; \nLength of Phone Call in Minutes: " + PhoneCallLength +
                ";";
            }
            else
            {
                return "Not appropriate input data: Phone call length cannot be less than 0 minutes";
            }
        }

        public static decimal GetCostOfPhoneCall(PhoneCall phoneCall)
        {

            const decimal COST_OF_PHONE_CALL_BETWEEN_9_20 = 1.50M;
            const decimal COST_OF_PHONE_CALL_REGULAR = 0.90M;

            int MinutesOnHighestTariff = CountMinutesOnHighestTariff(phoneCall);
            int MinutesOnLowestTariff = CountMinutesOnLowestTariff(phoneCall);

            return MinutesOnHighestTariff * COST_OF_PHONE_CALL_BETWEEN_9_20 + MinutesOnLowestTariff * COST_OF_PHONE_CALL_REGULAR;
        }

        public static int GetPhoneCallLength(PhoneCall phoneCall)
        {
            int TimeOfStartOfPhoneCallInMinutes = ConvertInMinutes(phoneCall.TimeOfStartOfPhoneCall);
            int TimeOfEndOfPhoneCallInMinutes = ConvertInMinutes(phoneCall.TimeOfEndOfPhoneCall);

            return GetLengthOfPhoneCallInMinutes(TimeOfStartOfPhoneCallInMinutes, TimeOfEndOfPhoneCallInMinutes);
        }

        // Private static methods block

        private static int CountMinutesOnHighestTariff(PhoneCall phoneCall)
        {

            int NineAMInMinutes = ConvertInMinutes("9:00");
            int EigthPMInMinutes = ConvertInMinutes("20:00");
            int TimeOfStartOfPhoneCallInMinutes = ConvertInMinutes(phoneCall.TimeOfStartOfPhoneCall);
            int TimeOfEndOfPhoneCallInMinutes = ConvertInMinutes(phoneCall.TimeOfEndOfPhoneCall);
            int PhoneCallLength = GetPhoneCallLength(phoneCall);

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

        private static int CountMinutesOnLowestTariff(PhoneCall phoneCall)
        {
            int PhoneCallLength = GetPhoneCallLength(phoneCall);
            int MinutesOnHighestTariff = CountMinutesOnHighestTariff(phoneCall);
            return PhoneCallLength - MinutesOnHighestTariff;
        }

        private static int GetLengthOfPhoneCallInMinutes(int intervalStart, int intervalFinish)
        {
            return 1440 - intervalStart - (1440 - intervalFinish);
        }

        private static int ConvertInMinutes(string time)
        {
            string[] values = time.Split(":");
            return Convert.ToInt32(values[0]) * 60 + Convert.ToInt32(values[1]);
        }

        private static bool IsAmountOfCostNonNegative(PhoneCall phoneCall)
        {
            decimal PhoneCallCost = GetCostOfPhoneCall(phoneCall);

            return PhoneCallCost >= 0;
        }
    }
}
