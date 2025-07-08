namespace Doctor_Codenstein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_AddIng_Click(object sender, EventArgs e)
        {
            //if �����������, ���� ����� ����� �������, �� ������������ ������ �� ������ ������� �������� � Textbox-�.
            if (txt_Input.Text == "")
            {
                //������, ����� ������� �������� �� �����������.
                MessageBox.Show("���� �������� ��������!", "���� ��������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                //�������� �� ������ �� TextBox-� � ListBox-� � ���������� �� ������ � ����� TextBox.
                //��������� ������ .ToLower �� ��-����� ����������� ��� if ������������� �� ��������� �� ������ ������.
                lb_Ingridients.Items.Add(txt_Input.Text.ToLower());
                txt_Input.Clear();
            }
        }

        private void btn_CookPot_Click(object sender, EventArgs e)
        {
          
            //��� �� ���������� ������ �� ���������� � �������� �� ������ � ������ ListBox, ���� ��� ���������� ChatGPT, ������ �� �������� .Items
            if (lb_Ingridients.Items.Contains("������� ������") && lb_Ingridients.Items.Contains("����� ����"))
            {
                //��������� �� ��������� � ��������� �� �������
                lbl_FunMes.Text = "������� ���������� �� 10 ������!";
                lb_Ingridients.Items.Clear();
            }
            else if (lb_Ingridients.Items.Contains("�����") && lb_Ingridients.Items.Contains("�����"))
            {
                //��������� �� ��������� � ��������� �� ������� --> copy paste �� ��-����.
                lbl_FunMes.Text = "������� ������ ������!";
                lb_Ingridients.Items.Clear();
            }
            else if (lb_Ingridients.Items.Contains("�������") && lb_Ingridients.Items.Contains("����"))
            {
                //��������� �� ��������� � ��������� �� ������� --> copy paste �� ��-����.
                lbl_FunMes.Text = "������� ����������� ����� ���� �����!";
                lb_Ingridients.Items.Clear();
            }
            else
            {
                lbl_FunMes.Text = "���������� ������ �������, �� ���� ��������� �� �� ������.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                //����� �� ���������� �� ������ � ListBox-�.
                lb_Ingridients.Items.Clear();
            }
                
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            //���� ����� �� ��������� �� ����������� � ����������.
            MessageBox.Show("���� � ��������, � ����� ����� �� ������ ������. ������ �������� � ������ � ������ ������!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
