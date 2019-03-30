using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HorseOfAnotherColor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Establishing a Sql connection
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+"C:\\Users\\marie\\source\\repos\\HorseOfAnotherColor\\HorseOfAnotherColor\\Database1.mdf"+";Integrated Security=True");
            cn.Open();
           
            //Requesting Input from the user
            string HorseName;
            Console.Write("Enter Horse Name: ");
            HorseName = Console.ReadLine();

            string Color;
            Console.Write("Enter Horse Color: ");
            Color = Console.ReadLine();

            string Gender;
            Console.Write("Enter Horse Gender: ");
            Gender = Console.ReadLine();

            //Inserting values into a table
            SqlCommand cmd = new SqlCommand("insert into HorseE values('" +HorseName + "','" +Color + "','" +Gender + "')", cn);
          
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Insertion Successful");
            }
            cn.Close();


            

        }
    }
}
