using BusinessLogic;
using Models;
using System.ComponentModel.DataAnnotations;




namespace SemesterProjektDenAnden.LogInForms
{
    public partial class ClientSignUp : Form
    {
        ClientLogIn clientLogIn;
        ClientBL ClientBL = new ClientBL();
        
        public ClientSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientLogIn = new ClientLogIn();
            clientLogIn.Show();
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string message = "Er du sikker på du vil oprette en bruger med de indtastede værdier?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "Opret Bruger", buttons);
            if(result == DialogResult.Yes)
            {

                
                Client newClient = new Client();
                newClient.FirstName = FnameTxt.Text;
                newClient.LastName = LnameTxt.Text;
                newClient.Phone = int.Parse(PhoneTxt.Text);
                newClient.Mail = MailTxt.Text;
                newClient.ClAddress = AddressTxt.Text;
                var context = new ValidationContext(newClient, serviceProvider: null, items: null);
                bool isValid = Validator.TryValidateObject(newClient, context, null, true);

                if (isValid)
                {
                    bool createResult = await ClientBL.CreateAsync(newClient);
                    if (createResult)
                    {
                        MessageBox.Show("Bruger oprettet", "Bruger oprettet");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fejl: Bruger ikke oprettet", "Fejl");
                    }
                }
                else { MessageBox.Show("Fejl: Bruger ikke oprettet", " info ikke valid"); };




            }

        }
    }
}
