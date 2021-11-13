using System;

namespace TimeKeeping;

class Program {
    static void Main(string[] args)


    {
        Console.WriteLine("Employee Time Keeping Console System - Overtime\n");

        DateTime showDate = DateTime.Now;

        Console.WriteLine($"Today's Date:  {showDate:MMMM dd, yyyy}\n");

        Console.Write($"Enter your Employee ID to Login Time-In: ");

        string employeeId = Console.ReadLine();

        Console.WriteLine("");

        /*
        DateTime showTimeIn = DateTime.Now;
        string variableTimeIn = showTimeIn.ToLongTimeString();   //Real Time
        Console.WriteLine($"Login Time: {variableTimeIn}");
        int timeIn = int.Parse(variableTimeIn);
       */

        TimeSpan timeIn = new TimeSpan(8, 0, 0);

        Console.WriteLine($"Login Time: {timeIn}\n");

        Console.WriteLine("/////////////////////////\n");

        Console.Write("Enter again your Employee ID to Login Time-Out: ");

        employeeId = Console.ReadLine();

        /*
         DateTime showTimeOut = DateTime.Now;
         string variableTimeOut = showTimeOut.ToLongTimeString(); //Real Time
         Console.WriteLine($"Login Time: {variableTimeOut}");
         int timeOut = int.Parse(variableTimeOut); 
        */

        Console.WriteLine();

        TimeSpan timeOut = new TimeSpan(19, 30, 0);

        Console.WriteLine($"Logout Time: {timeOut}\n");

        TimeSpan lunchBreak = new TimeSpan(1, 0, 0);

        TimeSpan totalHours = (timeOut - timeIn) - lunchBreak; //**

        //System.DateTime totalHourss = (timeOut - timeIn) - lunchBreak; //Real Time


        Console.WriteLine($"Total Hours Worked: {totalHours}\n");

        TimeSpan regularHours = new TimeSpan(8, 0, 0);

        TimeSpan overTime = totalHours - regularHours;

        Console.WriteLine($"Total Overtime Hours Worked: {overTime}\n");

        











    }


} 
