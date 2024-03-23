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
        //��ͺ�� data
        Data data;
        //List�ͧ��ͺ�� data
        List<Data> Listdata = new List<Data>();
        //��ͺ�� CSV ��������¹���
        CSV CSV = new CSV();

        private void button2_Click(object sender, EventArgs e)
        {
            //���ҧ ��ͺ������ء��������ͷӡ�á��������
            data = new Data();
            //��駤�Ң��������Ѻ ��ͺ��
            data.namedata = name.Text;
            data.last_name = last_name.Text;
            data.age = int.Parse(age.Text);
            data.gender = gender.Text;
            data.weight = double.Parse(WeightTB.Text);
            data.height = double.Parse(HeightTB.Text);
            BMILabel.Text = data.GetBMI().ToString("0.00");

            //���¡��ѧ��ѹ BMILevel() ���ͷ�Һ���ࡳ��
            LevelLabel.Text = data.BMILevel();
            //�ʴ��ٻ�Ҿ������˹ѡ
            DisplayPicture.Image = data.DisplayImage();
            //�ʴ���͸Ժ��
            scrip.Text = data.Description();
            
            //������ͺ�� data ����� listdata
            Listdata.Add(data);
            //�Ӣ�������ʴ��� ���ҧ datagridview 
            dataView.Rows.Add(data.namedata, data.last_name, data.age, data.gender, data.weight, data.height, data.GetBMI().ToString("0.00"), data.BMILevel());

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //����ź�����ŷ���͡ �ٻ ࡳ�� ��ФӺ�����
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
            //�ӡ�úѹ�֡������ŧ���
            CSV.SavetoFile(Listdata);
        }
    }
}
