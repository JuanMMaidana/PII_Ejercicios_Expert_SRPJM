using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public bool isValid = true;
        public static string CreateAppointment( Patient Patient, Doctor Docotr, DateTime date, string appoinmentPlace, bool isValid)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");


            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
            else 
            {
                stringBuilder.Append("Couln't make the appointment, make sure that you entred the right data.");
            }

            return stringBuilder.ToString();
        }

    }
}
