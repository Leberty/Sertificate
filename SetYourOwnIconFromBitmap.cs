using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Устанавливаем иконку из ресурсов
            //Конвертируем из пнг-шки
            // Create a Bitmap object from an image file.
            Bitmap myBitmap = new Bitmap(Properties.Resources.Image);

            // Get an Hicon for myBitmap.
            IntPtr Hicon = myBitmap.GetHicon();

            // Create a new icon from the handle. 
            Icon newIcon = Icon.FromHandle(Hicon);

            // Set the form Icon attribute to the new icon.
            this.Icon = newIcon;

            InitializeComponent();
        }
    }
}
