using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment(new Patient("Steven Jhonson", "986782342", "5555-555-555",  "43"), new Doctor("Armand", "Surgeon"),DateTime.Now, "Wall Street", true);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(new Patient("Ralf Manson", "", "5555-555-555", "ad"), new Doctor("","ad"), DateTime.Now, "Queen Street", true);
            Console.WriteLine(appointmentResult2);
        }
    }
}
