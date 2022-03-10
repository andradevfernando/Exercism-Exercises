namespace exercism.src.classes
{
    public class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            bool IsNewYork = false;
            bool IsFake = false;
            string LocalNumber;

            var number = phoneNumber.Split('-');

            if (number[0] == "212")
                IsNewYork = true;

            if (number[1] == "555")
                IsFake = true;

            LocalNumber = number[2];

            return (IsNewYork, IsFake, LocalNumber);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake;
        }
    }
}