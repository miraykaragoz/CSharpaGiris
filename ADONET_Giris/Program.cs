using System.Data.SqlClient;

namespace ADONET_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //databse-> Initial Catalog
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);
            //    //komutumuzu database'e iiletmeden hemen bir satır önce bağlantıyı açıyoruz.
            //    conn.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while(dr.Read())
            //    {
            //        Console.WriteLine(dr["CategoryName"]);
            //    }
            //    conn.Close();
            //int categoryID = 0;
            //Console.WriteLine("Lütfen bir kategori ID giriniz : ");
            //categoryID = int.Parse(Console.ReadLine());
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE CategoryID="+categoryID, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read()) 
            //{
            //    Console.WriteLine(dr["ProductID"].ToString() + " - " + dr["ProductName"].ToString());
            //}
            //conn.Close();

            //    string username = "";
            //    string password = "";
            //    Console.WriteLine("Kullanıcı Adınız : ");
            //    username = Console.ReadLine();
            //    Console.WriteLine("Şifreniz : ");
            //    password = Console.ReadLine();

            //    if (Login(username, password))
            //    {
            //        Console.WriteLine("Programa Hoşgeldiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı kullanıcı adı veya şifre");
            //    }
            //}
            //static bool Login(string username, string password)
            //{
            //    var conn = Db.conn();
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE Username=@username AND  Password=@password", conn);

            //    cmd.Parameters.AddWithValue("@username", username);
            //    cmd.Parameters.AddWithValue("@Password", password);



            //    conn.Open();
            //    int sonuc = (int)cmd.ExecuteScalar();
            //    conn.Close();

            //    if (sonuc == 0)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }

                string username = "";
                string password = "";
                Console.WriteLine("Kullanıcı adınızı giriniz");
                username = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz");
                password = Console.ReadLine();

                if (CheckUsername(username) && CheckPassword(password))
                {
                    Console.WriteLine("Hoşgeldiniz");
                }
                else
                {
                    if (!CheckUsername(username))
                    {
                        Console.WriteLine("Hatalı kullanıcı adı");
                    }

                    if (!CheckPassword(password))
                    {
                        Console.WriteLine("Hatalı şifre");
                    }
                }
            }

            static bool CheckUsername(string username)
            {
                SqlConnection conn = Db.conn();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Id) FROM Users WHERE Username=@username", conn);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            static bool CheckPassword(string password)
            {
                SqlConnection conn = Db.conn();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Id) FROM Users WHERE Password=@password", conn);

                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
