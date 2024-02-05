using System.Data.SQLite;
using Weapons;
using static GenericEnums.GenericEnums;

namespace PlayerCharacters
{

    public class CharacterClassDetails
    {
        public string CharacterClassConnectionString = "Data Source=characterclass.db;Version=3";
        // Cleric Stuff
        public Dictionary<int, Dictionary<SavingThrowCategories, int>> clericSavingThrows { get; set; }
        private string clericSavingThrowTable = "ClericSavingThrowTable";
        public Dictionary<int, Dictionary<int, int>> clericAttackMatrix { get; set; }
        private string clericAttackMatrixTable = "ClericAttackMatrixTable";

        // Fighter Stuff
        public Dictionary<int, Dictionary<SavingThrowCategories, int>> fighterSavingThrows { get; set; }
        private string fighterSavingThrowTable = "FighterSavingThrowTable";
        public Dictionary<int, Dictionary<int, int>> fighterAttackMatrix { get; set; }
        private string fighterAttackMatrixTable = "FighterAttackMatrixTable";

        // Thief Stuff
        public Dictionary<int, Dictionary<SavingThrowCategories, int>> thiefSavingThrows { get; set; }
        private string thiefSavingThrowTable = "ThiefSavingThrowTable";
        public Dictionary<int, Dictionary<int, int>> thiefAttackMatrix { get; set; }
        private string thiefAttackMatrixTable = "ThiefAttackMatrixTable";

        // Magic User Stuff
        public Dictionary<int, Dictionary<SavingThrowCategories, int>> magicUserSavingThrows { get; set; }
        private string magicUserSavingThrowTable = "MagicUserSavingThrowTable";
        public Dictionary<int, Dictionary<int, int>> magicUserAttackMatrix { get; set; }
        private string magicUserAttackMatrixTable = "MagicUserAttackMatrixTable";

        private string savingThrowTableLayoutQuery = @"(
                    Id INTEGER PRIMARY KEY,
                    PPDM INTEGER,
                    RSW INTEGER,
                    PHHP INTEGER,
                    BW INTEGER,
                    Apology INTEGER,
                    Spells INTEGER
                )";

