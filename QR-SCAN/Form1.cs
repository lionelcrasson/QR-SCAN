using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Crypt;
using MessagingToolkit.QRCode.ExceptionHandler;
using MessagingToolkit.QRCode.Geom;
using MessagingToolkit.QRCode.Codec.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Windows.Media.Imaging;


namespace QR_SCAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string pathRacine ="c:\\Client_scan" ;
        private string pathUser;
        private string pathQR;

        private void bt_create_qr_Click(object sender, EventArgs e)
        {
            string url = textBox_URL.Text;
            Bitmap qrcode = generateQR(url);
            img_qr.Image = qrcode as System.Drawing.Image;
        }

        private void bt_save_qr_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img_qr.Image.Save(s.FileName);
            }

        }

        private void bt_load_qr_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img_qr.ImageLocation = o.FileName;

            }
        }

        private void bt_extract_qr_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.Decode(new QRCodeBitmapImage(img_qr.Image as Bitmap)));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            string concat = tb_ID.Text + "-" + tb_nom.Text + "-" + tb_prenom.Text; // change to CB - nom - prenom - id
            Bitmap QR = generateQR(concat);
            this.pathUser = this.pathRacine + "\\Client\\" + concat;
            this.pathQR = this.pathUser + "\\" + tb_ID.Text + ".jpg";
            createNewUser();
            System.Drawing.Image QR_Image = QR as System.Drawing.Image;         
            
            QR_Image.Save(this.pathQR);
            createUserDoc();
        }

        private Bitmap generateQR(string text)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap QR = encoder.Encode(text);
            return QR;
        }
        private void createNewUser()
        {
            System.IO.Directory.CreateDirectory(this.pathUser);
            /*DirectoryInfo dInfo = new DirectoryInfo(this.pathUser);
            DirectorySecurity dSecurity = dInfo.GetAccessControl(AccessControlSections.Access);
            dSecurity.AddAccessRule(
                new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null), 
                    FileSystemRights.FullControl, 
                    InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, 
                    PropagationFlags.NoPropagateInherit, 
                    AccessControlType.Allow
                    )
               );
            dInfo.SetAccessControl(dSecurity);*/
        }
        private void createUserDoc()
        {
            Document doc = new Document(PageSize.A4);
            Stream output = new FileStream(this.pathUser+"\\cover.pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            var logo = iTextSharp.text.Image.GetInstance(this.pathQR);
            logo.SetAbsolutePosition(130, 270);
            doc.Add(logo);
            doc.Close();
        }
        private void giveAccessFolder()
        {
            DirectoryInfo Info = new DirectoryInfo(this.pathUser);
            DirectorySecurity Security = Info.GetAccessControl();
            Security.AddAccessRule(new FileSystemAccessRule("lio", FileSystemRights.Modify, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            Security.AddAccessRule(new FileSystemAccessRule("lio", FileSystemRights.Modify, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));

            Info.SetAccessControl(Security);
        }
    }
}
