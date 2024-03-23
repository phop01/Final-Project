﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class BMI
    {
        public Image[] image = new Image[]
        {
            Properties.Resources.Underweight , Properties.Resources.Normal , Properties.Resources.fat1 , Properties.Resources.fat2 , Properties.Resources.fat3
        };
        public string[] description = new string[]
        {
            "บุคคลที่มีค่า BMI ในเกณฑ์ระดับน้ำหนักต่ำกว่ามาตรฐานมีภาวะ\nความเสี่ยงสูงที่ร่างกายขาดสารอาหารในการหล่อเลี้ยงภายในร่างกายได้ไม่เพียงพอ \nส่งผลกระทบให้ร่างกายอ่อนเพลียง่าย ภูมิคุ้มกันพกบร่องการออกกำลังกายควบคู่กับ\nการรับประทานอาหารที่มีส่วนประกอบโปรตีนสูง จะช่วยทำให้กล้ามเนื้อแข็งแรงและ\nมีสารอาหารมากพอไปซ่อมแซม\nการทำงานของอวัยวะภายในได้อย่างเพียงพอ"
            ,"บุคคลที่ค่า BMI อยู่ในเกณฑ์ระดับน้ำหนักตามมาตรฐาน \nเป็นกลุ่มบุคคลที่มีภาวะเสี่ยงต่อโรคแทรกซ้อนจากโรคอ้วนได้น้อยที่สุด\n ควรรักษาความสุมดลของค่า BMI ระดับนี้ไว้อย่างสม่ำเสมอ \nและหมั่นตรวจเช็คการคำนวณค่า BMI \nจากการตรวจสุขภาพประจำปี\n เพื่อเป็นผลชี้วัดในการตรวจเช็คมวลร่างกายอยู่เสมอ"
            ,"บุคคลที่มีค่า BMI อยู่ในเกณฑ์ระดับเกินตามมาตรฐาน \nมีภาวะความเสี่ยงที่เกิดโรคแทรกซ้อนที่เกิดจากโรคอ้วนได้ \nควรควบคุมปริมาณไขมันในร่างกายตัวเอง \nด้วยการเลือกทานอาหารที่มีโปรตีนสูง \nหมั่นออกกำลังกายและพักผ่อนให้เพียงพอตลอดกิจวัตรประจำวัน \nเพื่อลดระดับไขมันให้กลับมาอยู่ในเกณฑ์มาตรฐาน"
            ,"บุคคลที่คํานวณค่า BMI แล้วอยู่ในเกณฑ์ระดับเกินตามมาตรฐานมาก \nมีภาวะความเสี่ยงที่เกิดโรคแทรกซ้อนที่เกิดจากโรคอ้วนได้สูง \nควรควบคุมปริมาณไขมันในร่างกายตัวเองแบบเร่งด่วน \nด้วยการปรับเปลี่ยนวิถีการกินที่เน้นสุขภาพให้มากขึ้นพร้อมออกกำลังกาย\n และงดทานของจุบจิบในยามท้องว่างแล้วดื่มน้ำอย่างต่ำ 8 แก้วต่อวัน\n พร้อมกับพักผ่อนให้เพียงพอ \n และติดตามผล BMI ตลอดในช่วงควบคุมน้ำหนัก"
            ,"บุคคลที่มีค่า BMI อยู่ในเกณฑ์ระดับสูงเกินตามมาตรฐานมากมีภาวะความเสี่ยงที่\nเกิดโรคแทรกซ้อนที่เกิดจากโรคอ้วนได้สูงที่สุด\nควรทำการนัดพบแพทย์เพื่อรับยาในการควบคุมปริมาณน้ำตาลในเลือด\nพร้อมปรับเปลี่ยนพฤติกรรมการทานให้เป็นอาหารสุขภาพ \nงดทานอาหารที่เพิ่มมวลไขมันแก่ร่างกายและหมั่นออกกำลังกาย\nเป็นกิจวัตรประจำวันอย่างสม่ำเสมอ พักผ่อนให้เพียงพอ\nแล้วดื่มน้ำอย่างต่ำ 10-12 แก้วต่อวันและติดตามผล BMI ตลอดในช่วงควบคุมน้ำหนัก"
        };
        ////Information hiding หรือ encapsulation ในภาษา C# คือหลักการเขียนโปรแกรมที่มุ่งเน้นไปที่การจำกัดการเข้าถึงโดยตรงไปยังข้อมูลภายในของ object หลักการนี้มุ่งเน้นไปที่การควบคุมวิธีการเข้าถึงและแก้ไขข้อมูลภายใน class
        private int get_index;
        protected double bmi;
        public double height;
        public double weight;
        private string level;


        public string Description()
        {
            return description[get_index];
        }
        public double GetBMI()
        {
            //สูตรคำนวณBMI
            double bmi = weight / (Math.Pow((double)(height / 100),2));
            return bmi;
        }
        
        public Image DisplayImage()
        {
            return image[get_index];
        }
        public string BMILevel()
        {
           //ตรวจสอบว่าค่าBMIอยุ่ที่เท่าไร
            bmi = GetBMI();
            if(bmi < 18.5)
            {
                get_index = 0;
                level = "น้ำหนักต่ำกว่าเกณฑ์";
                return level;
            }
            else if(bmi >=18.5 && bmi <= 22.90)
            {
                get_index = 1;
                level = "น้ำหนักสมส่วน";
                return level;
            }
            else if (bmi >= 23 && bmi <= 24.90)
            {
                get_index = 2;
                level = "น้ำหนักเกินมาตรฐาน";
                return level;
            }
            else if (bmi >= 25 && bmi <= 29.90)
            {
                get_index = 3;
                level = "น้ำหนักอยู่ในเกณฑ์อ้วน";
                return level;
            }
            else 
            {
                get_index = 4;
                level = "น้ำหนักอยู่ในเกณฑ์อ้วนมาก";
                return level;
            }
        }
    }
}
