using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
      
       public StockList MergeList(StockList listToMerge)
    {
            
            StockNode current = this.head;
            
                      
            head = current;
                     
            StockNode merge = listToMerge.head;
            //We go to the end of the first list that is going to be merged
            while (current.Next!=null)
            {
                current = current.Next;

            }

            current.Next = merge; // This is how we combine both lists

            current = this.head;

            StockList ResultList = new StockList();

            ResultList.head= current;

            

            return ResultList; 
        } 

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = new Stock();

            StockNode current = this.head;
            mostShareStock = this.head.StockHolding;
                while (current.Next != null)

                {
                    current = current.Next; // For each StockNode, we compare to the previous to
                                            //To see who has greates holdings.
                    if (current.StockHolding.Holdings > mostShareStock.Holdings)
                    {
                        mostShareStock = current.StockHolding;
                    

                }


                }
            
            return mostShareStock; 
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

            if (this.head==null)
            { length = 0; } //If list is empty, result is 0

            else {
                length = length + 1;
                // traverse the list till the end
                StockNode current = this.head;
                while (current.Next != null)
                {
                    current = current.Next; // Add 1 per each stocknone in list
                    length = length + 1;

                } 
                }

            

            return length;
    }
  }
}
