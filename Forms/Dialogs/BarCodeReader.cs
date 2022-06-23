using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace FinalProjectForm.Forms.Dialogs
{
    public partial class BarCodeReader : Form
    {
        private String SBarCode;

        public String ScanedBarCode
        {
            get { return SBarCode; }
            set { SBarCode = value; }
        }

        public BarCodeReader()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void BarCodeReader_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cboCamera.Items.Add(device.Name);
                cboCamera.SelectedIndex = 0;
            }
        }

        private void Capture_Click(object sender, EventArgs e)
        {


        }
        private void ReadBarCodeY(Bitmap bitmap)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
               
                this.Invoke((MethodInvoker)delegate
                {
                    this.ScanedBarCode = result.ToString();
                    this.Close();
                });

            }
            
        }


        private void videoCaptureDevice_newframe(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ReadBarCodeY(bitmap);
            pbox.Image = bitmap;
        }


        private void CloceCamera()
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        private void BarCodeReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloceCamera();
        }

        private void BarCodeReader_Shown(object sender, EventArgs e)
        {

        }

        private void CboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboCamera.SelectedIndex = 1;
            CloceCamera();
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += videoCaptureDevice_newframe;
            videoCaptureDevice.Start();
        }
    }
}
