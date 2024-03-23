using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Data : BMI
    {
        //หลักการสำคัญของ Encapsulation:
        //การซ่อนข้อมูล: ข้อมูลภายใน object จะถูกซ่อนจากผู้ใช้ภายนอก ผู้ใช้สามารถเข้าถึงข้อมูลได้ผ่าน interface ที่กำหนดไว้เท่านั้น
        //การรวมกลุ่มข้อมูล: ข้อมูลที่เกี่ยวข้องกันจะถูกจัดกลุ่มเข้าด้วยกันใน object เดียว
        //การจำกัดการเข้าถึง: กำหนดสิทธิ์การเข้าถึงข้อมูลและวิธีการภายใน object ว่าใครสามารถเข้าถึงได้บ้าง
        //Inheritance หรือ การสืบทอด ในภาษาโปรแกรมเชิงวัตถุ หมายถึง ความสามารถของ class หนึ่ง  ในการสืบทอดคุณสมบัติ (field, method) จาก class อื่น (superclass)
        private string name;
        public string last_name;
        public int age;
        public string gender;

        //Getter setter
        public string namedata
        {
            get {  return name; }
            set {  name = value; }
        }

    }
}
