using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProblem
{
    internal class EmployeeWage
    {
        Random attendance = new Random();
        int Employee_Present = 1;
        
        int Wage_Per_Hour = 20;
        int Working_Hour = 0;
        int Max_Working_Hour = 100;
        int Max_Working_Day = 20;
        int Full_day = 8;
        int Half_Day = 4;

        int Total_working_Hour = 0;
        int Empolyee_working_Hour = 0;
        int Absent = 0;
        public void Employee()
        {

            int Today = Convert.ToInt32(attendance.Next(0, 3));
            int Total_working_Hour = 0;
            int Total_Working_Days = 1;
            int Full_Time = 1;
            int Part_Time = 2;
            
            while (Total_Working_Days<=Max_Working_Day && Total_working_Hour <= Max_Working_Hour)
            {
                switch (Today)
                {
                    case 0:
                        Empolyee_working_Hour = 0;
                        break;

                    case 1:
                        Empolyee_working_Hour = 8;
                        break;
                    case 2:
                        Empolyee_working_Hour = 4;
                        break;
                }

                Total_Working_Days++;
                Total_working_Hour= Total_working_Hour + Empolyee_working_Hour;
            }
            Console.WriteLine("Total working days" + Total_Working_Days + "/n Total working Hours:" + Total_working_Hour);
            Console.WriteLine("Total wage earn" + Total_working_Hour * 20);
        
        }
    }
}
