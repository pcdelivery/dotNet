using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace OfficeStoreApp.Domain.ServiceModules
{
    public static class DateGenerator
    {
        //@todo: Delete this mess
        private static DateTime _help_me(int day, int month, int year)
        {
            string d, m, y;

            d = day < 10 ? d = "0" + day.ToString() : day.ToString();
            m = month < 10 ? d = "0" + month.ToString() : month.ToString();
            y = year.ToString();

            return DateTime.Parse(m + "/" + d + "/" + y.ToString());
        }

        public static DateTime GenerateDateTime(int day = -1, int month = -1, int year = -1)
        {
            int d = day < 0 ? RandomNumberGenerator.GetInt32(1, 31) : day;
            int m = month < 0 ? RandomNumberGenerator.GetInt32(1, 13) : month;

            //@todo: Separate properties file
            int y = year < 0 ? RandomNumberGenerator.GetInt32(2020, 2024) : year;

            //@todo: ...
            return _help_me(d, m, y);
        }

        public static void GenerateDatePeriod(DateTime beginReturn, DateTime endReturn, int day = -1, int month = -1, int year = -1)
        {
            beginReturn = GenerateDateTime(day, month, year);
            endReturn = GenerateDateTime();

            if (endReturn.CompareTo(beginReturn) < 0)
            {
                DateTime temp = beginReturn;
                beginReturn = endReturn;
                endReturn = temp;
            }
        }

        public static DateTime GenerateWideDateTime()
        {
            int d = RandomNumberGenerator.GetInt32(1, 31);
            int m = RandomNumberGenerator.GetInt32(1, 13);
            int y = RandomNumberGenerator.GetInt32(1980, 2020);

            //@todo: ...
            return _help_me(d, m, y);
        }

        public static DateTime GenerateAncientDateTime()
        {
            int d = RandomNumberGenerator.GetInt32(1, 31);
            int m = RandomNumberGenerator.GetInt32(1, 13);
            int y = RandomNumberGenerator.GetInt32(1700, 2020);

            //@todo: ...
            return _help_me(d, m, y);
        }

        public static String DateToShortString(DateTime date) => date.Year + "/" + date.Month;
        public static String DateToTinyString(DateTime date) => date.Year + "/" + date.Month + "/" + date.Day;
    }
}
