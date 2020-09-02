using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using static DrivingSchoolManagementSystem.AppHelpers.PublicHelpers;

namespace DrivingSchoolManagementSystem.Converters
{
    public class UserRepository
    {
        private SqlConnection con;

        private void connection()
        {
            string connectionString = SQLIntegratedSecurity
                ? string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;Trusted_Connection=True;", SQLServerInstance, SQLInitialCatalog)
                : string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Trusted_Connection=True;", SQLServerInstance, SQLInitialCatalog, SQLUserID, SQLUserPwd);

            con = new SqlConnection(connectionString);
        }


        public string errorMessage { get; set; }
        public bool hasError { get; set; }


        public ObservableCollection<AppUser> ReturnAppUsers()
        {
            hasError = false;

            connection();

            SqlCommand cmd = new SqlCommand("sp_KSSAB_ReturnAppUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ObservableCollection<AppUser> appUsers = new ObservableCollection<AppUser>();
            try
            {
                if (con.State != ConnectionState.Closed) { try { con.Close(); } catch { } }
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AppUser appUser = new AppUser()
                        {
                            ID = GetIntOrNull(reader, "ID"),
                            Username = GetStringOrNull(reader, "Username"),
                            Password = GetStringOrNull(reader, "Password"),
                            FirstName = GetStringOrNull(reader, "FirstName"),
                            LastName = GetStringOrNull(reader, "LastName"),
                            AccessLevel = GetAccessLevelOrNull(reader, "AccessLevelID")
                        };

                        appUsers.Add(appUser);
                    }
                }

            } //try
            catch (SqlException ex)
            {
                errorMessage = "ReturnAppUsers SQL error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            catch (Exception ex)
            {
                errorMessage = "ReturnAppUsers error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            finally
            {
                con.Close();
            }

            return appUsers;
        }

        public AppUser ReturnAppUser(string username)
        {
            try
            {
                WriteToFile("@ Line 11");
                hasError = false;
                WriteToFile("@ Line 12");
                connection();
                WriteToFile("@ Line 13");
                SqlCommand cmd = new SqlCommand("GetLoginUsers", con);
                WriteToFile("@ Line 14");
                cmd.CommandType = CommandType.StoredProcedure;
                WriteToFile("@ Line 15");

                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = username;
                WriteToFile("@ Line 16");


                AppUser appUser = new AppUser();
                WriteToFile("@ Line 17");
                try
                {
                    WriteToFile("@ Line 18");
                    if (con.State != ConnectionState.Closed) { try { con.Close(); } catch { } }
                    con.Open();
                    WriteToFile("@ Line 19");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        WriteToFile("@ Line 20");
                        while (reader.Read())
                        {
                            appUser = new AppUser()
                            {
                                ID = GetIntOrNull(reader, "ID"),
                                Username = GetStringOrNull(reader, "Username"),
                                Password = GetStringOrNull(reader, "Password"),
                                FirstName = GetStringOrNull(reader, "FirstName"),
                                LastName = GetStringOrNull(reader, "LastName"),
                                AccessLevel = GetAccessLevelOrNull(reader, "AccessLevelID")
                            };

                            break;
                        }
                        WriteToFile("@ Line 21");
                    }

                } //try
                catch (SqlException ex)
                {
                    WriteToFile("@ Line 22");
                    errorMessage = "ReturnAppUsers SQL error, " + ex.Message;
                    WriteToFile("@ Line 23");
                    hasError = true; WriteToFile(errorMessage);
                    WriteToFile("@ Line 24");
                }
                catch (Exception ex)
                {
                    WriteToFile("@ Line 25");
                    errorMessage = "ReturnAppUsers error, " + ex.Message;
                    WriteToFile("@ Line 26");
                    hasError = true; WriteToFile(errorMessage);
                    WriteToFile("@ Line 27");
                }
                finally
                {
                    WriteToFile("@ Line 28");
                    con.Close();
                    WriteToFile("@ Line 29");
                }

                WriteToFile("@ Line 30");
                return appUser;
            }
            catch (Exception ex) { WriteToFile("@ Line 31"); WriteToFile(string.Format("cmdLogin_Click   {0}", ex.Message)); WriteToFile("@ Line 32"); }

            WriteToFile("@ Line 33");
            return new AppUser();
        }

        public void SaveAppUser(AppUser appUser)
        {
            hasError = false;

            connection();

            SqlCommand cmd = new SqlCommand("sp_KSSAB_SaveAppUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15);
            cmd.Parameters["@Username"].Value = appUser.Username;

            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 250);
            cmd.Parameters["@Password"].Value = appUser.Password;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
            cmd.Parameters["@FirstName"].Value = appUser.FirstName;

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
            cmd.Parameters["@LastName"].Value = appUser.LastName;

            cmd.Parameters.Add("@AccessLevelID", SqlDbType.VarChar, 50);
            cmd.Parameters["@AccessLevelID"].Value = appUser.AccessLevel;

            try
            {
                if (con.State != ConnectionState.Closed) { try { con.Close(); } catch { } }
                con.Open();

                cmd.ExecuteNonQuery();

            } //try
            catch (SqlException ex)
            {
                errorMessage = "SaveAppUser SQL error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            catch (Exception ex)
            {
                errorMessage = "SaveAppUser error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteAppUser(string pUsername)
        {
            hasError = false;

            connection();

            SqlCommand cmd = new SqlCommand("sp_KSSAB_DeleteAppUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pUsername", SqlDbType.VarChar, 15);
            cmd.Parameters["@pUsername"].Value = pUsername;

            try
            {
                if (con.State != ConnectionState.Closed) { try { con.Close(); } catch { } }
                con.Open();

                cmd.ExecuteNonQuery();

            } //try
            catch (SqlException ex)
            {
                errorMessage = "DeleteAppUser SQL error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            catch (Exception ex)
            {
                errorMessage = "DeleteAppUser error, " + ex.Message;
                hasError = true; WriteToFile(errorMessage);
            }
            finally
            {
                con.Close();
            }
        }

        public void WriteToFile(string messageToWrite)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\CanteenAdminLog_" + DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";

                if (!File.Exists(filepath))
                {
                    // Create a file to write to. 
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(messageToWrite);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(messageToWrite);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
