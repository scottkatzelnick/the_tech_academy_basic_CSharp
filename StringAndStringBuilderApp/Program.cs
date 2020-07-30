using System;
using System.Text;

namespace StringAndStringBuilderApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Concatenate 3 strings
            const string str1 = "Hello, this string ";
            const string str2 = "will be put together ";
            const string str3 = "using concatenation in C#.";

            Console.WriteLine(str1 + str2 + str3);

            // Convert a string to Uppercssd
            const string strNormal = "Using a special method, this string will be re-created in all Caps!";
            Console.WriteLine("\n");
            Console.WriteLine(strNormal + "\ngets converted to:\n" + strNormal.ToUpper());

            // Using StringBuilder build a paragraph
            StringBuilder rootString = new StringBuilder();

            rootString.Append("\tThe basic computer has eight main components that help it run smoothly. "); // introduction
            rootString.Append("Starting \nwith the exterior, you have something called the case, which houses all of the other parts. "); // case
            rootString.Append("\nNext, we have the power supply that delivers, you guessed it, power to all the main \ncomponents. "); // power supply
            rootString.Append("Then, the motherboard is what connects all of the internals to one another. "); // motherboard
            rootString.Append("One \nof, if not the most important part is the Central Processing Unit, or CPU. It is the brains \nof your computer. "); //cpu
            rootString.Append("Next up is memory, or RAM (Random Access Memory). It is a volatile, \ntemporary storage medium that allows the CPU to store variables and other data until either, \nthe program ends and/or the computer is shut down. "); // memory
            rootString.Append("That brings us to the permanent storage \nsolution, the Hard Drive. It is where all of your programs and important data is stored for \nrepeated access. It, unlike memory, dosen't get wiped after losing power. "); // hard drive
            rootString.Append("Next, we have the \ngraphics processor, or graphics card. It's main responsibility is to drive a monitor, \noutputting the video signal created by the CPU. It's primary goal is to give the user a GUI to \ninteract with and trasnlate ones and zeros into images and videos."); // graphics processor
            rootString.Append("Lastly, the sound \ncard. It does just that and outputs sounds, i.e. music, sound effects, system sounds \nto a speaker adding another dimension of useability for the user. "); // sound card
            rootString.Append("There are definitely more \nparts that make up a computer, but these main eight are the required minimums to get a computer \nup and runnign."); // conclusion

            Console.WriteLine("\r");
            Console.WriteLine(rootString);
            Console.Read();
        }
    }
}
