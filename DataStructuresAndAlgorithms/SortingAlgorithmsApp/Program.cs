using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the sorting option");
        Console.WriteLine("1: sort by salary using bubble sort");
        Console.WriteLine("2: sort by firstname using insertion sort");
        Console.WriteLine("3: sort by lastname using merge sort");
        Console.WriteLine("4: sort by salary using quick sort");
        Console.Write("Make a choice: ");
        int option = int.Parse(Console.ReadLine());

        // Create a connection to the database file
        string connectionString = "Data Source=D:\\MYAZ2042063\\DataStructuresAndAlgorithms\\SortingAlgorithmsApp\\Employee.db";
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            

            // Read the data from the employee table
            var command = new SqliteCommand("SELECT * FROM Employees", connection);
            var reader = command.ExecuteReader();
            var employees = new List<Employee>();
            while (reader.Read())
            {
                var employee = new Employee();
                employee.Id = Convert.ToInt32(reader["id"]);
                employee.FirstName = (string)reader["firstname"];
                employee.LastName = (string)reader["lastname"];
                employee.Salary = Convert.ToDecimal(reader["salary"]);
                employees.Add(employee);
            }
            string sortingOption = "";
            switch (option)
            {
                case 1:

                    BubbleSortBySalary(employees);
                    sortingOption = "sorted by salary using bubble sort";

                    break;

                case 2:
                    InsertionSortByFirstName(employees);
                    sortingOption = "sorted by first name  using insertion sort";
                    break;
                case 3:
                    MergeSortByLastName(employees);
                    sortingOption = "sorted by last name using merge sort";
                    break;
                    
                case 4:
                    sortingOption = "sorted by salary using quick sort";
                    QuickSortBySalary(employees);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
                    

            }
            
           
            Console.WriteLine("ID\tFirst Name\tLast Name\tSalary\tTitle");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id,-7} {employee.FirstName,-15} {employee.LastName,-15} {employee.Salary,-10}");
            }
            Console.WriteLine($"\nData {sortingOption}:");   
        }
        Console.ReadKey();
    }
    static void BubbleSortBySalary(List<Employee> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            for (int j = 0; j < employees.Count - i - 1; j++)
            {
                if (employees[j].Salary > employees[j + 1].Salary)
                {
                    var temp = employees[j];
                    employees[j] = employees[j + 1];
                    employees[j + 1] = temp;
                }
            }
        }
    }

    static void InsertionSortByFirstName(List<Employee> employees)
    {
        for (int i = 1; i < employees.Count; i++)
        {
            var current = employees[i];
            int j = i - 1;
            while (j >= 0 && employees[j].FirstName.CompareTo(current.FirstName) > 0)
            {
                employees[j + 1] = employees[j];
                j--;
            }
            employees[j + 1] = current;
        }
    }

    static void MergeSortByLastName(List<Employee> employees)
    {
        MergeSortByLastNameHelper(employees, 0, employees.Count - 1);
    }

    static void MergeSortByLastNameHelper(List<Employee> employees, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortByLastNameHelper(employees, left, mid);
            MergeSortByLastNameHelper(employees, mid + 1, right);
            MergeByLastName(employees, left, mid, right);
        }
    }
    static void MergeByLastName(List<Employee> employees, int left, int mid, int right)
    {
        var temp = new List<Employee>(right - left + 1);
        int i = left;
        int j = mid + 1;
        while (i <= mid && j <= right)
        {
            if (employees[i].LastName.CompareTo(employees[j].LastName) <= 0)
            {
                temp.Add(employees[i]);
                i++;
            }
            else
            {
                temp.Add(employees[j]);
                j++;
            }
        }
        while (i <= mid)
        {
            temp.Add(employees[i]);
            i++;
        }
        while (j <= right)
        {
            temp.Add(employees[j]);
            j++;
        }
        for (int k = 0; k < temp.Count; k++)
        {
            employees[left + k] = temp[k];
        }
    }

    static void QuickSortBySalary(List<Employee> employees)
    {
        QuickSortBySalaryHelper(employees, 0, employees.Count - 1);
    }

    static void QuickSortBySalaryHelper(List<Employee> employees, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = PartitionBySalary(employees, left, right);
            QuickSortBySalaryHelper(employees, left, pivotIndex - 1);
            QuickSortBySalaryHelper(employees, pivotIndex + 1, right);
        }
    }

    static int PartitionBySalary(List<Employee> employees, int left, int right)
    {
        var pivot = employees[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (employees[j].Salary <= pivot.Salary)
            {
                i++;
                var temp = employees[i];
                employees[i] = employees[j];
                employees[j] = temp;
            }
        }
        var temp2 = employees[i + 1];
        employees[i + 1] = employees[right];
        employees[right] = temp2;
        return i + 1;
    }

}



