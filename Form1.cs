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
using MessagingToolkit.QRCode.Codec.Data;

namespace qr_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
           pictureBox1.Image = encoder.Encode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            
                
             textBox2.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox2.Image as Bitmap ));
        }
    }

     
}
