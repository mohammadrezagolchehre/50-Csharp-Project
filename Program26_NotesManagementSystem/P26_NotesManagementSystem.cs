using System;
using System.Collections.Generic;

namespace NotesManagementSystem
{
    class Program
    {
        static List<string> notes = new List<string>(); // لیست برای ذخیره یادداشت‌ها

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== سیستم مدیریت یادداشت‌ها ===");
                Console.WriteLine("1. افزودن یادداشت");
                Console.WriteLine("2. نمایش تمام یادداشت‌ها");
                Console.WriteLine("3. حذف یادداشت");
                Console.WriteLine("4. خروج");
                Console.Write("انتخاب کنید: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNote();
                        break;
                    case "2":
                        DisplayNotes();
                        break;
                    case "3":
                        RemoveNote();
                        break;
                    case "4":
                        Console.WriteLine("خروج از برنامه. خداحافظ!");
                        return;
                    default:
                        Console.WriteLine("انتخاب نامعتبر! لطفاً دوباره امتحان کنید.");
                        break;
                }
            }
        }

        // تابع افزودن یادداشت
        static void AddNote()
        {
            Console.Write("\nیادداشت خود را وارد کنید: ");
            string note = Console.ReadLine();
            notes.Add(note);
            Console.WriteLine("یادداشت با موفقیت افزوده شد!");
        }

        // تابع نمایش تمام یادداشت‌ها
        static void DisplayNotes()
        {
            if (notes.Count == 0)
            {
                Console.WriteLine("هیچ یادداشتی ثبت نشده است.");
                return;
            }

            Console.WriteLine("\nتمام یادداشت‌ها:");
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {notes[i]}");
            }
        }

        // تابع حذف یادداشت
        static void RemoveNote()
        {
            Console.Write("\nشماره یادداشت مورد نظر برای حذف را وارد کنید: ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= notes.Count)
            {
                notes.RemoveAt(index - 1);
                Console.WriteLine("یادداشت با موفقیت حذف شد.");
            }
            else
            {
                Console.WriteLine("شماره یادداشت نامعتبر است.");
            }
        }
    }
}
