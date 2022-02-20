using MySql.Data.MySqlClient;

namespace MySQL
{
    class DBConnection
    {
        public MySqlConnection Connection;
        public void Connect()
        {
            Connection = new MySqlConnection("Data source = 127.0.0.1; username = root; password =; database = registro");
        }
    }
}
