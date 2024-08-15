using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageProjectUI
{
    public class clsDoctor
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        
        public clsDoctor()
        {
            this.DoctorID = -1;
            this.Name = "";
            this.Password = "";
           
        }

        private clsDoctor(int DoctorID, string Name, string Password)
        {
            this.DoctorID = DoctorID;
            this.Name = Name;
            this.Password = Password;
           
            Mode = enMode.Update;


        }

        private static  bool DataFind(ref int DoctorID, string Name, string Password)
        {
            string ConnectionString = "Server=.;Database=ProjectDB;User Id=sa;Password=sa123456;";

            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Doctors WHERE Name = @Name and Password=@Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Password", Password);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                DoctorID = (int)reader["ID"];
                                Name = (string)reader["Name"];
                                Password = (string)reader["Password"];

                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }


                        }


                    }


                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static clsDoctor Find(string Name, string Password)
        {
            int DoctorID = -1;
            


            if (DataFind(ref DoctorID, Name, Password))
            {

                return new clsDoctor(DoctorID, Name,Password);



            }
            else
            {
                return null;
            }
        }
    }
}
