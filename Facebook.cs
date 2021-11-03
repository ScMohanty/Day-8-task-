using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Facebook
    {
        string fName;
        string LastName;
        string email;
        long mobileNumber;
        DateTime dob;

        public Facebook(string fName, string lastName1,string email, long mobileNumber, DateTime dob)
        {
            FName = fName;
            LastName1 = lastName1;
            MobileNumber = mobileNumber;
            Dob = dob;
        }

        public string FName { get => fName; set => fName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public long MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)

        {
            Facebook fb = (Facebook)obj;
            return this.Email.Equals(fb.Email);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int fb_user_count;
            Facebook[] fb_users;
            Console.WriteLine("enter fb account count");
            fb_user_count = Convert.ToInt32(Console.ReadLine());
            fb_users = new Facebook[fb_user_count];

            string c_fname;
            string c_LastName;
            string c_email;
            long c_mobileNumber;
            DateTime c_dob;

            for (int i = 0; i < fb_user_count; i++)
            {


                Console.WriteLine("enter fname");
                c_fname = Console.ReadLine();
                Console.WriteLine("enter last name");
                c_LastName = Console.ReadLine();
                Console.WriteLine("ENTER EMAIL");
                c_email = Console.ReadLine();
                Console.WriteLine("ENTER MobileNumber");
                c_mobileNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("ENTER DATE OF BIRTH");
                c_dob = Convert.ToDateTime(Console.ReadLine());

                Facebook fb = new Facebook(c_fname, c_LastName, c_email, c_mobileNumber, c_dob);

                if (!fb_users.Contains(fb))
                {
                    fb_users[i] = fb;
                }
                else
                {
                    Console.WriteLine("ACCOUNT IS ALREADY EXIST");
                }
            }
        }
    }
}
