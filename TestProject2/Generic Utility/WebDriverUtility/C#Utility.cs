using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hiten_s_Automation_Exercise.GenericUtility.WebDriverUtility
{
    internal class C_Utility
    {
        public int Random_Num(int size)
        {
            Random r=new Random();
            int r_no=r.Next(size);
            return r_no;
        }

        public string CurrentDate(string format)
        {
            DateTime dt=DateTime.Now;
            return dt.ToString(format);
        }

        public string RequiredDate(string format,int days)
        {
            DateTime dt = DateTime.Now;
            DateTime dtf=dt.AddDays(days);
            return dtf.ToString(format);
        }
        
        public StringBuilder AlphanumericString(int size)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < size; i++)
            {
                Random r = new Random();
                int index = (int)(alpha.Length * r.Next(100));
                sb.Append(alpha.Substring(index));
            }
            return sb;
        }

        public StringBuilder AlphabeticString(int size)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                Random r = new Random();
                int index = (int)(alpha.Length * r.Next(100));
                sb.Append(alpha.Substring(index));
            }
            return sb;
        }

        public StringBuilder RequiredDataString(int size,string data)
        {            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                Random r = new Random();
                int index = (int)(data.Length * r.Next(100));
                sb.Append(data.Substring(index));
            }
            return sb;
        }
    }
}
