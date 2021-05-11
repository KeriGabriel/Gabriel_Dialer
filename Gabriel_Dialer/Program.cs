using System;

namespace Gabriel_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
             const int MAX_SIZE = 10;

            Phone[] dialingList = new Phone[MAX_SIZE];

            dialingList[0] = new HomePhone("CompuTest", "(303) 985-5060", "1");
            dialingList[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", "2");
            dialingList[2] = new HomePhone("Data Functions", "(800) 876-2524", "1");
            dialingList[3] = new HomePhone("Donnay Repair", "(708) 397-3330", "1");
            dialingList[4] = new HomePhone("ErgoNomic Inc","(360) 434-3894","1");
            dialingList[5] = new HomePhone("Ergo Source", "(800) 969-4374", "1");
            dialingList[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", "2");
            dialingList[7] = new CellPhone("Glare-Guard", "(800) 545-6254", "2");
            dialingList[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", "2");
            dialingList[9] = new CellPhone("Komfort Support", "(714) 472-4409", "2");

            for (int i = 0; i <MAX_SIZE; i++)
            {
                Console.WriteLine(dialingList[i].dial());
            }                    
        }
    }
}
