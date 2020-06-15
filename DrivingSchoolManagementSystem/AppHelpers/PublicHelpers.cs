using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace DrivingSchoolManagementSystem.AppHelpers
{
    public enum AccessLevel { ADMIN, INSTRUCTOR, STUDENT, NULL }

    public static class PublicHelpers
    {
        public static string SQLServerInstance = @"TEMWATECH001";
        public static string SQLInitialCatalog = "DSMS";
        public static string SQLUserID = @"svc_dev_dsms";
        public static string SQLUserPwd = "DS3S@2k20";
        public static bool SQLIntegratedSecurity = false;



        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private const string sInitVector = "MG:ThankYouJesus";
        // This constant is used to determine the keysize of the encryption algorithm
        private const int iKeySize = 256;
        private const string sPassPhrase = "TTDevTeam";

        //Encrypt
        public static string encryptAString(string plainText)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(sInitVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(sPassPhrase, null);
            byte[] keyBytes = password.GetBytes(iKeySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }

        //Decrypt
        public static string decryptAString(string cipherText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(sInitVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(sPassPhrase, null);
            byte[] keyBytes = password.GetBytes(iKeySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }

        public static void SaveCurrentUser(string strEncyptedCredentials)
        {
            Properties.Settings.Default.RememberCurrentUser = strEncyptedCredentials;
            Properties.Settings.Default.Save();
        }

        public static byte[] GetImagePlaceholder()
        {
            byte[] data = new byte[0];

            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();

                Stream stream = asm.GetManifestResourceStream("DrivingSchoolManagementSystem.Assets.ImgPlaceholder512.png"); //this return null of course

                data = new byte[stream.Length];

                stream.Read(data, 0, (int)stream.Length);
            }
            catch { }

            return data;
        }

        public static byte[] GetImageBytesOrNull(SqlDataReader reader, string columnName)
        {
            byte[] data = new byte[0];

            try
            {
                data = (byte[])reader[columnName];
            }
            catch
            {
                data = GetImagePlaceholder();
            }

            return data;
        }

        public static byte[] GetImageBytesOrNull(DataRow row, string columnName)
        {
            byte[] data = new byte[0];

            try
            {
                data = (byte[])row[columnName];
            }
            catch
            {
                data = GetImagePlaceholder();
            }

            return data;
        }

        public static string GetStringOrNull(SqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? "" : reader[columnName].ToString().Trim();
        }

        public static string GetStringOrNull(DataRow row, string columnName)
        {
            try
            {
                return row[columnName].ToString().Trim();
            }
            catch { return string.Empty; }
        }

        public static AccessLevel GetAccessLevelOrNull(SqlDataReader reader, string columnName)
        {
            string s = reader.IsDBNull(reader.GetOrdinal(columnName)) ? "" : reader[columnName].ToString().Trim().ToUpper();

            return ReturnedAccessLevel(s);
        }

        public static AccessLevel GetAccessLevelOrNull(DataRow row, string columnName)
        {
            string s = string.Empty;

            try { s = row[columnName].ToString().Trim().ToUpper(); } catch { }

            return ReturnedAccessLevel(s);
        }

        private static AccessLevel ReturnedAccessLevel(string s)
        {
            switch (s)
            {
                case "ADMIN":
                    return AccessLevel.ADMIN;

                case "INSTRUCTOR":
                    return AccessLevel.INSTRUCTOR;

                case "STUDENT":
                    return AccessLevel.STUDENT;

                default:
                    return AccessLevel.NULL;
            }
        }

        public static DateTime GetDateTimeOrNull(SqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? DateTime.MinValue : Convert.ToDateTime(reader[columnName]);
        }

        public static DateTime GetDateTimeOrNull(DataRow row, string columnName)
        {
            try
            {
                return Convert.ToDateTime(row[columnName]);
            }
            catch { return DateTime.MinValue; }
        }

        public static int GetIntOrNull(SqlDataReader reader, string columnName)
        {

            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? 0 : Convert.ToInt32(reader[columnName]);
        }

        public static bool GetBoolOrNull(SqlDataReader reader, string columnName, bool defaultValue)
        {
            try
            {
                return reader.IsDBNull(reader.GetOrdinal(columnName)) ? false : Convert.ToBoolean(reader[columnName]);
            }
            catch { return defaultValue; }
        }

        public static bool GetBoolOrNull(DataRow row, string columnName, bool defaultVal)
        {
            try
            {
                return Convert.ToBoolean(row[columnName]);
            }
            catch { return defaultVal; }
        }

        public static string GetHexFromByte(SqlDataReader reader, string columnName)
        {
            string s = "";

            try
            {
                byte[] binaryString = (byte[])reader[columnName];

                s = "0x" + String.Concat(binaryString.Select(b => b.ToString("X2")));
            }
            catch { s = ""; }

            return s;
        }

        public static Int64 GetInt64OrNull(SqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? 0 : Convert.ToInt64(reader[columnName]);
        }

        public static double GetDoubleOrNull(SqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? 0 : Convert.ToDouble(reader[columnName]);
        }

        private static Random random = new Random();
        public static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //public static void WriteErrorLog(string ErrorText)
        //{
        //    try
        //    {
        //        using (var ms = new MemoryStream())
        //        {
        //            var dir = HttpContext.Current.Server.MapPath("/Content");
        //            var filePath = Path.Combine(dir, "ErrorLog.txt");

        //            File.AppendAllText(filePath, string.Format("{0}: {1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), ErrorText));
        //        }
        //    }
        //    catch { }
        //}

    }
}
