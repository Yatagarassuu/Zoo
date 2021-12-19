using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Func
    {

        MySqlConnection connection = new MySqlConnection("server=dalekslu.beget.tech;user=dalekslu_zoo;password=Lbvflbvf007.;database=dalekslu_zoo");


        public ArrayList Pets()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Pets", connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            connection.Close();
            return list;
        }

        public ArrayList Workers()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Workers", connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            connection.Close();
            return list;
        }


        public bool Add_to_Pets(string Name, string Age, string Sex)
        {
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO Pets(Name, Age, Sex) VALUES (@Name, @Age, @Sex)", connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Sex", Sex);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }

        public bool Add_to_Workers(string Name_worker, string Surname_worker, string Age_worker, string Telephone_number)
        {
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO Workers(Name, Surname, Age, Number) VALUES (@Name, @Surname, @Age, @Number)", connection);
            command.Parameters.AddWithValue("@Name", Name_worker);
            command.Parameters.AddWithValue("@Surname", Surname_worker);
            command.Parameters.AddWithValue("@Age", Age_worker);
            command.Parameters.AddWithValue("@Number", Telephone_number);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }




    }
}
