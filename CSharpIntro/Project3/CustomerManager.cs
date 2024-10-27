using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    
    internal class CustomerManager
    {   //customers ları başka methodlarda kullanmak için burada liste oluşturduk 
        List<Customer> customers;
        //türü olmayan constructor methodu:
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{ID=1,FirstName="Engin",LastName="Demiroğ",City="Ankara",Email="Engin@..."},
                new Customer{ID=1,FirstName="Derin",LastName="Demiroğ",City="Ankara",Email="Derin@..."},
                new Customer{ID=1,FirstName="Salih",LastName="Demiroğ",City="Ankara",Email="Salih@..."},
                new Customer{ID=1,FirstName="Ahmet",LastName="Demiroğ",City="İstanbul",Email="Ahmet@..."},
                new Customer{ID=1,FirstName="Mehmet",LastName="Demiroğ",City="İzmir",Email="Mehmet@..."}
            };
        }     
        //List<Customer> ın buradaki görevi tür belirtmek
        //new list yaptığımızda customer ı başka bir şeye dönüştüreceğimiz için kod çalışır ama
        // istediğimiz şekilde deil o yüzden constructor methodunu kullanmamız gerekiyor
        public List<Customer> GetAll()
        {   //Buradaki new in bir kere çalışması için constructor methodunun içine yazdık
            //customers = new List<Customer>()
            //{
            //    new Customer{ID=1,FirstName="Engin",LastName="Demiroğ",City="Ankara",Email="Engin@..."},
            //    new Customer{ID=1,FirstName="Derin",LastName="Demiroğ",City="Ankara",Email="Derin@..."},
            //    new Customer{ID=1,FirstName="Salih",LastName="Demiroğ",City="Ankara",Email="Salih@..."},
            //    new Customer{ID=1,FirstName="Ahmet",LastName="Demiroğ",City="İstanbul",Email="Ahmet@..."},
            //    new Customer{ID=1,FirstName="Mehmet",LastName="Demiroğ",City="İzmir",Email="Mehmet@..."}
            //};
            return customers;
        }
        //ID,FirstName... leri birdaha yazmamak için direkt parantez içine classı çağırırız
        public void Add(Customer customer)
        {    //Gİrilen yeni müşteriyi customers listesine ekle deriz
            customers.Add(customer);
        }
    }
}
