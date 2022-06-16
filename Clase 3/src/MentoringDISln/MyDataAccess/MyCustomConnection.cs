namespace MyDataAccess
{
    public class MyCustomConnection
    {
        private string _connectionString { get; set; }

        public MyCustomConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        //public string ConnectionString => _connectionString;
    }
}