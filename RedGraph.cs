using System;
using System.Collections.Generic;

class RedGraph : Graph {
   
   /*
   Adjacency lists represented using nested dictionaries 
   
   Outer dictionary records edges for each node
      adjLists[a] = edges from node b

   Inner dictionary records costs for each edge
      adjLists[a][b] = cost of edge from a->b
   */
   private Dictionary<Node, Dictionary<Node, int>> adjLists;
   
   public RedGraph() {
      adjLists = new Dictionary<Node, Dictionary<Node, int>> ();
   }



   // ADD MISSING METHODS HERE



   public void Write() {
      Console.WriteLine("RedGraph");

      foreach (Node node in adjLists.Keys) {
         Console.Write(node + ": ");
         bool first = true;
         foreach (Node neighbour in adjLists[node].Keys) {
            if (!first) Console.Write(", ");
            Console.Write(neighbour + "(" + Cost(node,neighbour) + ")");
            first = false;
         }
         
         Console.Write("\n");
      }
   }
}