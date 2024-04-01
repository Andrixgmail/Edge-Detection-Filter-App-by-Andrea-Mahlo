using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
namespace EdgeDetectionFilterApp
{
    public partial class Form1 : Form
    {
        // private const string FileName = "C:\Users\PTee\Downloads\pic.png";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var edgedetection = Cv2.ImRead(pic.png);
            var imgdetect = new Mat();
            Cv2.Canny(edgedetection, imgdetect, 50, 200); //50,200 is threshold value
            Window.ShowImages(imgdetect);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                    //imageLocation = dialog.FileName;
                    //image1.ImageLocation = imageLocation;
                    image1.Image = new Bitmap(dialog.FileName);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var temp = (Bitmap)image1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();
            /*Color c;
            for(int i=0;i<bmap.Width;i++) 
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c= bmap.GetPixel(i, j);
                    byte gray=(byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    //this is formula for greyscale and c.R means red color
                    //c.G means grean color, c.B means blue color
                    bmap.SetPixel(i,j, Color.FromArgb(gray,gray,gray));
                }
            }
            pictureBox1.Image = (Bitmap)bmap.Clone();
            */

            var edgedetection = Cv2.ImRead(textBox1.Text);
            var imgdetect = new Mat();
            Cv2.Canny(edgedetection, imgdetect, 50, 200); //50,200 is threshold value
            //Window.ShowImages(imgdetect);

            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(imgdetect);
            pictureBox1.Image = (Bitmap)bitmap.Clone();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //File.Copy(textBox1.Text, Path.Combine(@"C:\Users\PTee\source\repos\EdgeDetectionFilterApp\Filtered_Images\",Path.GetFileName(textBox1.Text)), true);
            //pictureBox1.Image.Save(@"C:\Users\PTee\source\repos\EdgeDetectionFilterApp\Filtered_Images\", ImageFormat.Png);
            //label1.Text = "Filtered Image saved Successfully";
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
                saveFileDialog.Title = "Save Image";
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    switch (extension)
                    {
                        case ".png":
                            pictureBox1.Image.Save(filePath, ImageFormat.Png);
                            break;
                        case ".bmp":
                            pictureBox1.Image.Save(filePath, ImageFormat.Bmp);
                            break;
                        case ".jpg":
                            pictureBox1.Image.Save(filePath, ImageFormat.Jpeg);
                            break;
                        default:
                            MessageBox.Show("Unsupported image format!");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No image loaded in PictureBox!");
            }
        }       
    }

}
