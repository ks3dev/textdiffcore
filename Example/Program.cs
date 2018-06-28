﻿using System;
using System.Collections.Generic;
using System.Linq;
using textdiffcore;
using textdiffcore.DiffOutputGenerators;
using textdiffcore.TextDiffEngine;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            TextDiff diffobj = new TextDiff(new csDiff(), new HTMLDiffOutputGenerator("span", "style", "color:#003300;background-color:#ccff66;","color:#990000;background-color:#ffcc99;text-decoration:line-through;",""));
            

            string oldText = "The quick brown fox jumps over the lazy dog";
            string newText = "A quick cat jumps over the lazy sleeping dog";
            string output =  diffobj.GenerateDiffOutput(oldText,newText);

            if(true)
            {
                oldText = "The quick brown fox";
                output ="";


                //Equal
                System.Console.WriteLine("#1 Equal test");
                newText = "The quick brown fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";
                
                //Add at start
                System.Console.WriteLine("#2 Add at start");
                newText = "Once The quick brown fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";

        
                //Remove at start
                System.Console.WriteLine("#3 Remove at start");
                newText = "quick brown fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";

    
                //Add at middle
                System.Console.WriteLine("#4 Add at middle");
                newText = "The quick agile brown fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";

        
                //Remove at middle
                System.Console.WriteLine("#5 Remove at middle");
                newText = "The quick fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";

                
                //Add at end
                System.Console.WriteLine("#6 Add at end");
                newText = "The quick brown fox jumped";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Remove at end
                System.Console.WriteLine("#7 Remove at end");
                newText = "The quick brown";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";

                

                //Update at start
                System.Console.WriteLine("#8 Update at start");
                newText = "A quick brown fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Update at middle
                System.Console.WriteLine("#9 Update at middle");
                newText = "The quick blue fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Update at end
                System.Console.WriteLine("#10 Update at end");
                newText = "The quick brown cat";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Multiple add
                System.Console.WriteLine("#11 Multiple add");
                newText = "The quick agile brown fox jumped";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Multiple remove
                System.Console.WriteLine("#12 Multiple remove");
                newText = "quick fox";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";


                //Multiple updates
                System.Console.WriteLine("#13 Multiple updates");
                newText = "The slow brown cat";
                output += diffobj.GenerateDiffOutput(oldText,newText);
                PrintList(diffobj.InnerList,oldText,newText);
                output+="<br/>";
            }


           //System.Console.WriteLine(output);


            Console.ReadLine();
        }

        static void PrintList(List<Diffrence> d, string oldtext, string newtext)
        {
            System.Console.WriteLine("\"{0}\" vs \"{1}\"", oldtext, newtext);
            System.Console.WriteLine("-----------");
            foreach (Diffrence df in d)
            {                
                System.Console.WriteLine(df.action.ToString()  + " \t " +df.value);
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}