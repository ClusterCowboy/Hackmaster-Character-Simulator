using System;
using System.Data.SQLite;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using static GenericEnums.GenericEnums;

namespace Weapons
{

    /**
     * All weapons should be accesssed through the weapon accessor
     * 
     * It contains methods for pulling weapons out of a database and then
     * storing them locally. Hypothetically it could be used to update weapons
     * but it should really be used once for that and then done.
     * 
     * Monster Weapons are a single die roll per attack, so they're not
     * terribly useful to have in here. Might be best to just have them 
     * implement the IWeapon class and then load with the save.
     * */
    public class WeaponAccessor
    {
        public Dictionary<string, MeleeWeapon> MeleeWeaponsCatalog;
        public string WeaponsConnectionString = "Data Source=weapons.db;Version=3";
        public WeaponAccessor()
        {
            using (SQLiteConnection connection = new SQLiteConnection(WeaponsConnectionString))
            {
                connection.Open();

                // Create table if not exists
                string createTableQuery = $@"
                CREATE TABLE IF NOT EXISTS {typeof(MeleeWeapon).Name}s (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ItemName TEXT,
                    Value REAL,
                    _weight REAL,
                    _weaponSize TEXT,
                    WeaponDamageType TEXT,
                    SpeedFactor INTEGER,
                    tinyDiceNum INTEGER,
                    tinyDiceSides INTEGER,
                    tinyDiceMod INTEGER,
                    smallDiceNum INTEGER,
                    smallDiceSides INTEGER,
                    smallDiceMod INTEGER,
                    mediumDiceNum INTEGER,
                    mediumDiceSides INTEGER,
                    mediumDiceMod INTEGER,
                    largeDiceNum INTEGER,
                    largeDiceSides INTEGER,
                    largeDiceMod INTEGER,
                    hugeDiceNum INTEGER,
                    hugeDiceSides INTEGER,
                    hugeDiceMod INTEGER,
                    gargantuanDiceNum INTEGER,
                    gargantuanDiceSides INTEGER,
                    gargantuanDiceMod INTEGER,
                    _avaHi INTEGER,
                    _avaMid INTEGER,
                    _avaLow INTEGER
                );";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    int m = command.ExecuteNonQuery();
                }

                // Read updated data
                ReadData(connection);

                connection.Close();
            }
        }

