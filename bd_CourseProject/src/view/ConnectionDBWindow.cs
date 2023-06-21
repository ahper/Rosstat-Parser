using System;
using System.Windows.Forms;
using System.Drawing;
using bd_CourseProject.src.model;
using MaterialSkin.Controls;
using Microsoft.SqlServer.Management.HadrData;
using bd_CourseProject.Properties;
using Microsoft.SqlServer.Management.Smo;

namespace bd_CourseProject.src.view
{
    public partial class ConnectionDBWindow : MaterialForm
    {
        string nameSQLServer;
        string initialCatalog;
        string login;
        string password;
        TextBox tbLogin, tbPassword;
        Button btnConnectDB, btnRefreshListBD;

        public ConnectionDBWindow()
        {
            InitializeComponent();
        }

        private void ConnectionDBWindow_Load(object sender, EventArgs e)
        {
            cbAuthentication.SelectedIndex = 0;
        }

        private void CbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAuthentication.SelectedIndex)
            {
                case 0:
                    panel1.Controls.Clear();
                    Label lbNameBD = new Label
                    {
                        Text = "Имя БД",
                        Location = new Point(0, 4),
                        Size = new Size(50, 13),
                        Font = new Font("Verdana", 8)
                    };
                    cbNameBD = new ComboBox
                    {
                        Name = "cbNameBD",
                        Location = new Point(149, 0),
                        Size = new Size(181, 21)
                    };
                    btnRefreshListBD = new Button
                    {
                        Name = "btnRefreshListBD",
                        Location = new Point(335, 0),
                        Size = new Size(28, 21),
                        BackgroundImage = Image.FromFile("C:\\Users\\ahtir\\Desktop\\bd_CourseProject\\bd_CourseProject\\bd_CourseProject\\src\\resources\\btnRefresh.jpg"),
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Cursor = Cursors.Hand
                    };
                    btnConnectDB = new Button
                    {
                        Name = "btnConnectDB",
                        Text = "Соедиинться с БД",
                        Location = new Point(149, 27),
                        Size = new Size(181, 23),
                        Cursor = Cursors.Hand
                    };
                    panel1.Controls.Add(lbNameBD);
                    panel1.Controls.Add(cbNameBD);
                    panel1.Controls.Add(btnRefreshListBD);
                    btnRefreshListBD.Click += BtnRefreshListBD_Click;
                    panel1.Controls.Add(btnConnectDB);
                    btnConnectDB.Click += BtnConnectDB_Click;
                    break;
                case 1:
                    panel1.Controls.Clear();
                    Label lbLogin = new Label
                    {
                        Text = "Логин",
                        Location = new Point(81, 6),
                        Size = new Size(43, 13),
                        Font = new Font("Verdana", 8)
            };
                    Label lbPassword = new Label
                    {
                        Text = "Пароль",
                        Location = new Point(81, 32),
                        Size = new Size(53, 13),
                        Font = new Font("Verdana", 8)
                    };
                    tbLogin = new TextBox
                    {
                        Name = "tbLogin",
                        Location = new Point(149, 3),
                        Size = new Size(100, 20),
                        
                    };
                    tbPassword = new TextBox
                    {
                        Name = "tbPassword",
                        Location = new Point(149, 29),
                        Size = new Size(100, 20),
                        UseSystemPasswordChar = true
                    };
                    lbNameBD = new Label
                    {
                        Text = "Имя БД",
                        Location = new Point(0, 58),
                        Size = new Size(50, 13),
                        Font = new Font("Verdana", 8)
                    };
                    cbNameBD.Location = new Point(149, 55);
                    cbNameBD.Size = new Size(181, 21);

                    btnRefreshListBD.Location = new Point(335, 55);
                    btnRefreshListBD.Size = new Size(29, 21);
   
                    btnConnectDB.Location = new Point(149, 82);
                    btnConnectDB.Size = new Size(181, 23);

                    panel1.Controls.Add(lbLogin);
                    panel1.Controls.Add(lbPassword);
                    panel1.Controls.Add(tbLogin);
                    panel1.Controls.Add(tbPassword);
                    panel1.Controls.Add(lbNameBD);
                    panel1.Controls.Add(cbNameBD);
                    panel1.Controls.Add(btnRefreshListBD);
                    btnRefreshListBD.Click += BtnRefreshListBD_Click;
                    panel1.Controls.Add(btnConnectDB);
                    btnConnectDB.Click += BtnConnectDB_Click;
                    break;
            }
        }

        private void BtnRefreshListBD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNameSQLServer.Text))
            {
                nameSQLServer = tbNameSQLServer.Text; // DESKTOP-RMFRO1F
                foreach (var item in MSSQLQuery.GetDatabaseList(nameSQLServer))
                {
                    if (item != null && !cbNameBD.Items.Contains(item))
                        cbNameBD.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Введите имя SQL сервера!");
        }

        private async void BtnConnectDB_Click(object sender, EventArgs e)
        {
            try
            {
                var flag = true;
                if (string.IsNullOrEmpty(tbNameSQLServer.Text) || string.IsNullOrEmpty(cbNameBD.Text))
                {
                    flag = false;
                    MessageBox.Show("Заполните все поля!");
                    return;
                }
                if (flag)
                {
                    nameSQLServer = tbNameSQLServer.Text; // DESKTOP-RMFRO1F
                    initialCatalog = cbNameBD.Text;

                    switch (cbAuthentication.SelectedIndex)
                    {
                        case 0:
                            await MSSQLQuery.Connection(nameSQLServer, initialCatalog);
                            break;
                        case 1:
                            login = tbLogin.Text;
                            password = tbPassword.Text;
                            await MSSQLQuery.Connection(nameSQLServer, initialCatalog, login, password);
                            break;
                    }

                    var res = MessageBox.Show("Соединение успешно установлено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK) Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