        private string attackMatrixTableLayoutQuery = @"(
                    Level INTEGER PRIMARY KEY,
                    AC15 INTEGER, AC14 INTEGER, AC13 INTEGER, AC12 INTEGER, 
                    AC11 INTEGER, AC10 INTEGER, AC09 INTEGER, AC08 INTEGER, 
                    AC07 INTEGER, AC06 INTEGER, AC05 INTEGER, AC04 INTEGER,
                    AC03 INTEGER, AC02 INTEGER, AC01 INTEGER, AC00 INTEGER,
                    AC_1 INTEGER, AC_2 INTEGER, AC_3 INTEGER, AC_4 INTEGER,
                    AC_5 INTEGER, AC_6 INTEGER, AC_7 INTEGER, AC_8 INTEGER,
                    AC_9 INTEGER, AC_10 INTEGER, AC_11 INTEGER, AC_12 INTEGER,
                    AC_13 INTEGER, AC_14 INTEGER, AC_15 INTEGER, AC_16 INTEGER,
                    AC_17 INTEGER, AC_18 INTEGER, AC_19 INTEGER, AC_20 INTEGER
                )";

        public CharacterClassDetails()
        {
            clericSavingThrows = new Dictionary<int, Dictionary<SavingThrowCategories, int>>();
            clericAttackMatrix = new Dictionary<int, Dictionary<int, int>>();

            fighterSavingThrows = new Dictionary<int, Dictionary<SavingThrowCategories, int>>();
            fighterAttackMatrix = new Dictionary<int, Dictionary<int, int>>();

            thiefSavingThrows = new Dictionary<int, Dictionary<SavingThrowCategories, int>>();
            thiefAttackMatrix = new Dictionary<int, Dictionary<int, int>>();

            magicUserSavingThrows = new Dictionary<int, Dictionary<SavingThrowCategories, int>>();
            magicUserAttackMatrix = new Dictionary<int, Dictionary<int, int>>();

            MakeTables();
            RetrieveData();

            RetrieveAllAttackMatrices();
            RetrieveAllSavingThrowMatrices();
        }

        private void RetrieveData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CharacterClassConnectionString))
            {
                connection.Open();

                TableQuery(connection, clericSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, thiefSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, fighterSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, magicUserSavingThrowTable, savingThrowTableLayoutQuery);

                TableQuery(connection, clericAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, thiefAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, fighterAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, magicUserAttackMatrixTable, attackMatrixTableLayoutQuery);

                connection.Close();
            }
        }


        private void RetrieveAllSavingThrowMatrices()
        {
            RetrieveSavingThrowMatrix(CharacterArchtypes.Cleric);
            RetrieveSavingThrowMatrix(CharacterArchtypes.Thief);
            RetrieveSavingThrowMatrix(CharacterArchtypes.Fighter);
            RetrieveSavingThrowMatrix(CharacterArchtypes.MagicUser);
        }

        private void RetrieveSavingThrowMatrix(CharacterArchtypes archtype)
        {
            string readDataQuery = "SELECT * FROM ";

            if (CharacterArchtypes.Cleric == archtype)
            {
                readDataQuery += clericSavingThrowTable + ";";
            }
            else if (CharacterArchtypes.Fighter == archtype)
            {
                readDataQuery += fighterSavingThrowTable + ";";
            }
            else if (CharacterArchtypes.MagicUser == archtype)
            {
                readDataQuery += magicUserSavingThrowTable + ";";
            }
            if (CharacterArchtypes.Thief == archtype)
            {
                readDataQuery += thiefSavingThrowTable + ";";
            }

            using (SQLiteConnection connection = new SQLiteConnection(CharacterClassConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(readDataQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<SavingThrowCategories, int> oneLevelMatrix = new Dictionary<SavingThrowCategories, int>();

                            int level = Convert.ToInt32(reader["Id"]);
                            oneLevelMatrix[SavingThrowCategories.ParalyzationPoisonDeathMagic] = Convert.ToInt32(reader["PPDM"]);
                            oneLevelMatrix[SavingThrowCategories.RodStaffWand] = Convert.ToInt32(reader["RSW"]);
                            oneLevelMatrix[SavingThrowCategories.PetrificationHackFrenzyHackLustPolymorph] = Convert.ToInt32(reader["PHHP"]);
                            oneLevelMatrix[SavingThrowCategories.BreathWeapon] = Convert.ToInt32(reader["BW"]);
                            oneLevelMatrix[SavingThrowCategories.Apology] = Convert.ToInt32(reader["Apology"]);
                            oneLevelMatrix[SavingThrowCategories.Spells] = Convert.ToInt32(reader["Spells"]);

                            if (CharacterArchtypes.Cleric == archtype)
                            {
                                clericSavingThrows[level] = oneLevelMatrix;
                            }
                            else if (CharacterArchtypes.Fighter == archtype)
                            {
                                fighterSavingThrows[level] = oneLevelMatrix;
                            }
                            else if (CharacterArchtypes.MagicUser == archtype)
                            {
                                magicUserSavingThrows[level] = oneLevelMatrix;
                            }
                            if (CharacterArchtypes.Thief == archtype)
                            {
                                thiefSavingThrows[level] = oneLevelMatrix;
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void RetrieveAllAttackMatrices()
        {
            RetrieveAttackMatrix(CharacterArchtypes.Cleric);
            RetrieveAttackMatrix(CharacterArchtypes.Thief);
            RetrieveAttackMatrix(CharacterArchtypes.Fighter);
            RetrieveAttackMatrix(CharacterArchtypes.MagicUser);
        }

        private void RetrieveAttackMatrix(CharacterArchtypes archtype)
        {
            string readDataQuery = "SELECT * FROM ";

            if (CharacterArchtypes.Cleric == archtype)
            {
                readDataQuery += clericAttackMatrixTable + ";";
            }
            else if (CharacterArchtypes.Fighter == archtype)
            {
                readDataQuery += fighterAttackMatrixTable + ";";
            }
            else if (CharacterArchtypes.MagicUser == archtype)
            {
                readDataQuery += magicUserAttackMatrixTable + ";";
            }
            if (CharacterArchtypes.Thief == archtype)
            {
                readDataQuery += thiefAttackMatrixTable + ";";
            }

            using (SQLiteConnection connection = new SQLiteConnection(CharacterClassConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(readDataQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<int, int> oneLevelMatrix = new Dictionary<int, int>();

                            int level = Convert.ToInt32(reader["Level"]);
                            oneLevelMatrix[15] = Convert.ToInt32(reader["AC15"]);
                            oneLevelMatrix[14] = Convert.ToInt32(reader["AC14"]);
                            oneLevelMatrix[13] = Convert.ToInt32(reader["AC13"]);
                            oneLevelMatrix[12] = Convert.ToInt32(reader["AC12"]);
                            oneLevelMatrix[11] = Convert.ToInt32(reader["AC11"]);
                            oneLevelMatrix[10] = Convert.ToInt32(reader["AC10"]);
                            oneLevelMatrix[9] = Convert.ToInt32(reader["AC09"]);
                            oneLevelMatrix[8] = Convert.ToInt32(reader["AC08"]);
                            oneLevelMatrix[7] = Convert.ToInt32(reader["AC07"]);
                            oneLevelMatrix[6] = Convert.ToInt32(reader["AC06"]);
                            oneLevelMatrix[5] = Convert.ToInt32(reader["AC05"]);
                            oneLevelMatrix[4] = Convert.ToInt32(reader["AC04"]);
                            oneLevelMatrix[3] = Convert.ToInt32(reader["AC03"]);
                            oneLevelMatrix[2] = Convert.ToInt32(reader["AC02"]);
                            oneLevelMatrix[1] = Convert.ToInt32(reader["AC01"]);
                            oneLevelMatrix[0] = Convert.ToInt32(reader["AC00"]);
                            oneLevelMatrix[-1] = Convert.ToInt32(reader["AC_1"]);
                            oneLevelMatrix[-2] = Convert.ToInt32(reader["AC_2"]);
                            oneLevelMatrix[-3] = Convert.ToInt32(reader["AC_3"]);
                            oneLevelMatrix[-4] = Convert.ToInt32(reader["AC_4"]);
                            oneLevelMatrix[-5] = Convert.ToInt32(reader["AC_5"]);
                            oneLevelMatrix[-6] = Convert.ToInt32(reader["AC_6"]);
                            oneLevelMatrix[-7] = Convert.ToInt32(reader["AC_7"]);
                            oneLevelMatrix[-8] = Convert.ToInt32(reader["AC_8"]);
                            oneLevelMatrix[-9] = Convert.ToInt32(reader["AC_9"]);
                            oneLevelMatrix[-10] = Convert.ToInt32(reader["AC_10"]);
                            oneLevelMatrix[-11] = Convert.ToInt32(reader["AC_11"]);
                            oneLevelMatrix[-12] = Convert.ToInt32(reader["AC_12"]);
                            oneLevelMatrix[-13] = Convert.ToInt32(reader["AC_13"]);
                            oneLevelMatrix[-14] = Convert.ToInt32(reader["AC_14"]);
                            oneLevelMatrix[-15] = Convert.ToInt32(reader["AC_15"]);
                            oneLevelMatrix[-16] = Convert.ToInt32(reader["AC_16"]);
                            oneLevelMatrix[-17] = Convert.ToInt32(reader["AC_17"]);
                            oneLevelMatrix[-18] = Convert.ToInt32(reader["AC_18"]);
                            oneLevelMatrix[-19] = Convert.ToInt32(reader["AC_19"]);
                            oneLevelMatrix[-20] = Convert.ToInt32(reader["AC_20"]);

                            if (CharacterArchtypes.Cleric == archtype)
                            {
                                clericAttackMatrix[level] = oneLevelMatrix;
                            }
                            else if (CharacterArchtypes.Fighter == archtype)
                            {
                                fighterAttackMatrix[level] = oneLevelMatrix;
                            }
                            else if (CharacterArchtypes.MagicUser == archtype)
                            {
                                magicUserAttackMatrix[level] = oneLevelMatrix;
                            }
                            if (CharacterArchtypes.Thief == archtype)
                            {
                                thiefAttackMatrix[level] = oneLevelMatrix;
                            }
                        }
                    }
                }
                connection.Close();
            }
        }


        // ----------------------------------------------------------------------------------
        // Backup methods
        public void MakeTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CharacterClassConnectionString))
            {
                connection.Open();

                TableQuery(connection, clericSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, thiefSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, fighterSavingThrowTable, savingThrowTableLayoutQuery);
                TableQuery(connection, magicUserSavingThrowTable, savingThrowTableLayoutQuery);

                TableQuery(connection, clericAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, thiefAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, fighterAttackMatrixTable, attackMatrixTableLayoutQuery);
                TableQuery(connection, magicUserAttackMatrixTable, attackMatrixTableLayoutQuery);

                connection.Close();
            }
        }

        public void TableQuery(SQLiteConnection connection, string tableName, string tableBody)
        {
            string createTableQuery = $@"CREATE TABLE IF NOT EXISTS ";
            string tableQuery = createTableQuery + tableName + tableBody + ";";

            using (SQLiteCommand command = new SQLiteCommand(tableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void InsertTable(CharacterArchtypes type)
        {

            string insertString = $@"INSERT INTO ";
            string insertQuery = $@" (Level,
                                    AC15, AC14, AC13, AC12, 
                                    AC11, AC10, AC09, AC08, 
                                    AC07, AC06, AC05, AC04,
                                    AC03, AC02, AC01, AC00,
                                    AC_1, AC_2, AC_3, AC_4,
                                    AC_5, AC_6, AC_7, AC_8,
                                    AC_9, AC_10, AC_11, AC_12,
                                    AC_13, AC_14, AC_15, AC_16,
                                    AC_17, AC_18, AC_19, AC_20) 
                                    VALUES 
                                    (@Level,
                                    @AC15, @AC14, @AC13, @AC12, 
                                    @AC11, @AC10, @AC09, @AC08, 
                                    @AC07, @AC06, @AC05, @AC04,
                                    @AC03, @AC02, @AC01, @AC00,
                                    @AC_1, @AC_2, @AC_3, @AC_4,
                                    @AC_5, @AC_6, @AC_7, @AC_8,
                                    @AC_9, @AC_10, @AC_11, @AC_12,
                                    @AC_13, @AC_14, @AC_15, @AC_16,
                                    @AC_17, @AC_18, @AC_19, @AC_20); 
                                    SELECT last_insert_rowid();";


            using (SQLiteConnection connection = new SQLiteConnection(CharacterClassConnectionString))
            {
                connection.Open();

                string dataQuery = insertString;

                Dictionary<int, Dictionary<int, int>> payload = new Dictionary<int, Dictionary<int, int>>();
                if (CharacterArchtypes.Cleric == type)
                {
                    dataQuery += clericAttackMatrixTable;
                    payload = clericAttackMatrix;
                }
                else if (CharacterArchtypes.Fighter == type)
                {
                    dataQuery += fighterAttackMatrixTable;
                    payload = fighterAttackMatrix;
                }
                else if (CharacterArchtypes.MagicUser == type)
                {
                    dataQuery += magicUserAttackMatrixTable;
                    payload = magicUserAttackMatrix;
                }
                else
                {
                    dataQuery += thiefAttackMatrixTable;
                    payload = thiefAttackMatrix;
                }
                dataQuery += insertQuery;

                foreach (KeyValuePair<int, Dictionary<int, int>> level in payload)
                {

                    using (SQLiteCommand command = new SQLiteCommand(dataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Level", level.Key);
                        command.Parameters.AddWithValue("@AC15", level.Value[0]);
                        command.Parameters.AddWithValue("@AC14", level.Value[1]);
                        command.Parameters.AddWithValue("@AC13", level.Value[2]);
                        command.Parameters.AddWithValue("@AC12", level.Value[3]);
                        command.Parameters.AddWithValue("@AC11", level.Value[4]);
                        command.Parameters.AddWithValue("@AC10", level.Value[5]);
                        command.Parameters.AddWithValue("@AC09", level.Value[6]);
                        command.Parameters.AddWithValue("@AC08", level.Value[7]);
                        command.Parameters.AddWithValue("@AC07", level.Value[8]);
                        command.Parameters.AddWithValue("@AC06", level.Value[9]);
                        command.Parameters.AddWithValue("@AC05", level.Value[10]);
                        command.Parameters.AddWithValue("@AC04", level.Value[11]);
                        command.Parameters.AddWithValue("@AC03", level.Value[12]);
                        command.Parameters.AddWithValue("@AC02", level.Value[13]);
                        command.Parameters.AddWithValue("@AC01", level.Value[14]);
                        command.Parameters.AddWithValue("@AC00", level.Value[15]);
                        command.Parameters.AddWithValue("@AC_1", level.Value[16]);
                        command.Parameters.AddWithValue("@AC_2", level.Value[17]);
                        command.Parameters.AddWithValue("@AC_3", level.Value[18]);
                        command.Parameters.AddWithValue("@AC_4", level.Value[19]);
                        command.Parameters.AddWithValue("@AC_5", level.Value[20]);
                        command.Parameters.AddWithValue("@AC_6", level.Value[21]);
                        command.Parameters.AddWithValue("@AC_7", level.Value[22]);
                        command.Parameters.AddWithValue("@AC_8", level.Value[23]);
                        command.Parameters.AddWithValue("@AC_9", level.Value[24]);
                        command.Parameters.AddWithValue("@AC_10", level.Value[25]);
                        command.Parameters.AddWithValue("@AC_11", level.Value[26]);
                        command.Parameters.AddWithValue("@AC_12", level.Value[27]);
                        command.Parameters.AddWithValue("@AC_13", level.Value[28]);
                        command.Parameters.AddWithValue("@AC_14", level.Value[29]);
                        command.Parameters.AddWithValue("@AC_15", level.Value[30]);
                        command.Parameters.AddWithValue("@AC_16", level.Value[31]);
                        command.Parameters.AddWithValue("@AC_17", level.Value[32]);
                        command.Parameters.AddWithValue("@AC_18", level.Value[33]);
                        command.Parameters.AddWithValue("@AC_19", level.Value[34]);
                        command.Parameters.AddWithValue("@AC_20", level.Value[35]);


                        command.ExecuteScalar();
                    }
                }
                connection.Close();
            }
        }
    }
}
