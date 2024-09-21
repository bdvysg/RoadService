using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RoadService.Classes
{
    static class DateManager
    {
        private static DateTime Now()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
        }

        private static void SetCustomFormat(DateTimePicker obj)
        {
            obj.Format = DateTimePickerFormat.Custom;
            obj.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        public static void SetUpDateTimePicker(DateTimePicker obj)
        {
            SetCustomFormat(obj);
            obj.Value = Now();
        }

        public static bool IsValidDate(DateTime date1, DateTime date2)
        {
            date1 = new DateTime(date1.Year, date1.Month, date1.Day, date1.Hour, 0, 0);
            date2 = new DateTime(date2.Year, date2.Month, date2.Day, date2.Hour, 0, 0);

            if (DateTime.Now >= date1)
            {
                MessageBox.Show("Дата початку не може бути меншою або дорівнювати сьогодішній даті");
                return false;
            }

            if (DateTime.Now >= date2)
            {
                MessageBox.Show("Дата кінця не може бути меншою або дорівнювати сьогоднішній даті");
                return false;
            }

            if (date1 >= date2)
            {
                MessageBox.Show("Дата початку не може бути меншою або дорівнювати даті закінчення завдання");
                return false;
            }

            return true;
        }
    }
}
