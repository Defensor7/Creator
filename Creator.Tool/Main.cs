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

            comboBoxSector.Items.AddRange(Enumerable.Range(0, 16).Select(i => (object)i).ToArray());
            comboBoxSector.SelectedIndex = 0;
            comboBoxBlock.Items.AddRange(Enumerable.Range(0, 4).Select(i => (object)i).ToArray());
            comboBoxBlock.SelectedIndex = 0;
        }

        private void ShowResult(string result)
        {
            textBoxResult.Text = result;
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
            try
            {
                var res = _device.DispenseCard();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void CaptureCard()
        {
            try
            {
                var res = _device.CaptureCard();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void CheckStatus()
        {
            try
            {
                var res = _device.CheckStatus();
                var resString = res.Select(x => x.ToString()).ToList();
                for (var i = 0; i < listViewStatusCheckingResult.Items.Count; i++)
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
                ShowResult(ex.Message);
            }
        }

        private void CheckHighStatus()
        {
            try
            {
                var res = _device.CheckHighStatus();
                var resString = res.Select(x => x.ToString()).ToList();
                for (var i = 0; i < listViewStatusHighCheckingResult.Items.Count; i++)
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
                ShowResult(ex.Message);
            }
        }

        private void SetCardPosition()
        {
            try
            {
                var position = (Crt570.CardPosition)comboBoxPositions.SelectedValue;

                var res = _device.SetCardPosition(position);
                ShowResult(res.ToString());

            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
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
                ShowResult(res.ToString());

            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
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
                ShowResult(res.ToString());

            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void Reset()
        {
            try
            {
                var res = _device.Reset();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfBeepOn()
        {
            try
            {
                var res = _device.RfBeepOn();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfBeepOff()
        {
            try
            {
                var res = _device.RfBeepOff();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfReset()
        {
            try
            {
                var res = _device.RfReset();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfSeekCard()
        {
            try
            {
                var res = _device.RfSeekCard();
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfReadCardSerial()
        {
            try
            {
                var res = _device.RfReadCardSerial();
                ShowResult(res);
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfCheckSectorPasswordA()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var password = textBoxSectorPassword.Text;
                var res = _device.RfCheckSectorPasswordA(sector, password);
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfCheckSectorPasswordB()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var password = textBoxSectorPassword.Text;
                var res = _device.RfCheckSectorPasswordB(sector, password);
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfReadBlock()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var block = (int)comboBoxBlock.SelectedItem;

                var res = _device.RfReadBlockHex(sector, block);
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfWriteBlock()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var block = (int)comboBoxBlock.SelectedItem;
                var data = textBoxBlockData.Text.Trim().ToUpper();

                var res = _device.RfWriteBlockHex(sector, block, data);
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }

        private void RfChangeSectorPassword()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var passwordA = textBoxPasswordA.Text;
                var passwordB = textBoxPasswordB.Text;

                var res = _device.RfChangeSectorPasswords(sector, passwordA, passwordB);
                ShowResult(res.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
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
                ShowResult(ex.Message);
            }

        }

        private void buttonStatusChecking_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void buttonStatusHighChecking_Click(object sender, EventArgs e)
        {
            CheckHighStatus();
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

        private void buttonMifareSeek_Click(object sender, EventArgs e)
        {
            RfSeekCard();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonBeep_Click(object sender, EventArgs e)
        {
            RfBeepOn();
        }

        private void buttonRfReset_Click(object sender, EventArgs e)
        {
            RfReset();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            RfBeepOff();
        }

        private void buttonMifareReadCardSerial_Click(object sender, EventArgs e)
        {
            RfReadCardSerial();
        }

        private void buttonCheckSectorPassword_Click(object sender, EventArgs e)
        {
            RfCheckSectorPasswordA();
        }

        private void buttonCheckSectorPasswordB_Click(object sender, EventArgs e)
        {
            RfCheckSectorPasswordB();
        }

        private void buttonReadBlock_Click(object sender, EventArgs e)
        {
            RfReadBlock();
        }

        private void buttonWriteBlock_Click(object sender, EventArgs e)
        {
            RfWriteBlock();
        }

        private void buttonChangePasswords_Click(object sender, EventArgs e)
        {
            RfChangeSectorPassword();
        }
    }
}
