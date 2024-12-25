using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // لیست برای ذخیره مخاطبین
        List<string> contacts = new List<string>();
        string command;

        // حلقه برای تعامل با کاربر
        do
        {
            // نمایش منو به کاربر
            Console.WriteLine("\n--- مدیریت لیست مخاطبین ---");
            Console.WriteLine("1. اضافه کردن مخاطب");
            Console.WriteLine("2. نمایش مخاطبین");
            Console.WriteLine("3. حذف مخاطب");
            Console.WriteLine("4. خروج");
            Console.Write("لطفاً دستور مورد نظر را وارد کنید: ");
            command = Console.ReadLine();

            // انجام عملیات بر اساس دستور وارد شده
            switch (command)
            {
                case "1":
                    // اضافه کردن مخاطب جدید
                    Console.Write("نام مخاطب جدید را وارد کنید: ");
                    string contact = Console.ReadLine();
                    contacts.Add(contact);
                    Console.WriteLine($"مخاطب {contact} با موفقیت اضافه شد.");
                    break;

                case "2":
                    // نمایش مخاطبین موجود
                    if (contacts.Count > 0)
                    {
                        Console.WriteLine("\nمخاطبین موجود:");
                        foreach (var c in contacts)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    else
                    {
                        Console.WriteLine("هیچ مخاطبی برای نمایش وجود ندارد.");
                    }
                    break;

                case "3":
                    // حذف مخاطب
                    Console.Write("نام مخاطب را وارد کنید که می‌خواهید حذف کنید: ");
                    string deleteContact = Console.ReadLine();
                    if (contacts.Contains(deleteContact))
                    {
                        contacts.Remove(deleteContact);
                        Console.WriteLine($"مخاطب {deleteContact} با موفقیت حذف شد.");
                    }
                    else
                    {
                        Console.WriteLine("مخاطب وارد شده وجود ندارد.");
                    }
                    break;

                case "4":
                    // خروج از برنامه
                    Console.WriteLine("خروج از برنامه...");
                    break;

                default:
                    // دستور وارد شده نامعتبر
                    Console.WriteLine("دستور نامعتبر است. لطفاً دوباره امتحان کنید.");
                    break;
            }

        } while (command != "4"); // حلقه تا زمانی که کاربر گزینه 4 (خروج) را وارد کند ادامه دارد
    }
}
