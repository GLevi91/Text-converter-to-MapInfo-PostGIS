using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace LST_Converter
{
    public sealed class PostGIS
    {
        private static readonly Lazy<PostGIS> lazy = new Lazy<PostGIS>(() => new PostGIS());

        public static PostGIS Instance
        {
            get { return lazy.Value; }
        }

        private PostGIS()
        {
            postGisConnection = new NpgsqlConnection(cnsb);
            enablePostGIS = new NpgsqlCommand(@"CREATE EXTENSION postgis", postGisConnection);
            addValues = new NpgsqlCommand();
        }

        public NpgsqlConnectionStringBuilder cnsb { get; set; } = new NpgsqlConnectionStringBuilder();
        public string tableName { get; set; }
        private NpgsqlDataReader dataReader { get; set; }
        private NpgsqlConnection postGisConnection { get; }
        private NpgsqlCommand enablePostGIS { get; }
        private NpgsqlCommand checkRows { get; set; }
        private NpgsqlCommand createTable { get; set; }
        private NpgsqlCommand addValues { get; }
        private List<string> tempCoords { get; set; } = new List<string>();
        private string coordsForQueryString { get; set; }
        public List<string> coordsForQueryList { get; private set; } = new List<string>();


        public void addCoords(string _xCoord, string _yCoord)
        {
            tempCoords.Add(_xCoord);
            tempCoords.Add(_yCoord);

            coordsForQueryString += tempCoords[0] + " " + tempCoords[1] + ",";

            tempCoords.Clear();
        }


        public void clearCoordsForQueryString()
        {
            coordsForQueryList.Add(coordsForQueryString.TrimEnd(','));
            coordsForQueryString = "";
        }


        private void addValuesMethod()
        {
            int i = 0;
            foreach (var query in coordsForQueryList)
            {
                while (i < Lists.Instance.hrszList.Count)
                {
                    addValues.CommandText = String.Format(@"INSERT INTO {0} (hrsz, geom) SELECT '{1}',ST_GeomFromText('POLYGON(({2}))',23700) WHERE NOT EXISTS (SELECT hrsz FROM {3} WHERE hrsz = '{4}')", tableName, Lists.Instance.hrszList[i].TrimEnd(), query, tableName, Lists.Instance.hrszList[i].TrimEnd());
                    addValues.Connection = postGisConnection;
                    addValues.ExecuteNonQuery();
                    break;
                }
                i++;
            }
        }


        private void enablePostGisMethod()
        {
            try
            {
                enablePostGIS.ExecuteNonQuery();
            }

            catch (PostgresException ex) when (ex.SqlState == "42710")
            {
                MessageBox.Show("PostGIS is already enabled! Press OK to continue...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                throw;
            }
        }


        private void createTableMethod()
        {
            try
            {
                createTable.ExecuteNonQuery();
            }

            catch (PostgresException ex) when (ex.SqlState == "42P07")
            {
                DialogResult result = MessageBox.Show("Table is already existing! Do you want to update the rows in the table?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    addValuesMethod();
                }

                else
                {
                    Application.Exit();
                }
            }
        }


        public void runQueries()
        {
            createTable = new NpgsqlCommand(String.Format(@"CREATE TABLE {0} (id BIGSERIAL PRIMARY KEY, hrsz VARCHAR, geom geometry(POLYGON,23700))", tableName), postGisConnection);
            
            postGisConnection.Open();
            enablePostGisMethod();
            createTableMethod();
            addValuesMethod();
            postGisConnection.Close();
        }
    }
}
