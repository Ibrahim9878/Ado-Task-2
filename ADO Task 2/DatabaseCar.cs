using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data.SqlClient;
using System.Text.Json;
using System.Diagnostics;
using System;



namespace ADO_Task_2;

public static class DatabaseCar
{

    public static List<Car> cars = new List<Car>();
    static SqlConnection connection = null!;
    static SqlCommand cmd = null!;
    static SqlDataReader reader = null!;
    public static string connectionString = null!;
    public static void WriteUsersToDatabase()
    {

        using (connection = new(connectionString))
        {
            connection.Open();
            foreach (var car in cars)
            {
                cmd = new(@$"INSERT INTO Users(Id,Marka,Model)
                               VALUES('{car.Id}','{car.Marka}','{car.Model}')", connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
    public static void ReadUsersToDatabase()
    {
        using (connection = new(connectionString))
        {
            connection.Open();
            cmd = new("SELECT * FROM [Cars]", connection);
            reader = cmd.ExecuteReader();
            if (reader == null) return;

            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString()!);
                car.Marka = reader["Marka"].ToString()!;
                car.Model = reader["Model"].ToString()!;

                cars.Add(car);
            }
        }
    }
    
    public static List<Car> FindCarWithMarka(string marka)
    {
        using (connection = new(connectionString))
        {
            connection.Open();
            cmd = new($@"SELECT * FROM Cars WHERE Marka = @p1", connection);
            cmd.Parameters.Add("@p1", System.Data.SqlDbType.NVarChar).Value = marka;
            reader = cmd.ExecuteReader();
            List<Car> cars2 = new List<Car>();   
            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString()!);
                car.Marka = reader["Marka"].ToString()!;
                car.Model = reader["Model"].ToString()!;
                cars2.Add(car);
            }
            return cars2;
        }
    }
    public static List<Car> FindCarWithModel(string model)
    {
        using (connection = new(connectionString))
        {
            connection.Open();
            cmd = new($@"SELECT * FROM Cars WHERE Model = @p1", connection);
            cmd.Parameters.Add("@p1", System.Data.SqlDbType.NVarChar).Value = model;
            reader = cmd.ExecuteReader();
            List<Car> cars2 = new List<Car>();
            while (reader.Read())
            {
                Car car = new Car();
                car.Id = int.Parse(reader["Id"].ToString()!);
                car.Marka = reader["Marka"].ToString()!;
                car.Model = reader["Model"].ToString()!;
                cars2.Add(car);
            }
            return cars2;
        }
    }

    public static string configurationWindow()
    {
        var builder = new ConfigurationBuilder();

        builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var configuration = builder.Build();

        var cs = configuration["ConnectionString"];
        return cs!;
    }
}
