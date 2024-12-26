using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Alarm System");

        // دریافت زمان هشدار از کاربر
        Console.WriteLine("Enter the time for alarm (HH:mm format):");
        string inputTime = Console.ReadLine();
        
        DateTime alarmTime;
        if (DateTime.TryParse(inputTime, out alarmTime))
        {
            SetAlarm(alarmTime);
        }
        else
        {
            Console.WriteLine("Invalid time format. Please use HH:mm format.");
        }
    }

    static void SetAlarm(DateTime alarmTime)
    {
        Console.WriteLine($"Alarm set for {alarmTime:HH:mm}");

        while (true)
        {
            // بررسی می‌کنیم که آیا زمان فعلی برابر با زمان هشدار است یا نه
            if (DateTime.Now >= alarmTime)
            {
                Console.WriteLine("Time's up! Alarm ringing...");
                PlayAlarmSound();
                break;
            }
            Thread.Sleep(1000); // هر ثانیه یک بار چک می‌کنیم
        }
    }

    static void PlayAlarmSound()
    {
        // پخش صدای هشدار
        using (System.Media.SystemSounds.Beep)
        {
            SystemSounds.Beep.Play();
        }
    }
}
