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
            //if конструкция, чрез която става сигурно, че потребителят трябва да въведе някаква съствака в Textbox-а.
            if (txt_Input.Text == "")
            {
                //Грешка, която показва проблема на потребителя.
                MessageBox.Show("Моля въведете съставка!", "Няма съставка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                //Добавяне на текста от TextBox-а в ListBox-а и изчистване на текста в самия TextBox.
                //Използвам метода .ToLower за по-лесна манипулация във if конструкцията за създаване на самата отвара.
                lb_Ingridients.Items.Add(txt_Input.Text.ToLower());
                txt_Input.Clear();
            }
        }

        private void btn_CookPot_Click(object sender, EventArgs e)
        {
          
            //Тук са използвани методи за достъпване и проверка на текста в самият ListBox, като тук изпозлзвах ChatGPT, защото ми липсваше .Items
            if (lb_Ingridients.Items.Contains("котешка козина") && lb_Ingridients.Items.Contains("течен азот"))
            {
                //Показване на резултата и изтриване на списъка
                lbl_FunMes.Text = "Създаде невидимост за 10 минути!";
                lb_Ingridients.Items.Clear();
            }
            else if (lb_Ingridients.Items.Contains("ягода") && lb_Ingridients.Items.Contains("захар"))
            {
                //Показване на резултата и изтриване на списъка --> copy paste от по-горе.
                lbl_FunMes.Text = "Създаде вкусно сладко!";
                lb_Ingridients.Items.Clear();
            }
            else if (lb_Ingridients.Items.Contains("батерия") && lb_Ingridients.Items.Contains("вода"))
            {
                //Показване на резултата и изтриване на списъка --> copy paste от по-горе.
                lbl_FunMes.Text = "Създаде експлозивен серум… стой далеч!";
                lb_Ingridients.Items.Clear();
            }
            else
            {
                lbl_FunMes.Text = "Получената отвара бълбука, но нищо интересно не се случва.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                //Метод за премахване на текста в ListBox-а.
                lb_Ingridients.Items.Clear();
            }
                
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            //Инфо бутон за въвеждане на потребителя в програмата.
            MessageBox.Show("Това е програма, в която можеш да правиш отвари. Въведи съставки в полето и създай отвари!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
