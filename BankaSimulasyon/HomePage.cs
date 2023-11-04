using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaSimulasyon
{
    public partial class HomePage : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public string hesap;
        public HomePage()
        {
            InitializeComponent();
            random = new Random();
            //BtnClose.Visible = false; //ana ekrana dönme butonu anasayfada gizli konumda
            this.Text = string.Empty;
            this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//ekranı yukarı atınca tam ekran olsun kodu
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HomePage_Load(object sender, EventArgs e)
        {
            InfoFetch();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex==index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor= color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    PanelTitleBar.BackColor = color;
                    PanelInfoBar.BackColor = color;                    
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //BtnClose.Visible = true;//aktif olan sayfada görünür hale gelir ki geri dönülebilsin

                }
            }           
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 54, 90);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;           
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktopPanel.Controls.Add(childForm);
            this.PanelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = childForm.Text;
        }
      
        void InfoFetch()
        {
            List<EntityCustomer> CustomerInfo = LogicCustomer.LLCustomerInfo(hesap);
            foreach (var item in CustomerInfo)
            {
                string adsoyad= item.Ad + " " + item.Soyad;
                LblAdSoyad.Text = adsoyad;             
                LblHesapNo.Text = item.Hesapno;
                LblTcNo.Text = item.Tc;
                LblTelefon.Text = item.Telefon;
                LblTitle.Text = "Hoşgeldiniz";
            }
        }
        private void BtnHesap_Click(object sender, EventArgs e)
        {            
            OpenChildForm(new Forms.AccountStatementForm(hesap), sender);
        }

        private void BtnCekim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DpstWthdrwlPrcsForm(hesap), sender);
        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BillsForm(hesap), sender);
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TransferForm(hesap), sender);
        }

        /*
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
                Reset();
            }
        }*/
        private void Reset()
        {
            DisableButton();
            InfoFetch();
            PanelTitleBar.BackColor = Color.FromArgb(42, 54, 90);
            PanelInfoBar.BackColor = Color.FromArgb(42,54,90);
            PanelLogo.BackColor=Color.FromArgb(39, 39, 58);
            currentButton = null;
            //BtnClose.Visible = false;//anasayfaya dönüldüğünde buton eski haline gelir.
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAllClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //büyültme küçültme butonları da eklersek
            /*
             * maksimize
              if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
               
                minimize
                 this.WindowState = FormWindowState.Minimized;
             */

        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
    }
}
