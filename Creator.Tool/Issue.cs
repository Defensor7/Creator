using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Creator.Lib;

namespace Creator.Tool
{
    public partial class Issue : Form
    {
        private Crt570 _device;
        public Issue()
        {
            InitializeComponent();
            RefreshPorts();
            comboBoxSector.Items.AddRange(Enumerable.Range(0, 16).Select(i => (object)i).ToArray());
            comboBoxSector.SelectedIndex = 0;
            comboBoxBlock.Items.AddRange(Enumerable.Range(0, 4).Select(i => (object)i).ToArray());
            comboBoxBlock.SelectedIndex = 0;
        }

        private void RefreshPorts()
        {
            comboBoxPorts.DataSource = SerialPort.GetPortNames();
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _device = new Crt570(comboBoxPorts.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }

        }
        private void ShowResult(string result)
        {
            textBoxResult.Text += result;
        }

        private void buttonUniqueGenerate_Click(object sender, EventArgs e)
        {
            GenerateUniqueCard();
        }

        private void GenerateUniqueCard()
        {
            try
            {
                var sector = (int)comboBoxSector.SelectedItem;
                var block = (int)comboBoxBlock.SelectedItem;
                var passwordA = textBoxPasswordA.Text;
                var passwordB = textBoxPasswordB.Text;

                for (var i = 0; i < numericUpDownCardCount.Value; i++)
                {
                    var uid = Guid.NewGuid().ToString("N");
                    var barcode = new Random().Next(111111111, 999999999);

                    var checkResult = _device.CheckStatus();
                    if (checkResult.Count > 0)
                    {
                        string errors = String.Empty;
                        foreach (var error in checkResult)
                        {
                            errors += error.ToString()+'\n';
                        }
                        throw new Exception($"Dispenser error found:\n{errors}");
                    }

                    if (_device.SetCardPosition(Crt570.CardPosition.Reader) != Crt570.ResponseCode.Positive) throw new Exception($"Can't move card to reader position");
                    Thread.Sleep(100);
                    if (_device.RfSeekCard() != Crt570.ResponseCode.Positive) throw new Exception($"Can't seek card");
                    Thread.Sleep(100);
                    if (_device.RfReadCardSerial() == null) throw new Exception($"Can't read card serial");
                    Thread.Sleep(100);
                    if (_device.RfCheckSectorPasswordA(sector, "FFFFFFFFFFFF") != Crt570.ResponseCode.PasswordOk) throw new Exception($"Can't check password A");
                    Thread.Sleep(100);
                    if (_device.RfSeekCard() != Crt570.ResponseCode.Positive) throw new Exception($"Can't seek card");
                    Thread.Sleep(100);
                    if (_device.RfCheckSectorPasswordB(sector, "FFFFFFFFFFFF") != Crt570.ResponseCode.PasswordOk) throw new Exception($"Can't check password B");
                    Thread.Sleep(100);
                    if (_device.RfWriteBlockHex(sector, block, uid) != Crt570.ResponseCode.Positive) throw new Exception($"Can't write data to block");
                    Thread.Sleep(100);
                    if (_device.SetCardPosition(Crt570.CardPosition.FallOut) != Crt570.ResponseCode.Positive) throw new Exception($"Can't move card to reader position");
                    Thread.Sleep(1000);
                    ShowResult($"{i};{uid};{barcode}\n");

                }
            }
            catch (Exception ex)
            {
                ShowResult(ex.Message);
            }
        }
    }
}
