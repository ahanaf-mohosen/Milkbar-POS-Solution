﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace MilkbarPOS.Data
{
    public static class SecurityHelper
    {
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2")); // hex format
                return builder.ToString();
            }
        }

    }
}