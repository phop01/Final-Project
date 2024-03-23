using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        //อ็อบเจ็ค data
        Data data;
        //Listของอ็อบเจ็ค data
        List<Data> Listdata = new List<Data>();
        //อ็อบเจ็ค CSV เอาไว้เขียนไฟล์
        CSV CSV = new CSV();

        private void button2_Click(object sender, EventArgs e)
        {
            //สร้าง อ็อบเจ็คใหม่ทุกครั้งเมื่อทำการกดปุ่มนี้
            data = new Data();
            //ตั้งค่าข้อมูลให้กับ อ็อบเจ้ค
            data.namedata = name.Text;
            data.last_name = last_name.Text;
            data.age = int.Parse(age.Text);
            data.gender = gender.Text;
            data.weight = double.Parse(WeightTB.Text);
            data.height = double.Parse(HeightTB.Text);
            BMILabel.Text = data.GetBMI().ToString("0.00");

            //เรียกใช้ฟังก์ชัน BMILevel() เพื่อทราบค่าเกณฑ์
            LevelLabel.Text = data.BMILevel();
            //แสดงรูปภาพตามน้ำหนัก
            DisplayPicture.Image = data.DisplayImage();
            //แสดงคำอธิบาย
            scrip.Text = data.Description();
            
            //เพิ่มอ็อบเจ็ค data เข้าไปใน listdata
            Listdata.Add(data);
            //นำข้อมูลไปแสดงบน ตาราง datagridview 
            dataView.Rows.Add(data.namedata, data.last_name, data.age, data.gender, data.weight, data.height, data.GetBMI().ToString("0.00"), data.BMILevel());

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //ปุ่มลบข้อมูลที่กรอก รูป เกณฑ์ และคำบรรยาย
            name.Text = string.Empty;
            last_name.Text = string.Empty;
            gender.Text = string.Empty;
            age.Text = string.Empty;
            WeightTB.Text = string.Empty;
            HeightTB.Text = string.Empty;
            LevelLabel.Text = string.Empty;
            scrip.Text = string.Empty;
            BMILabel.Text = string.Empty;
            DisplayPicture.Image = null;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ทำการบันทึกข้อมูลลงไฟล์
            CSV.SavetoFile(Listdata);
        }
    }
}
