namespace exercism.src.classes
{
    public class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            return DateTime.Parse(appointmentDateDescription);
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            return appointmentDate < DateTime.Now;
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
        }

        public static string Description(DateTime appointmentDate)
        {
            return $"You have an appointment on {appointmentDate.ToString()}.";
        }

        public static DateTime AnniversaryDate()
        {
            return new DateTime(2022, 9, 15, 0, 0, 0);
        }
    }
}