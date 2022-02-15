class PhoneCall():

    def __init__(self, phone_number: str, start: str, end: str) -> None:
        self.__phone_number = phone_number
        self.__start_of_phone_call = start
        self.__end_of_phone_call = end

    def get_cost_of_phone_call(self) -> float:
        COST_OF_PHONE_CALL_BETWEEN_9_20 = 1.50
        COST_OF_PHONE_CALL_REGULAR = 0.90
        return self.__count_minutes_on_highest_tariff() * COST_OF_PHONE_CALL_BETWEEN_9_20 + self.__count_minutes_on_lowest_tariff() * COST_OF_PHONE_CALL_REGULAR

    def __count_minutes_on_highest_tariff(self) -> int:
        nine_AM_in_minutes = self.__convert_in_minutes("9:00")
        eigth_PM_in_minutes = self.__convert_in_minutes("20:00")
        start_of_phone_call_in_minutes = self.__convert_in_minutes(
            self.__start_of_phone_call)
        end_of_phone_call_in_minutes = self.__convert_in_minutes(
            self.__end_of_phone_call)

        if(start_of_phone_call_in_minutes < nine_AM_in_minutes):
            if(end_of_phone_call_in_minutes < nine_AM_in_minutes):
                return 0
            elif(end_of_phone_call_in_minutes >= nine_AM_in_minutes and end_of_phone_call_in_minutes <= eigth_PM_in_minutes):
                return end_of_phone_call_in_minutes - nine_AM_in_minutes
            else:
                return self.__get_length_of_phone_call_in_minutes(nine_AM_in_minutes, eigth_PM_in_minutes)
        elif(start_of_phone_call_in_minutes >= nine_AM_in_minutes and start_of_phone_call_in_minutes <= eigth_PM_in_minutes):
            if(end_of_phone_call_in_minutes >= nine_AM_in_minutes and end_of_phone_call_in_minutes <= eigth_PM_in_minutes):
                return self.__get_length_of_phone_call_in_minutes(start_of_phone_call_in_minutes, end_of_phone_call_in_minutes)
            else:
                return eigth_PM_in_minutes - start_of_phone_call_in_minutes
        else:
            return 0

    def __count_minutes_on_lowest_tariff(self) -> int:
        start_of_phone_call_in_minutes = self.__convert_in_minutes(
            self.__start_of_phone_call)
        end_of_phone_call_in_minutes = self.__convert_in_minutes(
            self.__end_of_phone_call)
        return self.__get_length_of_phone_call_in_minutes(start_of_phone_call_in_minutes, end_of_phone_call_in_minutes) - self.__count_minutes_on_highest_tariff()

    def __get_length_of_phone_call_in_minutes(self, interval_start: int, interval_end: int) -> int:
        return 1440 - interval_start - (1440 - interval_end)

    def __convert_in_minutes(self, time: str) -> int:
        values = time.split(":")
        return int(values[0]) * 60 + int(values[1])

    def __is_amount_of_cost_non_negative(self) -> bool:
        return self.get_cost_of_phone_call()

    def get_current_phone_call_length(self) -> int:
        return self.__get_length_of_phone_call_in_minutes(
            self.__convert_in_minutes(
                self.__start_of_phone_call),
            self.__convert_in_minutes(self.__end_of_phone_call))

    def __repr__(self) -> str:
        if(self.__is_amount_of_cost_non_negative()):
            return "\nPhone number: " + self.__phone_number + "; \nStart of Phone Call: " + self.__start_of_phone_call + "; \nEnd of Phone Call: " + self.__end_of_phone_call + "; \nCost of Phone Call: " + str(self.get_cost_of_phone_call()) + "; \nLength of Phone Call in Minutes: " + str(self.get_current_phone_call_length()) + ";\n"
        return "\nNot appropriate input data: Phone call length cannot be less than 0 minutes"
