using Creator.Lib;
using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace Creator.Tool
{
    public partial class Main : Form
    {
        private Crt570 _device;

        public Main()
        {
            InitializeComponent();
            RefreshPorts();

            var statusCodes = Enum.GetNames(typeof(Crt570.CheckStatusCode));
            foreach (var statusCode in statusCodes)
            {
                listViewStatusCheckingResult.Items.Add(statusCode);
            }

            var statusCodesHigh = Enum.GetNames(typeof(Crt570.HighCheckStatusCode));
            foreach (var statusCode in statusCodesHigh)
            {
                listViewStatusHighCheckingResult.Items.Add(statusCode);
            }

            comboBoxPositions.DataSource = Enum.GetValues(typeof(Crt570.CardPosition));
        }

        private void buttonComRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void RefreshPorts()
        {
            comboBoxPorts.DataSource = SerialPort.GetPortNames();
        }

        private void buttonDispense_Click(object sender, EventArgs e)
        {
            DispenseCard();
        }

        private void DispenseCard()
        {
            try{
            var res = _device.DispenseCard();
            MessageBox.Show(res.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CaptureCard()
        {
            try
            {
                var res = _device.CaptureCard();
                MessageBox.Show(res.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckStatus()
        {
            try
            {
                var res = _device.CheckStatus();
                var resString = res.Select(x => x.ToString()).ToList();
                for (int i = 0; i < listViewStatusCheckingResult.Items.Count; i++)
                {
                    if (resString.Contains(listViewStatusCheckingResult.Items[i].Text))
                    {
                        listViewStatusCheckingResult.Items[i].ForeColor = Color.Red;
                    }
                    else
                    {
                        listViewStatusCheckingResult.Items[i].ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HighCheckStatus()
        {
            try
            {
                var res = _device.HighCheckStatus();
                var resString = res.Select(x => x.ToString()).ToList();
                for (int i = 0; i < listViewStatusHighCheckingResult.Items.Count; i++)
                {
                    if (resString.Contains(listViewStatusHighCheckingResult.Items[i].Text))
                    {
                        listViewStatusHighCheckingResult.Items[i].ForeColor = Color.Red;
                    }
                    else
                    {
                        listViewStatusHighCheckingResult.Items[i].ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCardPosition()
        {
            try
            {
               var position = (Crt570.CardPosition)comboBoxPositions.SelectedValue;

                var res = _device.SetCardPosition(position);
                MessageBox.Show(res.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCaptureMode()
        {
            try
            {
                Crt570.CaptureMode? mode = null;

                if (radioButtonCaptureProhibit.Checked) mode = Crt570.CaptureMode.Prohibit;
                if (radioButtonCaptureAllow.Checked) mode = Crt570.CaptureMode.Allow;
                if (radioButtonCaptureAllowReadWrite.Checked) mode = Crt570.CaptureMode.AllowReadWrite;

                if (mode == null) throw new Exception("Capture mode not selected");

                var res = _device.SetCaptureMode((Crt570.CaptureMode)mode);
                MessageBox.Show(res.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCaptureMode()
        {
            try
            {
                radioButtonCaptureProhibit.Checked = false;
                radioButtonCaptureAllow.Checked = false;
                radioButtonCaptureAllowReadWrite.Checked = false;

                var res = _device.GetCaptureMode();
                if (res == Crt570.CaptureMode.Prohibit) radioButtonCaptureProhibit.Checked = true;
                if (res == Crt570.CaptureMode.Allow) radioButtonCaptureAllow.Checked = true; 
                if (res == Crt570.CaptureMode.AllowReadWrite) radioButtonCaptureAllowReadWrite.Checked = true;
                MessageBox.Show(res.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                groupBoxCard.Enabled = true;
                _device = new Crt570(comboBoxPorts.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonStatusChecking_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void buttonStatusHighChecking_Click(object sender, EventArgs e)
        {
            HighCheckStatus();
        }

        private void buttonCaptureApply_Click(object sender, EventArgs e)
        {
            SetCaptureMode();
        }

        private void radioButtonCaptureProhibit_CheckedChanged(object sender, EventArgs e)
        {
            CaptureRadioChanged();
        }

        private void radioButtonCaptureAllow_CheckedChanged(object sender, EventArgs e)
        {
            CaptureRadioChanged();
        }

        private void radioButtonCaptureAllowReadWrite_CheckedChanged(object sender, EventArgs e)
        {
            CaptureRadioChanged();
        }

        private void CaptureRadioChanged()
        {
            if (radioButtonCaptureAllow.Checked)
            {
                radioButtonCaptureAllowReadWrite.Checked = false;
                radioButtonCaptureProhibit.Checked = false;
            }

            if (radioButtonCaptureProhibit.Checked)
            {
                radioButtonCaptureAllowReadWrite.Checked = false;
                radioButtonCaptureAllow.Checked = false;
            }

            if (radioButtonCaptureAllowReadWrite.Checked)
            {
                radioButtonCaptureProhibit.Checked = false;
                radioButtonCaptureAllow.Checked = false;
            }
        }

        private void buttonCaptureGet_Click(object sender, EventArgs e)
        {
            GetCaptureMode();
        }

        private void buttonSetPosition_Click(object sender, EventArgs e)
        {
            SetCardPosition();
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            CaptureCard();
        }
    }
}
