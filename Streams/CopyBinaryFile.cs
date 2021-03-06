﻿using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../newFile.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (reader.CanRead)
                    {
                        int byteRed = reader.Read(buffer, 0, buffer.Length);

                        if (byteRed == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            
        }
    }
}
