using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
            decimal value = 0.0m;

            // traverse the list till the end
            StockNode current = this.head;
            while (current.Next != null)
            {
                current = current.Next; //This is where the value for the given stocknode is made.
                value = value + (current.StockHolding.Holdings * current.StockHolding.CurrentPrice);
             }

            return value;
        }

    //param  (StockList) listToCompare     : StockList which has to compared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      

            return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {
            // write your implementation here
            // traverse the list till the end
            StockNode current = this.head;
            //Print the First Stock in the list
            Console.WriteLine(current.StockHolding.Name);

            while (current.Next != null)

            {
                current = current.Next; //While going through the List, we Print each node
                Console.WriteLine(current.StockHolding.Name);


            }

        }
  }
}
