using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            // define path and file name
            string fileName = @"D:\Daten\byteArray.bin";
            // define and initialize arrays
            byte[] byteArrayWrite = { 200, 201, 202, 203, 204, 205, 206, 207 };
            byte[] byteArrayZwei = { 101, 102, 103, 104, 105, 106, 107, 108 };
            byte[] byteArrayRead = new byte[byteArrayWrite.Length + byteArrayZwei.Length];
            

            try
            {
                

                using (FileStream fs = new FileStream (fileName, FileMode.Create))
                {
                    // write array to file
                    fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);
                    //read from file
                    fs.Position = 0;
                    // set start position
                    fs.Read(byteArrayRead, 0, byteArrayRead.Length);
                    // read file values
                    // output: values of byte array
                   
              
                    fs.Write(byteArrayZwei, 0, byteArrayWrite.Length);
                    fs.Position = 0;
                    fs.Read(byteArrayRead, 0, byteArrayRead.Length);

                    for (int count = 0; count < byteArrayRead.Length; count++)
                    {
                        Console.Write(byteArrayRead[count] + ", ");
                    }
                    Thread.Sleep(1000);
                }
                  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
