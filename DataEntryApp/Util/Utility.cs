using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryApp
{
    public static class Utility
    {
        private const string _connectionString = "data source=SANTHON-LR0D1A0;initial catalog=DataEntry;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

        /// <summary>
        /// List page header style
        /// ///
        public const string LblBackColor = "ControlLight";
        public const string LblFontColor = "Blue";
        public const string LblFontStyle = "Segoe UI";
        public const int LblFontSize = 17;


        public static string GetEntityConnectionString()
        {
            var entityBuilder = new EntityConnectionStringBuilder();
            // WARNING
            // Check app config and set the appropriate DBModel
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = _connectionString + ";MultipleActiveResultSets=True;App=EntityFramework;";
            entityBuilder.Metadata = @"res://*/Models.DataEntry.csdl|res://*/Models.DataEntry.ssdl|res://*/Models.DataEntry.msl";
            return entityBuilder.ToString();
        }
    }
}
