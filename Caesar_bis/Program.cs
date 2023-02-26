using System;  

namespace Caesar_bis
{
    internal class Program
    {
        
        public static void Main()
        { 
        
            Console.WriteLine("Type a string to encrypt:");  
            string UserString = Console.ReadLine();  
  
            Console.WriteLine("Enter your Key:");  
            int key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Encrypted Data"); 
            string cipherText = Logic.Encipher(UserString, key);
            Console.WriteLine(cipherText);  
            
            Console.WriteLine("Decrypted Data:");
            string decryptedText = Logic.Decipher(cipherText, key);  
            Console.WriteLine(decryptedText); 
            
            Console.ReadKey();  
        }
    }
}