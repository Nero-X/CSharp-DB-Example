using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace BBD_lab1
{
    public sealed class MySqlDB
    {
        private MySqlDB(DataSet dataSet, string connectionString)
        {
            this.dataSet = dataSet;
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand();
            command.Connection = connection;
        }

        private static MySqlDB _instance;

        public static MySqlDB GetInstance(DataSet dataSet, string connectionString)
        {
            if (_instance == null) _instance = new MySqlDB(dataSet, connectionString);
            return _instance;
        }

        private DataSet dataSet;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool ExecuteQuery(string query, out int recordsAffected, out ArrayList result)
        {
            recordsAffected = 0;
            result = new ArrayList();
            command.CommandText = query;
            var sqlParams = new List<SqlParam>();
            switch (query.Split(new char[] { ' ' }, 2)[0].ToUpper())
            {
                case "SELECT":
                case "UPDATE":
                case "DELETE":
                    {
                        var sqlParamsRegex = new Regex(@"(\w+)?\s*([<>]|=|[<>]=)?\s*\@([\w.$]+|""[^""]+""|'[^']+')");
                        foreach(Match match in sqlParamsRegex.Matches(query))
                        {
                            sqlParams.Add(new SqlParam(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value));
                        }
                        break;
                    }
                case "INSERT":
                    {
                        var regex = new Regex(@"\([^)]+\)");
                        var matches = regex.Matches(query);
                        var fields = matches[0].Value.Trim('(', ')').Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                        var values = matches[1].Value.Trim('(', ')').Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                        var sqlParamsRegex = new Regex(@"\@([\w.$]+|""[^""]+""|'[^']+')");
                        for (int i = 0; i < fields.Length; i++)
                        {
                            if (sqlParamsRegex.IsMatch(values[i])) sqlParams.Add(new SqlParam(fields[i], "=", values[i].TrimStart('@')));
                        }
                        break;
                    }
            }
            if(sqlParams.Count > 0)
            {
                var paramsForm = new ParamsForm(dataSet, sqlParams);
                if (paramsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var pair in paramsForm.ParamValues)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                }
                else return false;
            }
            reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                result.Add(record);
            }
            recordsAffected = reader.RecordsAffected;
            reader.Close();
            command.Parameters.Clear();
            return true;
        }
    }
}
