using System;
using System.Collections.Generic;

namespace LoginSystem
{
    class Program
    {
        // لیست کاربران و رمزهای عبور
        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== سیستم ورود و خروج ===");
                Console.WriteLine("1. ثبت نام");
                Console.WriteLine("2. ورود به سیستم");
                Console.WriteLine("3. خروج از برنامه");
                Console.Write("انتخاب کنید: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        Console.WriteLine("خروج از برنامه. خداحافظ!");
                        return;
                    default:
                        Console.WriteLine("انتخاب نامعتبر! لطفاً دوباره امتحان کنید.");
                        break;
                }
            }
        }

        // تابع ثبت نام
        static void Register()
        {
            Console.Write("\nنام کاربری را وارد کنید: ");
            string username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("این نام کاربری قبلاً ثبت شده است.");
                return;
            }

            Console.Write("رمز عبور را وارد کنید: ");
            string password = Console.ReadLine();

            users[username] = password;
            Console.WriteLine("ثبت نام با موفقیت انجام شد!");
        }

        // تابع ورود
        static void Login()
        {
            Console.Write("\nنام کاربری را وارد کنید: ");
            string username = Console.ReadLine();

            Console.Write("رمز عبور را وارد کنید: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("ورود موفقیت‌آمیز! خوش آمدید، " + username + ".");
            }
            else
            {
                Console.WriteLine("نام کاربری یا رمز عبور اشتباه است!");
            }
        }
    }
}
