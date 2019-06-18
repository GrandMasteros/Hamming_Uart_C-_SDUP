/*
 * Created by SharpDevelop.
 * User: Wiktor
 * Date: 30.05.2019
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UX_mPMA_ParamGen
{
	/// <summary>
	/// Description of Hamming.
	/// </summary>
	/// 
	public partial class Hamming : UserControl
	{
		const int Bytes2ValueMax = 100;
		const int Bytes2Value10 = 10;
		public const bool t = true;
        public const bool f = false;
        public const int startWith = 2;
		Logger logger;
		SerialPort serialPort;
		public Hamming()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string convert2BYTESvalue(string stringValue)
		{
			try
			{	
			int value =  Int32.Parse(stringValue);
			if( (Bytes2Value10 <= value) && (value < Bytes2ValueMax))
			{
				return value.ToString();
			}
			else if((value >= 0) && (value < Bytes2Value10))
			{
				return ("0" + value.ToString());
			}
			logger.Log("Length Value not correct!");
			return "00";
			}
			catch (Exception)
			{
				logger.Log("Length Value not correct!");
				return "00";
        	}
		}
		
        static bool[] Encode(bool[] code, int length)
        {
            var encoded = new bool[length];

            int i = startWith, j = 0;
            while (i < length)
            {
                if (i == 3 || i == 7) i++;
                encoded[i] = code[j];

                i++;
                j++;
            }

            encoded[0] = Helpers.doXoringForPosition(encoded, length, 1);
            encoded[1] = Helpers.doXoringForPosition(encoded, length, 2);
            encoded[3] = Helpers.doXoringForPosition(encoded, length, 4);
            if (length > 7)
                encoded[7] = Helpers.doXoringForPosition(encoded, length, 8);

            return encoded;
        }

        static bool[] Decode(bool[] encoded,int length)
        {
            var decoded = new bool[11];

            int i = startWith, j = 0;
            while (i < length)
            {
                if (i == 3 || i == 7) i++;
                decoded[j] = encoded[i];

                i++;
                j++;
            }

            return decoded;
        }

        static int ErrorSyndrome(bool[] encoded,int length)
        {
            int syndrome =
                (Convert.ToInt32(Helpers.doXoringForPosition(encoded, length, 1) ^ encoded[0])) +
                (Convert.ToInt32(Helpers.doXoringForPosition(encoded, length, 2) ^ encoded[1]) << 1) +
                (Convert.ToInt32(Helpers.doXoringForPosition(encoded, length, 4) ^ encoded[3]) << 2);
            if (length > 7) syndrome +=
               (Convert.ToInt32(Helpers.doXoringForPosition(encoded, length, 8) ^ encoded[7]) << 3);

            return syndrome;
        }

        static void MixinSingleError(bool[] encoded, int pos)
        {
            encoded[pos - 1] = !encoded[pos - 1];
        }
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		public void SetLogReference(Logger arg)
	    {
	    	logger = arg;
	    }
		
		public void SetSerialPortReference(SerialPort arg)
		{
			serialPort = arg;
		}
		
		void SendButtonCoderClick(object sender, EventArgs e)
		{
			string Data_TO_PRINT;
			serialPort.Write("1" + convert2BYTESvalue(textBoxCoderLength.Text) + textCoder.Text + '\n');
			logger.Log("Data: " + "1" + convert2BYTESvalue(textBoxCoderLength.Text) + textCoder.Text);
			Data_TO_PRINT=serialPort.ReadExisting();
			logger.Log("Read data: "+ Data_TO_PRINT);
		}
		
		
		void SendButtonDecoderClick(object sender, EventArgs e)
		{
			string Data_TO_PRINT;
			serialPort.Write("0" + convert2BYTESvalue(textBoxDecoderLength.Text) + textDecoder.Text + '\n');
			logger.Log("Data: " + "0" + convert2BYTESvalue(textBoxDecoderLength.Text) + textDecoder.Text);
	        Data_TO_PRINT=serialPort.ReadExisting();  
			logger.Log("Read data: "+ Data_TO_PRINT);
		}
	}
	    public class Helpers
    {

        public static String boolArrayToPrettyString(bool[] arr)
        {
            return String.Join("", arr.Select(x => Convert.ToInt32(x)));
        }

        public static bool[] prettyStringToBoolArray(String s)
        {
            return s.ToArray().Select(x => ((Convert.ToInt32(x) - 48) > 0)).ToArray();
        }

        public static bool notPowerOf2(int x)
        {
            return !(x == 1 || x == 2 || x == 4 || x == 8);
        }

        public static int[] getPositionsForXoring(int length, int currentHammingPosition)
        {
            var positions = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                if ((i & currentHammingPosition) > 0 && notPowerOf2(i))
                    positions.Add(i);

            }
            return positions.ToArray();
        }

        public static bool doXoringForPosition(bool[] vector, int length, int currentHammingPosition)
        {
            return getPositionsForXoring(length, currentHammingPosition)
                .Select(x => vector[x - 1])
                .Aggregate((x, y) => x ^ y);
        }
    }
	    
}

