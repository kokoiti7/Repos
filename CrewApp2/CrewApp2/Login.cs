using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewApp2
{


    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

        }


        private void Logi_Click(object sender, EventArgs e)
        {

            string SqlConnectionstring = @"Data Source=temmazure.database.windows.net;Initial Catalog=AZUREDB;Persist Security Info=True;User ID=kmito;Password=Kk310pom;";

          
                SqlConnection sqlCon = new SqlConnection(SqlConnectionstring);
                try
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed) sqlCon.Open();
                    string quely = "SELECT count(1) FROM MyCompany_Member_TB WHERE LoginName=@LoginName AND LoginPass=@LoginPass";

                    SqlCommand SqlCmd = new SqlCommand(quely, sqlCon);
                    SqlCmd.CommandType = System.Data.CommandType.Text;
                    SqlCmd.Parameters.AddWithValue("@LoginName", LoginUserName.Text);
                   //  MessageBox.Show(LoginUserName.Text);
                    SqlCmd.Parameters.AddWithValue("@LoginPass", PasswordText.Text);
                   // MessageBox.Show(PasswordText.Text);

                    int count = Convert.ToInt32(SqlCmd.ExecuteScalar());
                    if (count == 1)
                    {

                        Form1 Form1 = new Form1();
                        Properties.Settings.Default.UserNames = LoginUserName.Text;

                        Properties.Settings.Default.Save();

                        Form1.logname = LoginUserName.Text;

                        this.Close();
                    }

                    else

                    {
                        MessageBox.Show("Username or Password is in correct.");

                    }


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sqlCon.Close();

                }
         }

            

    }
}


    


