namespace Baithi_Cau2_NguyenMinhKhang_02PM16B1D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Manager> danhsach1 = new List<Manager>();
        private void button1_Click(object sender, EventArgs e)
        {
            double luong;
            if (double.TryParse(txt_luong.Text, out luong))
            {
                Manager manager = new Manager(txt_hoten.Text, txt_msnv.Text, txt_chucvu.Text, luong, txt_teamz.Text);

                danhsach1.Add(manager);
                dt_1.DataSource = null;
                dt_1.DataSource = danhsach1;
            }
            else
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin Trên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Manager i in danhsach1)
            {
                if (i.Msnv == txt_msnv.Text)
                {
                    danhsach1.Remove(i);
                    break;
                }
            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Manager i in danhsach1)
            {
                if(i.Msnv == txt_msnv.Text)
                {
                    i.Hoten = txt_hoten.Text;
                    i.Chucvu = txt_chucvu.Text;
                    i.Teamsize = txt_teamz.Text;
                    i.Luong = double.Parse(txt_luong.Text);
                }
            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;
        }
    }
}
