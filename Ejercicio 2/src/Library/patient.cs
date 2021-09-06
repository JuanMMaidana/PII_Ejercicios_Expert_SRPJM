using System;
using System.Text;

namespace Library
{
    public class Patient
    {

        private string name;
        private string id;
        private string phoneNumber;
        private string age;
        public bool isValid;
        public Patient(string name, string id, string phoneNumber, string Age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = Age;
        }
        public string Name{

            get{

                return name;

            }
        
            set{
                
                if (string.IsNullOrEmpty(name))

                    isValid = false;

            }
        }


        public string Id{
            
            get{

                return id;

            }
        
            set{
                
                if (string.IsNullOrEmpty(id))

                    isValid = false;

            }
        }


        public string PhoneNumber{
            
            get{

                return phoneNumber;

            }
        
            set{
                
                if (string.IsNullOrEmpty(phoneNumber))

                    isValid = false;

            }
        }


        public string Age{
            
            get{

                return age;

            }
        
            set{
                
                if (string.IsNullOrEmpty(age))

                    isValid = false;

            }
        }
    }
}



