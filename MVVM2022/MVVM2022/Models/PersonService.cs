using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM2022.Models
{
     class PersonService
    {

        public List<Person> GetPeople()
        {
            var resul   = new List<Person>();
            resul.Add(new Person {FirstName="Hugo", LastName="Torrico" });
            resul.Add(new Person { FirstName = "Yury", LastName = "Montes" });
            resul.Add(new Person { FirstName = "Juan", LastName = "Marquez" });
            resul.Add(new Person { FirstName = "Guissela", LastName = "Gamarra" });
            resul.Add(new Person { FirstName = "Derek", LastName = "Palomino" });
            return resul;
        }
    }
}
