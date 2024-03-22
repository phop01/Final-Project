using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class CSV
    {
        //ที่อยู่ของไฟล์
        private string path = @"D:\oop\Final Project\dataBMI.csv";

        public bool SavetoFile(List<Data> data)
        {
            //จัดข้อมูลให้อยู่ในรูปแบบ ไฟล์ CSV 
            string content = "";
            foreach(Data i in data)
            {
                content += i.name + "," + i.last_name + "," + i.gender + "," +i.age + "," + i.weight + "," + i.height + "," + i.GetBMI() + "," + i.BMILevel()+"\n";
            }
            try
            {
                File.AppendAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