        public void InsertData(List<MeleeWeapon> weapons)
        {
            using (SQLiteConnection connection = new SQLiteConnection(WeaponsConnectionString))
            {
                connection.Open();

                string insertDataQuery = $@"
            INSERT INTO MeleeWeapons (
                ItemName, Value, _weight, _weaponSize, WeaponDamageType, SpeedFactor,
                tinyDiceNum, tinyDiceSides, tinyDiceMod,
                smallDiceNum, smallDiceSides, smallDiceMod,
                mediumDiceNum, mediumDiceSides, mediumDiceMod,
                largeDiceNum, largeDiceSides, largeDiceMod,
                hugeDiceNum, hugeDiceSides, hugeDiceMod,
                gargantuanDiceNum, gargantuanDiceSides, gargantuanDiceMod,
                _avaHi, _avaMid, _avaLow
            ) VALUES (
                @ItemName, @Value, @_weight, @_weaponSize, @WeaponDamageType, @SpeedFactor,
                @tinyDiceNum, @tinyDiceSides, @tinyDiceMod,
                @smallDiceNum, @smallDiceSides, @smallDiceMod,
                @mediumDiceNum, @mediumDiceSides, @mediumDiceMod,
                @largeDiceNum, @largeDiceSides, @largeDiceMod,
                @hugeDiceNum, @hugeDiceSides, @hugeDiceMod,
                @gargantuanDiceNum, @gargantuanDiceSides, @gargantuanDiceMod,
                @_avaHi, @_avaMid, @_avaLow
            );
            SELECT last_insert_rowid();";

                foreach (MeleeWeapon weapon in weapons)
                {

                    using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", weapon.ItemName);
                        command.Parameters.AddWithValue("@Value", weapon.Value);
                        command.Parameters.AddWithValue("@_weight", weapon.Weight);
                        command.Parameters.AddWithValue("@_weaponSize", weapon._weaponSize.ToString());
                        command.Parameters.AddWithValue("@WeaponDamageType", weapon.WeaponDamageType.ToString());
                        command.Parameters.AddWithValue("@SpeedFactor", weapon.SpeedFactor);
                        command.Parameters.AddWithValue("@tinyDiceNum", weapon.tinyDiceNum);
                        command.Parameters.AddWithValue("@tinyDiceSides", weapon.tinyDiceSides);
                        command.Parameters.AddWithValue("@tinyDiceMod", weapon.tinyDiceMod);
                        command.Parameters.AddWithValue("@smallDiceNum", weapon.smallDiceNum);
                        command.Parameters.AddWithValue("@smallDiceSides", weapon.smallDiceSides);
                        command.Parameters.AddWithValue("@smallDiceMod", weapon.smallDiceMod);
                        command.Parameters.AddWithValue("@mediumDiceNum", weapon.mediumDiceNum);
                        command.Parameters.AddWithValue("@mediumDiceSides", weapon.mediumDiceSides);
                        command.Parameters.AddWithValue("@mediumDiceMod", weapon.mediumDiceMod);
                        command.Parameters.AddWithValue("@largeDiceNum", weapon.largeDiceNum);
                        command.Parameters.AddWithValue("@largeDiceSides", weapon.largeDiceSides);
                        command.Parameters.AddWithValue("@largeDiceMod", weapon.largeDiceMod);
                        command.Parameters.AddWithValue("@hugeDiceNum", weapon.hugeDiceNum);
                        command.Parameters.AddWithValue("@hugeDiceSides", weapon.hugeDiceSides);
                        command.Parameters.AddWithValue("@hugeDiceMod", weapon.hugeDiceMod);
                        command.Parameters.AddWithValue("@gargantuanDiceNum", weapon.gargantuanDiceNum);
                        command.Parameters.AddWithValue("@gargantuanDiceSides", weapon.gargantuanDiceSides);
                        command.Parameters.AddWithValue("@gargantuanDiceMod", weapon.gargantuanDiceMod);
                        command.Parameters.AddWithValue("@_avaHi", weapon._avaHi);
                        command.Parameters.AddWithValue("@_avaMid", weapon._avaMid);
                        command.Parameters.AddWithValue("@_avaLow", weapon._avaLow);

                        command.ExecuteScalar();
                    }
                }
                connection.Close();
            }
        }

        public void ReadData(SQLiteConnection connection)
        {
            string readDataQuery = "SELECT * FROM MeleeWeapons;";

            using (SQLiteCommand command = new SQLiteCommand(readDataQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MeleeWeapon result = new MeleeWeapon
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ItemName = Convert.ToString(reader["ItemName"]),
                            Value = Convert.ToDouble(reader["Value"]),
                            Weight = Convert.ToDouble(reader["_weight"]),
                            _weaponSize = (Size)Enum.Parse(typeof(Size), Convert.ToString(reader["_weaponSize"])),
                            WeaponDamageType = (WeaponType)Enum.Parse(typeof(WeaponType), Convert.ToString(reader["WeaponDamageType"])),
                            SpeedFactor = Convert.ToInt32(reader["SpeedFactor"]),
                            tinyDiceNum = Convert.ToInt32(reader["tinyDiceNum"]),
                            tinyDiceSides = Convert.ToInt32(reader["tinyDiceSides"]),
                            tinyDiceMod = Convert.ToInt32(reader["tinyDiceMod"]),
                            smallDiceNum = Convert.ToInt32(reader["smallDiceNum"]),
                            smallDiceSides = Convert.ToInt32(reader["smallDiceSides"]),
                            smallDiceMod = Convert.ToInt32(reader["smallDiceMod"]),
                            mediumDiceNum = Convert.ToInt32(reader["mediumDiceNum"]),
                            mediumDiceSides = Convert.ToInt32(reader["mediumDiceSides"]),
                            mediumDiceMod = Convert.ToInt32(reader["mediumDiceMod"]),
                            largeDiceNum = Convert.ToInt32(reader["largeDiceNum"]),
                            largeDiceSides = Convert.ToInt32(reader["largeDiceSides"]),
                            largeDiceMod = Convert.ToInt32(reader["largeDiceMod"]),
                            hugeDiceNum = Convert.ToInt32(reader["hugeDiceNum"]),
                            hugeDiceSides = Convert.ToInt32(reader["hugeDiceSides"]),
                            hugeDiceMod = Convert.ToInt32(reader["hugeDiceMod"]),
                            gargantuanDiceNum = Convert.ToInt32(reader["gargantuanDiceNum"]),
                            gargantuanDiceSides = Convert.ToInt32(reader["gargantuanDiceSides"]),
                            gargantuanDiceMod = Convert.ToInt32(reader["gargantuanDiceMod"]),
                            _avaHi = Convert.ToInt32(reader["_avaHi"]),
                            _avaMid = Convert.ToInt32(reader["_avaMid"]),
                            _avaLow = Convert.ToInt32(reader["_avaLow"])
                        };

                        MeleeWeaponsCatalog[result.ItemName] = result;
                    }
                }
            }
        }

        public void UpdateData(SQLiteConnection connection, int id, MeleeWeapon weapon)
        {
            string updateDataQuery = $@"
        UPDATE MeleeWeapons
        SET
            ItemName = @ItemName,
            Value = @Value,
            _weight = @_weight,
            _weaponSize = @_weaponSize,
            WeaponDamageType = @WeaponDamageType,
            SpeedFactor = @SpeedFactor,
            tinyDiceNum = @tinyDiceNum,
            tinyDiceSides = @tinyDiceSides,
            tinyDiceMod = @tinyDiceMod,
            smallDiceNum = @smallDiceNum,
            smallDiceSides = @smallDiceSides,
            smallDiceMod = @smallDiceMod,
            mediumDiceNum = @mediumDiceNum,
            mediumDiceSides = @mediumDiceSides,
            mediumDiceMod = @mediumDiceMod,
            largeDiceNum = @largeDiceNum,
            largeDiceSides = @largeDiceSides,
            largeDiceMod = @largeDiceMod,
            hugeDiceNum = @hugeDiceNum,
            hugeDiceSides = @hugeDiceSides,
            hugeDiceMod = @hugeDiceMod,
            gargantuanDiceNum = @gargantuanDiceNum,
            gargantuanDiceSides = @gargantuanDiceSides,
            gargantuanDiceMod = @gargantuanDiceMod,
            _avaHi = @_avaHi,
            _avaMid = @_avaMid,
            _avaLow = @_avaLow
        WHERE Id = @Id;";

            using (SQLiteCommand command = new SQLiteCommand(updateDataQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@ItemName", weapon.ItemName);
                command.Parameters.AddWithValue("@Value", weapon.Value);
                command.Parameters.AddWithValue("@_weight", weapon.Weight);
                command.Parameters.AddWithValue("@_weaponSize", weapon._weaponSize.ToString());
                command.Parameters.AddWithValue("@WeaponDamageType", weapon.WeaponDamageType.ToString());
                command.Parameters.AddWithValue("@SpeedFactor", weapon.SpeedFactor);
                command.Parameters.AddWithValue("@tinyDiceNum", weapon.tinyDiceNum);
                command.Parameters.AddWithValue("@tinyDiceSides", weapon.tinyDiceSides);
                command.Parameters.AddWithValue("@tinyDiceMod", weapon.tinyDiceMod);
                command.Parameters.AddWithValue("@smallDiceNum", weapon.smallDiceNum);
                command.Parameters.AddWithValue("@smallDiceSides", weapon.smallDiceSides);
                command.Parameters.AddWithValue("@smallDiceMod", weapon.smallDiceMod);
                command.Parameters.AddWithValue("@mediumDiceNum", weapon.mediumDiceNum);
                command.Parameters.AddWithValue("@mediumDiceSides", weapon.mediumDiceSides);
                command.Parameters.AddWithValue("@mediumDiceMod", weapon.mediumDiceMod);
                command.Parameters.AddWithValue("@largeDiceNum", weapon.largeDiceNum);
                command.Parameters.AddWithValue("@largeDiceSides", weapon.largeDiceSides);
                command.Parameters.AddWithValue("@largeDiceMod", weapon.largeDiceMod);
                command.Parameters.AddWithValue("@hugeDiceNum", weapon.hugeDiceNum);
                command.Parameters.AddWithValue("@hugeDiceSides", weapon.hugeDiceSides);
                command.Parameters.AddWithValue("@hugeDiceMod", weapon.hugeDiceMod);
                command.Parameters.AddWithValue("@gargantuanDiceNum", weapon.gargantuanDiceNum);
                command.Parameters.AddWithValue("@gargantuanDiceSides", weapon.gargantuanDiceSides);
                command.Parameters.AddWithValue("@gargantuanDiceMod", weapon.gargantuanDiceMod);
                command.Parameters.AddWithValue("@_avaHi", weapon._avaHi);
                command.Parameters.AddWithValue("@_avaMid", weapon._avaMid);
                command.Parameters.AddWithValue("@_avaLow", weapon._avaLow);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(SQLiteConnection connection, int id)
        {
            string deleteDataQuery = "DELETE FROM MeleeWeapons WHERE Id = @Id;";

            using (SQLiteCommand command = new SQLiteCommand(deleteDataQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

    }
}
