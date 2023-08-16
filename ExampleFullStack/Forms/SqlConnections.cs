using System.Data.SqlClient;

namespace ExampleFullStack
{
    internal class SqlConnections
    {
        public static implicit operator SqlConnections(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}