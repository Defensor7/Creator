using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Creator.Lib
{
    public class Crt570
    {
        private readonly SerialPort _serialPort;

        private byte _frameStart = 2;
        private byte _frameStop = 3;
        private byte _frameSend = 5;

        public Crt570(string comPort)
        {
            _serialPort = new SerialPort
            {
                PortName = comPort,
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 5000,
                WriteTimeout = 5000
            };
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }

        public void Open()
        {
            _serialPort.Open();
        }

        public ResponseCode RfBeepOn()
        {
            var response = SendRequestToReader(CommandCode.RfBeepOn, waitForData: true);
            var hex = Helpers.ByteArrayToString(new[] { response[1] }).ToUpper();
            return hex == RfResponseCode.Positive ? ResponseCode.Positive : ResponseCode.Negative;
        }

        public ResponseCode RfBeepOff()
        {
            var response = SendRequestToReader(CommandCode.RfBeepOff, waitForData: true);
            var hex = Helpers.ByteArrayToString(new[] { response[1] }).ToUpper();
            return hex == RfResponseCode.Positive ? ResponseCode.Positive : ResponseCode.Negative;
        }

        public ResponseCode RfReset()
        {
            var response = SendRequestToReader(CommandCode.RfReset);
            var hex = Helpers.ByteArrayToString(new[] { response[0] });
            var res = (ResponseCode)response[0];
            return res;
        }

        public ResponseCode RfSeekCard()
        {
            var response = SendRequestToReader(CommandCode.RfCardSeek, waitForData: true);
            var hex = Helpers.ByteArrayToString(response).ToUpper();
            return hex == RfResponseCode.Positive ? ResponseCode.Positive : ResponseCode.Negative;
        }

        public string RfReadCardSerial()
        {
            var response = SendRequestToReader(CommandCode.RfReadCardSerial, waitForData: true);
            var res = Helpers.ByteArrayToString(new[] { response[0] }).ToUpper();
            return res == RfResponseCode.Positive ? Helpers.ByteArrayToString(response).Substring(2).ToUpper() : null;
        }

        public ResponseCode RfCheckSectorPasswordA(int sector, string password)
        {
            if (password.Length != 12) throw new Exception("Password must be 12 symbol length in HEX format!");
            var param = sector.ToString("X2") + password.ToUpper();
            var response = SendRequestToReader(CommandCode.RfCheckSectorPasswordA, param, waitForData: true);
            var res = Helpers.ByteArrayToString(new[] { response[1] }).ToUpper();
            switch (res)
            {
                case RfResponseCode.Positive:
                    return ResponseCode.PasswordOk;
                case RfResponseCode.FailToSeekCard:
                    return ResponseCode.FailToSeek;
                case RfResponseCode.PasswordError:
                    return ResponseCode.PasswordError;
                default:
                    return ResponseCode.Negative;
            }
        }

        public ResponseCode RfCheckSectorPasswordB(int sector, string password)
        {
            if (password.Length != 12) throw new Exception("Password must be 12 symbol length in HEX format!");
            var param = sector.ToString("X2") + password.ToUpper();
            var response = SendRequestToReader(CommandCode.RfCheckSectorPasswordB, param, waitForData: true);
            var res = Helpers.ByteArrayToString(new[] { response[1] }).ToUpper();
            switch (res)
            {
                case RfResponseCode.Positive:
                    return ResponseCode.PasswordOk;
                case RfResponseCode.FailToSeekCard:
                    return ResponseCode.FailToSeek;
                case RfResponseCode.PasswordError:
                    return ResponseCode.PasswordError;
                default:
                    return ResponseCode.Negative;
            }
        }

        public string RfReadBlockHex(int sector, int block)
        {
            return Helpers.ByteArrayToString(RfReadBlock(sector, block)).ToUpper();
        }

        public byte[] RfReadBlock(int sector, int block)
        {
            var param = sector.ToString("X2") + block.ToString("X2");
            var response = SendRequestToReader(CommandCode.RfReadBlock, param, waitForData: true);
            string res;
            if (response.Length != 18)
            {
                res = Helpers.ByteArrayToString(new[] { response[2] }).ToUpper();
            }
            else
            {
                res = Helpers.ByteArrayToString(new[] { response[3] }).ToUpper();
            }

            if (res == RfResponseCode.ReadOk || res == RfResponseCode.Positive)
            {
                var data = new byte[16];
                for (var i = 0; i < response.Length - 3; i++)
                {
                    data[i] = response[i + 3];
                }

                return data;
            }

            switch (res)
            {
                case RfResponseCode.FailToSeekCard:
                    throw new Exception(ResponseCode.FailToSeek.ToString());
                case RfResponseCode.PasswordError:
                    throw new Exception(ResponseCode.PasswordError.ToString());
                case RfResponseCode.DataReadWriteError:
                    throw new Exception(ResponseCode.DataReadWriteError.ToString());
                case RfResponseCode.SerialNumberError:
                    throw new Exception(ResponseCode.SerialNumberError.ToString());
                case RfResponseCode.WrongSectorError:
                    throw new Exception(ResponseCode.WrongSectorError.ToString());
                default:
                    throw new Exception(ResponseCode.Negative.ToString());
            }
        }

        public ResponseCode RfWriteBlockHex(int sector, int block, string data)
        {
            var bytes = Helpers.StringToByteArray(data);
            return RfWriteBlock(sector, block, bytes);
        }

        public ResponseCode RfWriteBlock(int sector, int block, byte[] data)
        {
            var param = sector.ToString("X2") + block.ToString("X2") + Helpers.ByteArrayToString(data);
            var response = SendRequestToReader(CommandCode.RfWriteBlock, param, waitForData: true);
            var res = Helpers.ByteArrayToString(new[] { response[2] }).ToUpper();

            switch (res)
            {
                case RfResponseCode.Positive:
                    return ResponseCode.Positive;
                case RfResponseCode.DataReadWriteError:
                    return ResponseCode.DataReadWriteError;
                case RfResponseCode.FailToSeekCard:
                    return ResponseCode.FailToSeek;
                case RfResponseCode.PasswordError:
                    return ResponseCode.PasswordError;
                default:
                    return ResponseCode.Negative;
            }

        }

        public ResponseCode RfChangeSectorPasswords(int sector, string passwordA, string passwordB, string storageArea = null)
        {
            if (passwordA.Length != 12 || passwordB.Length != 12) throw new Exception("Password must be 12 symbol length in HEX format!");
            if (storageArea != null && storageArea.Length != 8) throw new Exception("Storage area must be 8 symbol length in HEX format!");
            var setStorageArea = storageArea ?? "FF078069";
            var param = sector.ToString("X2") + "03" + passwordA + setStorageArea + passwordB;
            var response = SendRequestToReader(CommandCode.RfWriteBlock, param, waitForData: true);
            var res = Helpers.ByteArrayToString(new[] { response[2] }).ToUpper();

            switch (res)
            {
                case RfResponseCode.Positive:
                    return ResponseCode.Positive;
                case RfResponseCode.DataReadWriteError:
                    return ResponseCode.DataReadWriteError;
                case RfResponseCode.FailToSeekCard:
                    return ResponseCode.FailToSeek;
                case RfResponseCode.PasswordError:
                    return ResponseCode.PasswordError;
                default:
                    return ResponseCode.Negative;
            }
        }

        private byte[] SendRequestToReader(string command, string param = null, bool waitForAck = true, bool waitForData = false)
        {
            var package = PrepareReaderRequest(command, param);
            var request = PrepareReaderSeRequest(package);
            _serialPort.Write(request, 0, request.Length);
            Thread.Sleep(750);
            var response = new byte[32];
            _serialPort.Read(response, 0, response.Length);
            var data = new byte[32];
            if (waitForAck)
            {
                data = ParseReaderSeResponse(response);
                if ((ResponseCode)data[0] != ResponseCode.Positive) throw new Exception("Received not Positive ACK");
            }

            var requestExecute = PrepareReaderSeRequest(new[] { _frameSend });
            _serialPort.Write(requestExecute, 0, requestExecute.Length);

            if (waitForData)
            {
                Thread.Sleep(750);
                var responseData = new byte[64];
                _serialPort.Read(responseData, 0, responseData.Length);
                var dataSe = ParseReaderSeResponse(responseData);
                var hex = Helpers.ByteArrayToString(dataSe);
                data = ParseReaderResponse(dataSe, command);
            }

            return data;
        }

        private byte[] SendRequestToDispenser(string command, string param = null, bool waitForAck = true, bool waitForData = false)
        {
            var request = PrepareRequest(command, param);
            _serialPort.Write(request, 0, request.Length);
            Thread.Sleep(750);
            var response = new byte[32];
            _serialPort.Read(response, 0, response.Length);
            if (waitForAck) { if ((ResponseCode)response[0] != ResponseCode.Positive) throw new Exception("Received not Positive ACK"); }
            _serialPort.Write(new[] { _frameSend }, 0, 1);

            if (waitForData)
            {
                Thread.Sleep(750);
                var data = new byte[32];
                _serialPort.Read(data, 0, data.Length);
                return data.TrimEnd();
            }

            return response.TrimEnd();
        }

        public ResponseCode DispenseCard()
        {
            var response = SendRequestToDispenser(CommandCode.DispenseCard);
            var res = (ResponseCode)response[0];
            return res;
        }

        public ResponseCode CaptureCard()
        {
            var response = SendRequestToDispenser(CommandCode.CaptureCard);
            var res = (ResponseCode)response[0];
            return res;
        }

        public ResponseCode SetCardPosition(CardPosition position)
        {
            var response = SendRequestToDispenser(CommandCode.MoveCard, ((int)position).ToString());
            var res = (ResponseCode)response[0];
            return res;
        }

        public ResponseCode SetCaptureMode(CaptureMode mode)
        {
            var response = SendRequestToDispenser(CommandCode.SetCaptureMode, ((int)mode).ToString());
            var res = (ResponseCode)response[0];
            return res;
        }

        public CaptureMode GetCaptureMode()
        {
            var response = SendRequestToDispenser(CommandCode.GetCaptureMode, waitForData: true);
            var data = ParseDispenserResponse(response);
            var hex = Helpers.ByteArrayToString(new[] { data[0] });
            var result = (CaptureMode)Convert.ToInt16(hex);
            return result;
        }

        public ResponseCode Reset()
        {
            var response = SendRequestToDispenser(CommandCode.Reset);
            var res = (ResponseCode)response[0];
            return res;
        }

        public List<CheckStatusCode> CheckStatus()
        {
            var response = SendRequestToDispenser(CommandCode.CheckStatus, waitForData: true);

            var correctCode = Helpers.StringToByteArray(CommandCode.CheckStatusResponse);
            if (response[1] == correctCode[0] && response[2] == correctCode[1])
            {
                var statusCodes = new byte[3];
                statusCodes[0] = (byte)(response[3] & 0x0F);
                statusCodes[1] = (byte)(response[4] & 0x0F);
                statusCodes[2] = (byte)(response[5] & 0x0F);
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

        public List<HighCheckStatusCode> CheckHighStatus()
        {
            var response = SendRequestToDispenser(CommandCode.CheckHighStatus, waitForData: true);

            var correctCode = Helpers.StringToByteArray(CommandCode.CheckStatusResponse);
            if (response[1] == correctCode[0] && response[2] == correctCode[1])
            {
                var statusCodes = new byte[4];
                statusCodes[0] = (byte)(response[3] & 0x0F);
                statusCodes[1] = (byte)(response[4] & 0x0F);
                statusCodes[2] = (byte)(response[5] & 0x0F);
                statusCodes[3] = (byte)(response[6] & 0x0F);
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

        private byte[] PrepareRequest(string command, string param = null)
        {
            var requestStream = new MemoryStream();
            requestStream.Append(_frameStart);

            if (command != null)
            {
                var payload = Helpers.StringToByteArray(command);
                requestStream.Append(payload);
            }

            if (param != null)
            {
                var payload = Helpers.StringToByteArray(param);
                requestStream.Append(payload);
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

        private byte[] PrepareReaderRequest(string command, string param = null)
        {
            var requestStream = new MemoryStream();
            requestStream.Append(_frameStart);

            var payload = Helpers.StringToByteArray(command + param);
            var sLength = BitConverter.GetBytes((short)payload.Length);
            requestStream.Append(sLength[1]);
            requestStream.Append(sLength[0]);
            requestStream.Append(payload);

            requestStream.Append(_frameStop);
            requestStream.Append(CalculateChecksum(requestStream.ToArray()));
            //var hex = Helpers.ByteArrayToString(requestStream.ToArray());

            return requestStream.ToArray();
        }

        private byte[] PrepareReaderSeRequest(byte[] package)
        {
            var requestStream = new MemoryStream();
            requestStream.Append(_frameStart);
            var command = Helpers.StringToByteArray(CommandCode.RfPackage);
            requestStream.Append(command);
            //var hex1 = Helpers.ByteArrayToString(requestStream.ToArray());
            var sLength = BitConverter.GetBytes((short)package.Length); //SLEN - Length of package
            requestStream.Append(sLength[1]);
            requestStream.Append(sLength[0]);
            //var hex2 = Helpers.ByteArrayToString(requestStream.ToArray());
            var rLength = BitConverter.GetBytes((short)32); //RLEN - Estimated response length
            requestStream.Append(rLength[1]);
            requestStream.Append(rLength[0]);
            //var hex5 = Helpers.ByteArrayToString(requestStream.ToArray());
            requestStream.Append(new byte[] { 10 }); // Timeout
            //var hex3 = Helpers.ByteArrayToString(requestStream.ToArray());
            requestStream.Append(package);
            //var hex4 = Helpers.ByteArrayToString(requestStream.ToArray());
            requestStream.Append(_frameStop);
            requestStream.Append(CalculateChecksum(requestStream.ToArray()));
            //var hex = Helpers.ByteArrayToString(requestStream.ToArray());

            return requestStream.ToArray();
        }

        private byte[] ParseReaderSeResponse(byte[] response)
        {
            response = response.TrimEnd();
            if (response[0] != _frameStart || response[response.Length - 2] != _frameStop) throw new Exception("Package from reader has invalid start/stop flags!");
            if (response[response.Length - 1] != CalculateChecksum(response.RemoveLastByte())) throw new Exception("Package from reader has invalid checksum!");
            var se = Helpers.StringToByteArray(CommandCode.RfPackage);
            if (response[1] != se[0] || response[2] != se[1]) throw new Exception("Package from reader has invalid command param!");
            var length = BitConverter.ToInt16(new[] { response[4], response[3] }, 0);
            var dataLength = response.Length - 7; // START + S + E + LENGTH (2 byte) + STOP + BCC
            if (length != dataLength) throw new Exception("Package from reader has invalid data length!");
            var data = new byte[dataLength];
            for (var i = 0; i < dataLength; i++)
            {
                data[i] = response[i + 5]; // START + S + E + LENGTH (2 byte)
            }

            return data;
        }

        private byte[] ParseReaderResponse(byte[] response, string command)
        {
            response = response.TrimEnd();
            if (response[0] != _frameStart || response[response.Length - 2] != _frameStop) throw new Exception("Package from reader has invalid start/stop flags!");
            if (response[response.Length - 1] != CalculateChecksum(response.RemoveLastByte())) throw new Exception("Package from reader has invalid checksum!");
            var se = Helpers.StringToByteArray(command);
            if (response[3] != se[0] || response[4] != se[1]) throw new Exception("Package from reader has invalid command param!");
            var length = BitConverter.ToInt16(new[] { response[2], response[1] }, 0);
            var dataLength = response.Length - 7; // START + LENGTH (2 byte) + STOP + BCC
            if (length - 2 != dataLength) throw new Exception("Package from reader has invalid data length!");
            var data = new byte[dataLength];
            for (var i = 0; i < dataLength; i++)
            {
                data[i] = response[i + 5]; // START + LENGTH (2 bytes) + COMMAND (2 bytes)
            }

            return data;
        }

        private byte[] ParseDispenserResponse(byte[] response)
        {
            response = response.TrimEnd();
            if (response[0] != _frameStart || response[response.Length - 2] != _frameStop) throw new Exception("Package from reader has invalid start/stop flags!");
            if (response[response.Length - 1] != CalculateChecksum(response.RemoveLastByte())) throw new Exception("Package from reader has invalid checksum!");

            var dataLength = response.Length - 5; // START + COMMAND + COMMAND +  STOP + BCC

            var data = new byte[dataLength];
            for (var i = 0; i < dataLength; i++)
            {
                data[i] = response[i + 3]; // START + COMMAND + COMMAND
            }

            return data;
        }

        public static class CommandCode
        {
            public const string DispenseCard = "4443"; // DC
            public const string CaptureCard = "4350"; // CP
            public const string CheckStatus = "5246"; // RF
            public const string CheckHighStatus = "4150"; // AP
            public const string Reset = "5253"; // RS
            public const string SetCaptureMode = "494E"; // IN
            public const string GetCaptureMode = "5349"; // SI
            public const string MoveCard = "4643"; // FC

            public const string CheckStatusResponse = "5346"; // SF - Not for sending

            public const string Execute = "05"; // ENQ
            public const string RfPackage = "5345"; // SE


            //public const string RfChangeSectorPasswords = "3535"; //
            public const string RfWriteBlock = "3534"; //
            public const string RfReadBlock = "3533"; //
            public const string RfCheckSectorPasswordA = "3532"; //
            public const string RfCheckSectorPasswordB = "3539"; //
            public const string RfReadCardSerial = "3531"; // 
            public const string RfCardSeek = "3530"; // Seek Card
            public const string RfBeepOn = "353F01"; // Beep On
            public const string RfBeepOff = "353F00"; // Beep Off
            public const string RfReset = "3030"; // Reset Reader
        }

        public enum ResponseCode
        {
            PasswordOk,
            PasswordError,
            FailToSeek,
            DataReadWriteError,
            SerialNumberError,
            WrongSectorError,
            Positive = 06,
            Negative = 15,
            Cancle = 04,
        }

        private static class RfResponseCode
        {
            public const string Positive = "59"; // Y
            public const string Negative = "4E"; // N
            public const string FailToSeekCard = "30"; // 0
            public const string WrongSectorError = "31"; // 1
            public const string SerialNumberError = "32"; // 2
            public const string PasswordError = "33"; // 3
            public const string DataReadWriteError = "34"; // 4
            public const string ReadOk = "52"; // 4

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
            FallOut = 30,
            Out = 34,
            NearOut = 33,
            Fourth = 32,
            //Fifth = 31,
            Sixth = 36,
            Reader = 37
        }
    }
}
