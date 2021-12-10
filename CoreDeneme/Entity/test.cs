using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Entity
{
    public class test
    {

        public void a()
        {
            myClass<string> myClass1 = new myClass<string>();

     
            //myClass1.AddListItem("a",);

        }


    }



    public class myClass<T> : myInterface<T>
    {
  

        public void AddListItem(T addingItem, MyList<T> myListModel)
        {
            myListModel.myList.Add(addingItem);
        }
    }

    public interface myInterface<T>
    {
       public void AddListItem(T addingItem, MyList<T> myList);

    }
    public class MyList<T>
    {
        public List<T> myList { get; set; }
    }
}
