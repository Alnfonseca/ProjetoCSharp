using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProjetoLojaABC
{
    public partial class frmWebCan : Form
    {
        private bool DeviceExist = false; // verifica se tem algum dispositivo de imagem 
        private FilterInfoCollection videoDevices; // verifica o tipo da imagem para poder verificar
        private VideoCaptureDevice videoSource = null; // captura a imagem
        public frmWebCan()
        {
            InitializeComponent();
        }
        private void video_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturaImagem.Image = img;
        }

        private void frmWebCan_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();
                DeviceExist = true;
                foreach(FilterInfo device in videoDevices)
                {
                    cbbDispositivo.Items.Add(device.Name);
                   
                }
                cbbDispositivo.SelectedIndex = 0;
            }
            catch(ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivo.Items.Add("Nenhum Dispositivo Encontrado!!");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if(btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivo.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //encerra o sinal da camera
                    if(!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum Dispositivo Encontrado!!");
                }

            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //encerra o sinal da camera
                    // Note que esse bloco de codigo se repetiu, você pode criar um metodo para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            //salva a imagem 
                            sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*.jpeg;*.jfif;|*.jpg;*.jpeg;*.jpeg;*.jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if(res == DialogResult.OK)
                            {
                                pctCapturaImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("c:\\Imagens\\");
            BuscarIMG.FileName = "Imagens";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctCapturaImagem.ImageLocation = (BuscarIMG.FileName);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCapturaImagem.Image = null;
        }
    }
}
