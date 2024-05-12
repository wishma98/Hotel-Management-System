namespace Hotel_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          this.Close(); 
            login login = new login();
            
            login.Close();
        }
    }
}
