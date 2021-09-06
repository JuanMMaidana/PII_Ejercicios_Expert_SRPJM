using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string doctorsName;
        private string doctorSpeciality;
        public bool isValid;

        public Doctor(string doctorsName, string doctorSpeciality)
        {
            this.DoctorsName = doctorsName;
            this.DoctorSpeciality = doctorSpeciality;
        }

        public string DoctorsName{
            
            get{

                return doctorsName;

            }
        
            set{
                
                if (string.IsNullOrEmpty(doctorsName))

                    isValid = false;

            }
        }

        public string DoctorSpeciality{
            
            get{

                return doctorSpeciality;

            }
        
            set{

                if (string.IsNullOrEmpty(doctorSpeciality))

                    isValid = false;

            }
        
        
        }




    }
}

