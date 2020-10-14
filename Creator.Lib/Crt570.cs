using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace Creator.Lib
{
    public class Crt570
    {
        private string _comPort;
        private SerialPort _serialPort;

        private byte _frameStart = 2;
        private byte _frameStop = 3;
        private byte _frameSend = 5;

        public Crt570(string comPort)
        {
            _comPort = comPort;
            _serialPort = new SerialPort
            {
                PortName = comPort,
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };
            _serialPort.Open();
        }

        public ResponseCode DispenseCard()
        {
            var request = PrepareRequest(CommandCode.DC.ToString());
            _serialPort.Write(request, 0, request.Length);
            //var response1 = new byte[1];
            //_serialPort.Read(response1, 0, response1.Length);
            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(1000);
            var response2 = new byte[1];
            _serialPort.Read(response2, 0, response2.Length);
            var result = (ResponseCode)response2[0];
            return result;
        }

        public ResponseCode CaptureCard()
        {
            var request = PrepareRequest(CommandCode.CP.ToString());
            _serialPort.Write(request, 0, request.Length);
            //var response1 = new byte[1];
            //_serialPort.Read(response1, 0, response1.Length);
            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(1000);
            var response2 = new byte[1];
            _serialPort.Read(response2, 0, response2.Length);
            var result = (ResponseCode)response2[0];
            return result;
        }

        public ResponseCode SetCardPosition(CardPosition position)
        {
            var request = PrepareRequest(CommandCode.FC.ToString(), ((int)position).ToString());
            _serialPort.Write(request, 0, request.Length);
            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(1000);
            var response = new byte[1];
            _serialPort.Read(response, 0, response.Length);
            var result = (ResponseCode)response[0];
            return result;
        }

        public ResponseCode SetCaptureMode(CaptureMode mode)
        {
            var request = PrepareRequest(CommandCode.IN.ToString(), ((int)mode).ToString());
            _serialPort.Write(request, 0, request.Length);
            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(1000);
            var response = new byte[1];
            _serialPort.Read(response, 0, response.Length);
            var result = (ResponseCode)response[0];
            return result;
        }

        public CaptureMode GetCaptureMode()
        {
            var request = PrepareRequest(CommandCode.SI.ToString());
            _serialPort.Write(request, 0, request.Length);
            var response1 = new byte[1];
            _serialPort.Read(response1, 0, response1.Length);

            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(3000);
            var response2 = new byte[8];
            _serialPort.Read(response2, 0, response2.Length);
            var hex = Helpers.ByteArrayToString(new byte[] {response2[3]});
            var result = (CaptureMode)Convert.ToInt16(hex);
            return result;
        }

        public ResponseCode Reset()
        {
            var request = PrepareRequest(CommandCode.RS.ToString());
            _serialPort.Write(request, 0, request.Length);
            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(1000);
            var response = new byte[1];
            _serialPort.Read(response, 0, response.Length);
            var result = (ResponseCode)response[0];
            return result;
        }

        public List<CheckStatusCode> CheckStatus()
        {
            var request = PrepareRequest(CommandCode.RF.ToString());
            _serialPort.Write(request, 0, request.Length);
            Thread.Sleep(500);
            var response = new byte[8];
            _serialPort.Read(response, 0, response.Length);

            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(500);
            var response2 = new byte[8];
            _serialPort.Read(response2, 0, response2.Length);

            var correctCode = Encoding.ASCII.GetBytes(ResponseCode.SF.ToString());
            if (response2[1] == correctCode[0] && response2[2] == correctCode[1])
            {
                var statusCodes = new byte[3];
                statusCodes[0] = (byte)(response2[3] & 0x0F);
                statusCodes[1] = (byte)(response2[4] & 0x0F);
                statusCodes[2] = (byte)(response2[5] & 0x0F);
                var bits = new BitArray(statusCodes);
                var tmpArr = new bool[12];
                tmpArr[0] = bits[3];
                tmpArr[1] = bits[2];
                tmpArr[2] = bits[1];
                tmpArr[3] = bits[0];

                tmpArr[4] = bits[11];
                tmpArr[5] = bits[10];
                tmpArr[6] = bits[9];
                tmpArr[7] = bits[8];

                tmpArr[8] = bits[19];
                tmpArr[9] = bits[18];
                tmpArr[10] = bits[17];
                tmpArr[11] = bits[16];

                var presentCodes = new List<CheckStatusCode>();

                for (var i = 0; i < Enum.GetNames(typeof(CheckStatusCode)).Length; i++)
                {
                    if (tmpArr[i])
                    {
                        presentCodes.Add((CheckStatusCode)i);
                    }
                }

                return presentCodes;
            }
            else
            {
                throw new Exception("Invalid response received");
            }
        }

        public List<HighCheckStatusCode> HighCheckStatus()
        {
            var request = PrepareRequest(CommandCode.AP.ToString());
            _serialPort.Write(request, 0, request.Length);
            Thread.Sleep(500);
            var response = new byte[8];
            _serialPort.Read(response, 0, response.Length);

            _serialPort.Write(new[] { _frameSend }, 0, 1);
            Thread.Sleep(500);
            var response2 = new byte[8];
            _serialPort.Read(response2, 0, response2.Length);

            var correctCode = Encoding.ASCII.GetBytes(ResponseCode.SF.ToString());
            if (response2[1] == correctCode[0] && response2[2] == correctCode[1])
            {
                var statusCodes = new byte[4];
                statusCodes[0] = (byte)(response2[3] & 0x0F);
                statusCodes[1] = (byte)(response2[4] & 0x0F);
                statusCodes[2] = (byte)(response2[5] & 0x0F);
                statusCodes[3] = (byte)(response2[6] & 0x0F);
                var bits = new BitArray(statusCodes);
                var tmpArr = new bool[16];
                tmpArr[0] = bits[3];
                tmpArr[1] = bits[2];
                tmpArr[2] = bits[1];
                tmpArr[3] = bits[0];

                tmpArr[4] = bits[11];
                tmpArr[5] = bits[10];
                tmpArr[6] = bits[9];
                tmpArr[7] = bits[8];

                tmpArr[8] = bits[19];
                tmpArr[9] = bits[18];
                tmpArr[10] = bits[17];
                tmpArr[11] = bits[16];

                tmpArr[12] = bits[27];
                tmpArr[13] = bits[26];
                tmpArr[14] = bits[25];
                tmpArr[15] = bits[24];

                var presentCodes = new List<HighCheckStatusCode>();

                for (var i = 0; i < Enum.GetNames(typeof(HighCheckStatusCode)).Length; i++)
                {
                    if (tmpArr[i])
                    {
                        presentCodes.Add((HighCheckStatusCode)i);
                    }
                }

                return presentCodes;
            }
            else
            {
                throw new Exception("Invalid response received");
            }
        }

        private byte[] PrepareRequest(string command, string paramHex = null)
        {
            MemoryStream requestStream = new MemoryStream();
            requestStream.Append(_frameStart);
            var payload = Encoding.ASCII.GetBytes(command);
            requestStream.Append(payload);

            if (paramHex != null)
            {
                var payload2 = Helpers.StringToByteArray(paramHex);
                requestStream.Append(payload2);
            }

            requestStream.Append(_frameStop);
            requestStream.Append(CalculateChecksum(requestStream.ToArray()));
            //var hex = Helpers.ByteArrayToString(requestStream.ToArray());

            return requestStream.ToArray();
        }

        private byte CalculateChecksum(byte[] request)
        {
            byte xor = 0;

            for (var i = 0; i < request.Length; i++)
                xor ^= request[i];


            return xor;
        }


        public enum CommandCode
        {
            DC, // Dispense Card
            CP, // Card Capture
            RF, // Status checking
            AP, // High-class status checking
            RS, // Reset,
            IN, // Card Capture Settings Set
            SI, // Card Capture Settings Get
            FC, // Dispense Card to Position
        }



        public enum ResponseCode
        {
            Positive = 06,
            Negative = 15,
            Cancle = 04,
            SF, //Status Checking Return
        }

        public enum CheckStatusCode
        {
            DispensingCard = 0,
            CapturingCard = 1,
            CardDispenseError = 2,
            CardCaptureError = 3,
            NoCaptureCard = 4,
            OverlappingCards = 5,
            JammingCard = 6,
            CardPreEmptyStatus = 7,
            CardEmptyStatus = 8,
            DispSensorStatus = 9,
            CaptureSensor2Status = 10,
            CaptureSensor1Status = 11
        }

        public enum HighCheckStatusCode
        {
           Reserved0 = 0,
           Reserved1 = 1,
           FailureAlarm = 2,
           CardBinIsFull = 3,
           CardIsDispensing = 4,
           CardIsCapturing = 5,
           CardDispenseError = 6, 
           CardCaptureError = 7,
           NoCapture = 8,
           CardOverlapped = 9,
           CardJam = 10,
           CardPreEmptyStatus = 11,
           CardEmptyStatus = 12,
           DispSensorStatus = 13,
           CaptureSensor2Status = 14,
           CaptureSensor1Status = 15
        }

        public enum CaptureMode
        {
            Prohibit = 30,
            Allow = 31,
            AllowReadWrite = 32
        }

        public enum CardPosition
        {
            First = 30,
            Second = 34,
            Third = 33,
            Fourth = 32,
            Fifth = 31,
            Sixth = 36,
            Seventh = 37
        }

        public enum RfCommands
        {
            Seek = 00023530, // Seek Card
         
        }
    }
}
