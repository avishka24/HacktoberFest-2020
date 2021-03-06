using System; 
  
class BIS { 
    public static void sort(int []array) 
    { 
        for (int i = 1; i < array.Length; i++) 
        { 
            int x = array[i]; 
  
            // Find location to insert using 
            // binary search 
            int j = Math.Abs(Array.BinarySearch( array, 0, i, x) + 1); 
  
            // Shifting array to one location right 
            System.Array.Copy(array, j, array, j + 1, i - j); 
 
            array[j] = x; 
        } 
    }
    public static void Main() 
    { 
        int size;
        size= Convert.ToInt32(Console.ReadLine()); 

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
	    array[i] = Convert.ToInt32(Console.ReadLine());
	    
        sort(array); 
	    
        for (int i = 0; i < array.Length; i++) 
            Console.Write(array[i] + " "); 
    } 
} 
