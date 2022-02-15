from PhoneCall import PhoneCall


class PhoneCallProcessor():

    @staticmethod
    def get_cost_of_phone_call(phone_call: PhoneCall) -> float:
        COST_OF_PHONE_CALL_BETWEEN_9_20 = 1.50
        COST_OF_PHONE_CALL_REGULAR = 0.90
        return PhoneCallProcessor.__count_minutes_on_highest_tariff(phone_call) * COST_OF_PHONE_CALL_BETWEEN_9_20 + PhoneCallProcessor.__count_minutes_on_lowest_tariff(phone_call) * COST_OF_PHONE_CALL_REGULAR

    @staticmethod
    def __count_minutes_on_highest_tariff(phone_call: PhoneCall) -> int:
        nine_AM_in_minutes = PhoneCallProcessor.__convert_in_minutes("9:00")
        eigth_PM_in_minutes = PhoneCallProcessor.__convert_in_minutes("20:00")
        start_of_phone_call_in_minutes = PhoneCallProcessor.__convert_in_minutes(
            phone_call.start_of_phone_call)
        end_of_phone_call_in_minutes = PhoneCallProcessor.__convert_in_minutes(
            phone_call.end_of_phone_call)

        if(start_of_phone_call_in_minutes < nine_AM_in_minutes):
            if(end_of_phone_call_in_minutes < nine_AM_in_minutes):
                return 0
            elif(end_of_phone_call_in_minutes >= nine_AM_in_minutes and end_of_phone_call_in_minutes <= eigth_PM_in_minutes):
                return end_of_phone_call_in_minutes - nine_AM_in_minutes
            else:
                return PhoneCallProcessor.__get_length_of_interval_in_minutes(nine_AM_in_minutes, eigth_PM_in_minutes)
        elif(start_of_phone_call_in_minutes >= nine_AM_in_minutes and start_of_phone_call_in_minutes <= eigth_PM_in_minutes):
            if(end_of_phone_call_in_minutes >= nine_AM_in_minutes and end_of_phone_call_in_minutes <= eigth_PM_in_minutes):
                return PhoneCallProcessor.__get_length_of_interval_in_minutes(start_of_phone_call_in_minutes, end_of_phone_call_in_minutes)
            else:
                return eigth_PM_in_minutes - start_of_phone_call_in_minutes
        else:
            return 0

    @staticmethod
    def __count_minutes_on_lowest_tariff(phone_call: PhoneCall) -> int:
        return PhoneCallProcessor.get_current_phone_call_length(phone_call) - PhoneCallProcessor.__count_minutes_on_highest_tariff(phone_call)

    @staticmethod
    def __get_length_of_interval_in_minutes(interval_start: int, interval_end: int) -> int:
        return 1440 - interval_start - (1440 - interval_end)

    @staticmethod
    def __convert_in_minutes(time: str) -> int:
        values = time.split(":")
        return int(values[0]) * 60 + int(values[1])

    @staticmethod
    def __is_amount_of_cost_non_negative(phone_call) -> bool:
        return PhoneCallProcessor.get_cost_of_phone_call(phone_call)

    @staticmethod
    def get_current_phone_call_length(phone_call: PhoneCall) -> int:
        return PhoneCallProcessor.__get_length_of_interval_in_minutes(
            PhoneCallProcessor.__convert_in_minutes(
                phone_call.start_of_phone_call),
            PhoneCallProcessor.__convert_in_minutes(phone_call.end_of_phone_call))

    @staticmethod
    def stringify(phone_call: PhoneCall) -> str:
        if(PhoneCallProcessor.__is_amount_of_cost_non_negative(phone_call)):
            return "\nPhone number: " + phone_call.phone_number + "; \nStart of Phone Call: " + phone_call.start_of_phone_call + "; \nEnd of Phone Call: " + phone_call.end_of_phone_call + "; \nCost of Phone Call: " + str(PhoneCallProcessor.get_cost_of_phone_call(phone_call)) + "; \nLength of Phone Call in Minutes: " + str(PhoneCallProcessor.get_current_phone_call_length(phone_call)) + ";\n"
        return "\nNot appropriate input data: Phone call length cannot be less than 0 minutes"
