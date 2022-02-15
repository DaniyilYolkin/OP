from PhoneCall import PhoneCall


class IOManipulator():

    @staticmethod
    def __validate_string_on_escape_seq(string: str) -> bool:
        for letter in string:
            possible_escape_sequence = ord(letter)
            if(possible_escape_sequence >= 0 and possible_escape_sequence != 10 and possible_escape_sequence <= 31):
                return False
        return True

    @staticmethod
    def create_input_data(file_path: str) -> None:
        try:
            input_file = open(file_path, "wb")
            string = input("Enter your input data: ")
            while(IOManipulator.__validate_string_on_escape_seq(string)):
                input_data = string + "\n"
                byte_input_data = input_data.encode()
                input_file.write(byte_input_data)
                string = input("Enter your input data: ")
        except KeyboardInterrupt:
            pass
        finally:
            input_file.close()

    @staticmethod
    def write_phone_call_data_in_output_by_certain_criteria(input_path: str, output_path: str) -> None:
        try:
            input_file = open(input_path, "rb")
            output_file = open(output_path, "ab")
            for line in input_file:
                string = line.decode()
                string = string.replace("\n", " ")
                if(string != " "):
                    phone_call_data = string.split(" ")
                    phone_call = PhoneCall(
                        phone_call_data[0], phone_call_data[1], phone_call_data[2])
                    phone_call_length = phone_call.get_current_phone_call_length()
                    if(IOManipulator.__is_fullfilling_creteria(phone_call_length)):
                        output_file.write(repr(phone_call).encode())
        except:
            raise ValueError(
                "All your input lines should follow the pattern: Calling_Number HH:MM HH:MM ")
        finally:
            output_file.close()
            input_file.close()

    @staticmethod
    def __is_fullfilling_creteria(phone_call_length: int) -> bool:
        return phone_call_length >= 3

    @staticmethod
    def print_data_from_file(file_path: str) -> None:
        file = open(file_path, "rb")
        for data_unit in file:
            line = data_unit.decode().replace("\n", "")
            print(line)

    @staticmethod
    def print_data_from_file_with_message(header: str, file_path: str) -> None:
        print("\n--------------" + header + "--------------")
        IOManipulator.print_data_from_file(file_path)
        print("------------------------------------\n")
