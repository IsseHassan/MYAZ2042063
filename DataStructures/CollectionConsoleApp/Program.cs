using CollectionConsoleApp;

//cars
var list1 = new List<Customer>()
{
    new Customer(){Id = 1, FullName =" Ahmet Can"},
    new Customer(){Id = 2, FullName =" Mehmet Dağ"},
    new Customer(){Id = 3, FullName =" Fatma Güneş"},
    new Customer(){Id = 4, FullName =" Can Bulut"},
    new Customer(){Id = 5, FullName =" Canan Nehir"}
};

// home
var list2 = new List<Customer>()
{
     new Customer(){Id = 1, FullName =" Ahmet Can"},
     new Customer(){Id = 4, FullName =" Can Bulut"},
     new Customer(){Id = 6, FullName =" Melike Güneş"},
};

// home + cars

var result = new List<Customer>();

foreach (Customer customer in list1)
{
    if (list2.Select(c => c.Id).Contains(customer.Id))
    {
        result.Add(customer);
    }
}

result.ForEach(c => Console.WriteLine(c));


Console.ReadKey();
