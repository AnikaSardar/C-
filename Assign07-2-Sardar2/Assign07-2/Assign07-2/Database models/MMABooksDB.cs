using System.Configuration;

namespace Assign07_2.Models.DataLayer
{
    public static class MMABooksDB
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
    }
}
