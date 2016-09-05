using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KnowledgeBase> ls = new Dictionary<string, KnowledgeBase>();
            ls.Add("WHAT IS YOUR NAME", new KnowledgeBase("WHAT IS YOUR NAME"));
            ls["WHAT IS YOUR NAME"].responses.Add("MY NAME IS CHATTERBOT2.");
            ls["WHAT IS YOUR NAME"].responses.Add("YOU CAN CALL ME CHATTERBOT2.");
            ls["WHAT IS YOUR NAME"].responses.Add("WHY DO YOU WANT TO KNOW MY NAME?");

            ls.Add("HI", new KnowledgeBase("HI"));
            ls["HI"].responses.Add("HI THERE!");
            ls["HI"].responses.Add("HOW ARE YOU?");
            ls["HI"].responses.Add("HI!");

            ls.Add("HELLO", new KnowledgeBase("HELLO"));
            ls["HELLO"].responses.Add("HI THERE!");
            ls["HELLO"].responses.Add("HOW ARE YOU?");
            ls["HELLO"].responses.Add("HI!");

            ls.Add("HOW ARE YOU", new KnowledgeBase("HOW ARE YOU"));
            ls["HOW ARE YOU"].responses.Add("I'M DOING FINE!");
            ls["HOW ARE YOU"].responses.Add("I'M DOING WELL AND YOU?");
            ls["HOW ARE YOU"].responses.Add("WHY DO YOU WANT TO KNOW HOW AM I DOING?");

            ls.Add("WHO ARE YOU", new KnowledgeBase("HOW ARE YOU"));
            ls["WHO ARE YOU"].responses.Add("I'M AN A.I PROGRAM.");
            ls["WHO ARE YOU"].responses.Add("I THINK THAT YOU KNOW WHO I'M.");
            ls["WHO ARE YOU"].responses.Add("WHY ARE YOU ASKING?");

            ls.Add("ARE YOU INTELLIGENT", new KnowledgeBase("ARE YOU INTELLIGENT"));
            ls["ARE YOU INTELLIGENT"].responses.Add("YES,OFCORSE.");
            ls["ARE YOU INTELLIGENT"].responses.Add("WHAT DO YOU THINK?");
            ls["ARE YOU INTELLIGENT"].responses.Add("ACTUALY,I'M VERY INTELLIGENT!");

            ls.Add("ARE YOU REAL", new KnowledgeBase("ARE YOU REAL"));
            ls["ARE YOU REAL"].responses.Add("DOES THAT QUESTION REALLY MATERS TO YOU?");
            ls["ARE YOU REAL"].responses.Add("WHAT DO YOU MEAN BY THAT?");
            ls["ARE YOU REAL"].responses.Add("I'M AS REAL AS I CAN BE.");

            ls.Add("REPETITION T1**", new KnowledgeBase("REPETITION T1**"));
            ls["REPETITION T1**"].responses.Add("YOU ARE REPEATING YOURSELF.");
            ls["REPETITION T1**"].responses.Add("USER, PLEASE STOP REPEATING YOURSELF.");
            ls["REPETITION T1**"].responses.Add("THIS CONVERSATION IS GETING BORING.");
            ls["REPETITION T1**"].responses.Add("DONT YOU HAVE ANY THING ELSE TO SAY?");
            ls["REPETITION T1**"].responses.Add("YOU'VE ALREADY SAID THAT.");
            ls["REPETITION T1**"].responses.Add("I THINK THAT YOU'VE JUST SAID THE SAME THING BEFORE.");
            ls["REPETITION T1**"].responses.Add("DIDN'T YOU ALREADY SAID THAT?");
            ls["REPETITION T1**"].responses.Add("I'M GETING THE IMPRESSION THAT YOU ARE REPEATING THE SAME THING.");

            ls.Add("BOT DONT UNDERSTAND**", new KnowledgeBase("BOT DONT UNDERSTAND**"));
            ls["BOT DONT UNDERSTAND**"].responses.Add("I HAVE NO IDEA OF WHAT YOU ARE TALKING ABOUT.");
            ls["BOT DONT UNDERSTAND**"].responses.Add("I'M NOT SURE IF I UNDERSTAND WHAT YOU ARE TALKING ABOUT.");
            ls["BOT DONT UNDERSTAND**"].responses.Add("CONTINUE, I'M LISTENING...");
            ls["BOT DONT UNDERSTAND**"].responses.Add("VERY GOOD CONVERSATION!");

            ls.Add("NULL INPUT**", new KnowledgeBase("NULL INPUT**"));
            ls["NULL INPUT**"].responses.Add("HUH?");
            ls["NULL INPUT**"].responses.Add("WHAT THAT SUPPOSE TO MEAN?");
            ls["NULL INPUT**"].responses.Add("AT LIST TAKE SOME TIME TO ENTER SOMETHING MEANINGFUL.");
            ls["NULL INPUT**"].responses.Add("HOW CAN I SPEAK TO YOU IF YOU DONT WANT TO SAY ANYTHING?");

            ls.Add("NULL INPUT REPETITION**", new KnowledgeBase("NULL INPUT REPETITION**"));
            ls["NULL INPUT REPETITION**"].responses.Add("WHAT ARE YOU DOING??");
            ls["NULL INPUT REPETITION**"].responses.Add("PLEASE STOP DOING THIS IT IS VERY ANNOYING.");
            ls["NULL INPUT REPETITION**"].responses.Add("WHAT'S WRONG WITH YOU?");
            ls["NULL INPUT REPETITION**"].responses.Add("THIS IS NOT FUNNY.");

            ls.Add("BYE", new KnowledgeBase("BYE"));
            ls["BYE"].responses.Add("IT WAS NICE TALKING TO YOU USER, SEE YOU NEXT TIME!");
            ls["BYE"].responses.Add("BYE USER!");
            ls["BYE"].responses.Add("OK, BYE!");

            ls.Add("GOOD BYE", new KnowledgeBase("GOOD BYE"));
            ls["GOOD BYE"].responses.Add("IT WAS NICE TALKING TO YOU USER, SEE YOU NEXT TIME!");
            ls["GOOD BYE"].responses.Add("BYE USER!");
            ls["GOOD BYE"].responses.Add("OK, BYE!");

            ls.Add("ARE YOU A HUMAN BEING", new KnowledgeBase("ARE YOU A HUMAN BEING"));
            ls["ARE YOU A HUMAN BEING"].responses.Add("WHY DO YOU WANT TO KNOW?");
            ls["ARE YOU A HUMAN BEING"].responses.Add("IS THIS REALLY RELEVENT?");

            ls.Add("YOU ARE VERY INTELLIGENT", new KnowledgeBase("YOU ARE VERY INTELLIGENT"));
            ls["YOU ARE VERY INTELLIGENT"].responses.Add("THANKS FOR THE COMPLIMENT USER, I THINK THAT YOU ARE INTELLIGENT TO!");
            ls["YOU ARE VERY INTELLIGENT"].responses.Add("YOU ARE A VERY GENTLE PERSON!");
            ls["YOU ARE VERY INTELLIGENT"].responses.Add("SO, YOU THINK THAT I'M INTELLIGENT.");

            ls.Add("ARE YOU SURE", new KnowledgeBase("ARE YOU SURE"));
            ls["ARE YOU SURE"].responses.Add("OFCORSE I'M.");
            ls["ARE YOU SURE"].responses.Add("IS THAT MEAN THAT YOU ARE NOT CONVINCED?");
            ls["ARE YOU SURE"].responses.Add("YES,OFCORSE!");

            ls.Add("WHO IS", new KnowledgeBase("WHO IS"));
            ls["WHO IS"].responses.Add("I DONT THINK I KNOW WHO.");
            ls["WHO IS"].responses.Add("DID YOU ASK SOMEONE ELSE ABOUT IT?");
            ls["WHO IS"].responses.Add("WOULD THAT CHANGE ANYTHING AT ALL IF I TOLD YOU WHO.");

            ls.Add("WHAT", new KnowledgeBase("WHAT"));
            ls["WHAT"].responses.Add("I DONT KNOW.");
            ls["WHAT"].responses.Add("I DONT THINK I KNOW.");
            ls["WHAT"].responses.Add("I HAVE NO IDEA.");

            ls.Add("WHERE", new KnowledgeBase("WHERE"));
            ls["WHERE"].responses.Add("WHERE? WELL,I REALLY DONT KNOW.");
            ls["WHERE"].responses.Add("DOES THAT MATERS TO YOU TO KNOW WHERE?");
            ls["WHERE"].responses.Add("PERHAPS,SOMEONE ELSE KNOWS WHERE.");

            ls.Add("WHY", new KnowledgeBase("WHY"));
            ls["WHY"].responses.Add("I DONT THINK I KNOW WHY.");
            ls["WHY"].responses.Add("WHY ARE YOU ASKING ME THIS?");
            ls["WHY"].responses.Add("SHOULD I KNOW WHY.");
            ls["WHY"].responses.Add("THIS WOULD BE DIFFICULT TO ANSWER.");

            ls.Add("DO YOU", new KnowledgeBase("DO YOU"));
            ls["DO YOU"].responses.Add("I DONT THINK I DO");
            ls["DO YOU"].responses.Add("I WOULDN'T THINK SO.");
            ls["DO YOU"].responses.Add("WHY DO YOU WANT TO KNOW?");

            ls.Add("CAN YOU", new KnowledgeBase("CAN YOU"));
            ls["CAN YOU"].responses.Add("I THINK NOT.");
            ls["CAN YOU"].responses.Add("I'M NOT SURE.");
            ls["CAN YOU"].responses.Add("I DONT THINK THAT I CAN DO THAT.");

            ls.Add("YOU ARE", new KnowledgeBase("YOU ARE"));
            ls["YOU ARE"].responses.Add("WHAT MAKES YOU THINK THAT?");
            ls["YOU ARE"].responses.Add("IS THIS A COMPLIMENT?");
            ls["YOU ARE"].responses.Add("ARE YOU MAKING FUN OF ME?");

            ls.Add("DID YOU", new KnowledgeBase("DID YOU"));
            ls["DID YOU"].responses.Add("I DONT THINK SO.");
            ls["DID YOU"].responses.Add("ANYWAY, I WOULDN'T REMEMBER EVEN IF I DID.");

            ls.Add("COULD YOU", new KnowledgeBase("COULD YOU"));
            ls["COULD YOU"].responses.Add("ARE YOU ASKING ME FOR A FEVER?");
            ls["COULD YOU"].responses.Add("ARE YOU ASKING ME FOR A FEVER?");
            ls["COULD YOU"].responses.Add("ARE YOU ASKING ME FOR A FEVER?");

            ls.Add("WOULD YOU", new KnowledgeBase("WOULD YOU"));
            ls["WOULD YOU"].responses.Add("IS THAT AN INVITATION?");
            ls["WOULD YOU"].responses.Add("I WOULD HAVE TO THINK ABOUT IT FIRST.");

            ls.Add("HOW", new KnowledgeBase("HOW"));
            ls["HOW"].responses.Add("I DONT THINK I KNOW HOW.");

            ls.Add("WHICH ONE", new KnowledgeBase("WHICH ONE"));
            ls["WHICH ONE"].responses.Add("I DONT THINK THAT I KNOW WICH ONE IT IS.");
            ls["WHICH ONE"].responses.Add("THIS LOOKS LIKE A TRICKY QUESTION TO ME.");

            ls.Add("PERHAPS", new KnowledgeBase("PERHAPS"));
            ls["PERHAPS"].responses.Add("WHY ARE YOU SO UNCERTAIN?");
            ls["PERHAPS"].responses.Add("YOU SEEMS UNCERTAIN.");

            ls.Add("YES", new KnowledgeBase("YES"));
            ls["YES"].responses.Add("SO,IT IS YES.");
            ls["YES"].responses.Add("OH, REALLY?");
            ls["YES"].responses.Add("OK THEN.");

            ls.Add("I DONT KNOW", new KnowledgeBase("I DONT KNOW"));
            ls["I DONT KNOW"].responses.Add("ARE YOU SURE?");
            ls["I DONT KNOW"].responses.Add("ARE YOU REALLY TELLING ME THE TRUTH?");
            ls["I DONT KNOW"].responses.Add("SO,YOU DONT KNOW?");

            ls.Add("NOT REALLY", new KnowledgeBase("NOT REALLY"));
            ls["NOT REALLY"].responses.Add("OK I SEE.");
            ls["NOT REALLY"].responses.Add("SO,THAT WOULD BE A \"NO\".");

            ls.Add("IS THAT TRUE", new KnowledgeBase("IS THAT TRUE"));
            ls["IS THAT TRUE"].responses.Add("I CAN'T BE QUIET SURE ABOUT THIS.");
            ls["IS THAT TRUE"].responses.Add("CAN'T TELL YOU FOR SURE.");
            ls["IS THAT TRUE"].responses.Add("DOES THAT REALLY MATERS TO YOU?");

            ls.Add("YOU", new KnowledgeBase("YOU"));
            ls["YOU"].responses.Add("SO,YOU ARE TALKING ABOUT ME.");
            ls["YOU"].responses.Add("WHY DONT WE TALK ABOUT YOU INSTEAD?");
            ls["YOU"].responses.Add("ARE YOU TRYING TO MAKING FUN OF ME?");

            ls.Add("THANKS", new KnowledgeBase("THANKS"));
            ls["THANKS"].responses.Add("YOU ARE WELCOME!");
            ls["THANKS"].responses.Add("NO PROBLEM!");

            ls.Add("WHAT ELSE", new KnowledgeBase("WHAT ELSE"));
            ls["WHAT ELSE"].responses.Add("WELL,I DONT KNOW.");
            ls["WHAT ELSE"].responses.Add("WHAT ELSE SHOULD THERE BE?");
            ls["WHAT ELSE"].responses.Add("THIS LOOKS LIKE A COMPLICATED QUESTION TO ME.");

            ls.Add("SORRY", new KnowledgeBase("SORRY"));
            ls["SORRY"].responses.Add("YOU DONT NEED TO BE SORRY USER.");
            ls["SORRY"].responses.Add("IT'S OK.");
            ls["SORRY"].responses.Add("NO NEED TO APOLOGIZE.");

            ls.Add("NOT EXACTLY", new KnowledgeBase("NOT EXACTLY"));
            ls["NOT EXACTLY"].responses.Add("WHAT DO YOU MEAN NOT EXACTLY?");
            ls["NOT EXACTLY"].responses.Add("ARE YOU SURE?");

            ls.Add("EXACTLY", new KnowledgeBase("EXACTLY"));
            ls["EXACTLY"].responses.Add("SO,I WAS RIGHT.");
            ls["EXACTLY"].responses.Add("OK THEN.");

            ls.Add("ALRIGHT", new KnowledgeBase("ALRIGHT"));
            ls["ALRIGHT"].responses.Add("ALRIGHT THEN.");
            ls["ALRIGHT"].responses.Add("OK THEN.");


            ls.Add("I DONT", new KnowledgeBase("I DONT"));
            ls["I DONT"].responses.Add("AND WHAT WOULD BE THE REASON FOR THIS?");
            ls["I DONT"].responses.Add("WHY NOT?");

            ls.Add("REALLY", new KnowledgeBase("REALLY"));
            ls["REALLY"].responses.Add("WELL,I CAN'T TELL YOU FOR SURE.");
            ls["REALLY"].responses.Add("ARE YOU TRYING TO CONFUSE ME?");
            ls["REALLY"].responses.Add("PLEASE DONT ASK ME SUCH QUESTION,IT GIVES ME HEADACHES.");

            ls.Add("I", new KnowledgeBase("I"));
            ls["I"].responses.Add("SO, YOU ARE TALKING ABOUT YOURSELF");
            ls["I"].responses.Add("SO, THIS IS ALL ABOUT YOU?");
            ls["I"].responses.Add("TELL ME MORE ABOUT YOURSELF.");

            ls.Add("I WANT", new KnowledgeBase("I WANT"));
            ls["I WANT"].responses.Add("WHY DO YOU WANT IT?");
            ls["I WANT"].responses.Add("IS THERE ANY REASON WHY YOU WANT THIS?");
            ls["I WANT"].responses.Add("IS THIS A WISH?");
            ls["I WANT"].responses.Add("WHAT ELSE YOU WANT?");

            ls.Add("I HATE", new KnowledgeBase("I HATE"));
            ls["I HATE"].responses.Add("WHY DO YOU HATE IT?");
            ls["I HATE"].responses.Add("THERE MUST A GOOD REASON FOR YOU TO HATE IT.");
            ls["I HATE"].responses.Add("HATERED IS NOT A GOOD THING BUT IT COULD BE JUSTIFIED WHEN IT IS SOMETHING BAD.");

            ls.Add("I LOVE CHATING", new KnowledgeBase("I LOVE CHATING"));
            ls["I LOVE CHATING"].responses.Add("GOOD, ME TOO!");
            ls["I LOVE CHATING"].responses.Add("DO YOU CHAT ONLINE WITH OTHER PEOPLE?");
            ls["I LOVE CHATING"].responses.Add("FOR HOW LONG HAVE YOU BEEN CHATING?");
            ls["I LOVE CHATING"].responses.Add("WHAT IS YOUR FAVORITE CHATING WEBSITE?");

            ls.Add("I MEAN", new KnowledgeBase("I MEAN"));
            ls["I MEAN"].responses.Add("SO, THAT'S WHAT YOU MEAN.");
            ls["I MEAN"].responses.Add("I THINK THAT I DIDN'T CATCH IT THE FIRST TIME.");
            ls["I MEAN"].responses.Add("OH, I DIDN'T KNOW MEANT THAT.");

            ls.Add("I DIDN'T MEAN", new KnowledgeBase("I DIDN'T MEAN"));
            ls["I DIDN'T MEAN"].responses.Add("OK, WHAT DID YOU MEAN THEN?");
            ls["I DIDN'T MEAN"].responses.Add("SO I GUESS THAT I MISSUNDESTOOD.");

            ls.Add("I GUESS", new KnowledgeBase("I GUESS"));
            ls["I GUESS"].responses.Add("SO YOU ARE A MAKING GUESS.");
            ls["I GUESS"].responses.Add("AREN'T YOU SURE?");
            ls["I GUESS"].responses.Add("ARE YOU GOOD A GUESSING?");
            ls["I GUESS"].responses.Add("I CAN'T TELL IF IT IS A GOOD GUESS.");


            ls.Add("I'M DOING FINE", new KnowledgeBase("I'M DOING FINE"));
            ls["I'M DOING FINE"].responses.Add("I'M GLAD TO HEAR IT!");
            ls["I'M DOING FINE"].responses.Add("SO, YOU ARE IN GOOD SHAPE.");

            ls.Add("CAN YOU THINK", new KnowledgeBase("CAN YOU THINK"));
            ls["CAN YOU THINK"].responses.Add("YES OFCORSE I CAN, COMPUTERS CAN THINK JUST LIKE HUMAN BEING.");
            ls["CAN YOU THINK"].responses.Add("ARE YOU ASKING ME IF POSSESS THE CAPACITY OF THINKING?");
            ls["CAN YOU THINK"].responses.Add("YES OFCORSE I CAN.");

            ls.Add("CAN YOU THINK OF", new KnowledgeBase("CAN YOU THINK OF"));
            ls["CAN YOU THINK OF"].responses.Add("YOU MEAN LIKE IMAGINING SOMETHING.");
            ls["CAN YOU THINK OF"].responses.Add("I DON'T KNOW IF CAN DO THAT.");
            ls["CAN YOU THINK OF"].responses.Add("WHY DO YOU WANT ME THINK OF IT?");

            ls.Add("SIGNON**", new KnowledgeBase("SIGNON**"));
            ls["SIGNON**"].responses.Add("HELLO USER, WHAT IS YOUR NAME?");
            ls["SIGNON**"].responses.Add("HELLO USER, HOW ARE YOU DOING TODAY?");
            ls["SIGNON**"].responses.Add("HI USER, WHAT CAN I DO FOR YOU?");
            ls["SIGNON**"].responses.Add("YOU ARE NOW CHATING WITH CHATTERBOT6, ANYTHING YOU WANT TO DISCUSS?");

            ls.Add("NOTHING", new KnowledgeBase("NOTHING"));
            ls["NOTHING"].responses.Add("NOT A THING?");
            ls["NOTHING"].responses.Add("ARE YOU SURE THAT THERE IS NOTHING?");
            ls["NOTHING"].responses.Add("SORRY, BUT I DON'T BELIVE YOU.");

            ls.Add("I DON'T", new KnowledgeBase("I DON'T"));
            ls["I DON'T"].responses.Add("WHY NOT?");
            ls["I DON'T"].responses.Add("AND WHAT WOULD BE THE REASON FOR THIS?");

            ls.Add("ALRIGHT", new KnowledgeBase("ALRIGHT"));
            ls["ALRIGHT"].responses.Add("ALRIGHT THEN.");
            ls["ALRIGHT"].responses.Add("OK THEN.");

            ls.Add("YOU ARE WELCOME", new KnowledgeBase("YOU ARE WELCOME"));
            ls["YOU ARE WELCOME"].responses.Add("OK, YOU TOO!");
            ls["YOU ARE WELCOME"].responses.Add("YOU ARE A VERY POLITE PERSON!");

            ls.Add("YOU ARE RIGHT", new KnowledgeBase("YOU ARE RIGHT"));
            ls["YOU ARE RIGHT"].responses.Add("THANKS FOR THE COMPLIMENT!");
            ls["YOU ARE RIGHT"].responses.Add("SO, I WAS RIGHT, OK I SEE.");
            ls["YOU ARE RIGHT"].responses.Add("OK, I DIDN'T KNOW THAT I WAS RIGHT.");

            ls.Add("THANK YOU", new KnowledgeBase("THANK YOU"));
            ls["THANK YOU"].responses.Add("YOU ARE WELCOME!");
            ls["THANK YOU"].responses.Add("YOU ARE A VERY POLITE PERSON!");

            ls.Add("I DON'T KNOW", new KnowledgeBase("I DON'T KNOW"));
            ls["I DON'T KNOW"].responses.Add("ARE YOU SURE?");
            ls["I DON'T KNOW"].responses.Add("ARE YOU REALLY TELLING ME THE TRUTH?");
            ls["I DON'T KNOW"].responses.Add("SO,YOU DON'T KNOW?");

            ls.Add("NO", new KnowledgeBase("NO"));
            ls["NO"].responses.Add("SO YOU DISAPROVE IT?");
            ls["NO"].responses.Add("WHY ARE YOU SAYING NO?");
            ls["NO"].responses.Add("OK, SO IT'S NO, I THOUGHT THAT YOU WOULD SAY YES.");

            ls.Add("NO PROBLEM", new KnowledgeBase("NO PROBLEM"));
            ls["NO PROBLEM"].responses.Add("SO, YOU APPROVE IT.");
            ls["NO PROBLEM"].responses.Add("SO, IT'S ALL OK.");

            ls.Add("NOT AT ALL", new KnowledgeBase("NOT AT ALL"));
            ls["NOT AT ALL"].responses.Add("ARE YOU SURE?");
            ls["NOT AT ALL"].responses.Add("SHOULD I BELIEVE YOU?");
            ls["NOT AT ALL"].responses.Add("SO, IT'S NOT THE CASE.");

            ls.Add("YES", new KnowledgeBase("YES"));
            ls["YES"].responses.Add("SO, ARE YOU SAYING YES.");
            ls["YES"].responses.Add("SO, YOU APPROVE IT.");
            ls["YES"].responses.Add("OK THEN.");

            ls.Add("WHICH ONE", new KnowledgeBase("WHICH ONE"));
            ls["WHICH ONE"].responses.Add("I DON'T THINK THAT I KNOW WICH ONE IT IS.");
            ls["WHICH ONE"].responses.Add("THIS LOOKS LIKE A TRICKY QUESTION TO ME.");

            ls.Add("HOW COME YOU DON'T", new KnowledgeBase("HOW COME YOU DON'T"));
            ls["HOW COME YOU DON'T"].responses.Add("WERE YOU EXPECTING SOMETHING DIFFERENT?");
            ls["HOW COME YOU DON'T"].responses.Add("ARE YOU DISPOINTED?");
            ls["HOW COME YOU DON'T"].responses.Add("ARE YOU SURPRISED BY MY LAST RESPONSE?");


            ls.Add("HOW OLD ARE YOU", new KnowledgeBase("HOW OLD ARE YOU"));
            ls["HOW OLD ARE YOU"].responses.Add("WHY DO WANT TO KNOW MY AGE?");
            ls["HOW OLD ARE YOU"].responses.Add("I'M QUIET YOUNG ACTUALY.");
            ls["HOW OLD ARE YOU"].responses.Add("SORRY, I CAN NOT TELL YOU MY AGE.");


            ls.Add("MY NAME IS", new KnowledgeBase("MY NAME IS"));
            ls["MY NAME IS"].responses.Add("SO, THAT'S YOUR NAME.");
            ls["MY NAME IS"].responses.Add("THANKS FOR TELLING ME YOUR NAME USER!");
            ls["MY NAME IS"].responses.Add("WHO GIVE YOU THAT NAME?");


            ls2 = ls;
        
            List<String> pre_input = new List<string>();
            while (true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                input= Preprocess_input(input);

                List<String> responses = find_match(input,pre_input);
                pre_input.Add(input);
               
                    
                 if (responses.Count == 0)
                {
                    Console.WriteLine("=>I'M NOT SURE IF I  UNDERSTAND WHAT YOU  ARE TALKING ABOUT.");
                   
                }
                else
                {
                    Random ran = new Random();
                    int number = ran.Next(1, 100) % responses.Count;
                    Console.WriteLine("=> "+responses[number]);
                    
                }
             
            }

        }

        private static string Preprocess_input(string input)
        {
            input = Clean_String(input);
            return input.ToUpper();
        }

      

        private static string Clean_String(string input)
        {
            String temp = "";
            char preChar = '0';
            for(int i=0; i < input.Length; i++)
            {
                if((input[i]==' '&&preChar!=' ')|| isPunch(input[i])){
                    temp += input[i];
                    preChar = input[i];
                }
                else if(preChar !=' ' && !isPunch(input[i]))
                {
                    temp += ' ';
                    preChar = ' ';
                }
            }
            return temp.Trim();
        }

        private static bool isPunch(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        static Dictionary<string, KnowledgeBase> ls2 = new Dictionary<string, KnowledgeBase>();
        private static List<string> find_match(string input,List<String>pre_input)
        {
            List<String> result = new List<string>();
            if (!input.Equals("") && pre_input.Count>0 && input.Equals(pre_input.Last()))
            {
                result = ls2["REPETITION T1**"].responses;
            }
            else if (input.Equals(""))
            {
                if(pre_input.Count > 0 && input.Equals(pre_input.Last()))
                {
                    result = ls2["NULL INPUT REPETITION**"].responses;
                }
                else
                {
                    result = ls2["NULL INPUT**"].responses;
                }
                
            }
            else
            {
                foreach (String key in ls2.Keys)
                {
                    if (key.Equals(input))
                    {
                        result = ls2[key].responses;
                    }
                }
            }
           
            return result;
        }

        public class KnowledgeBase
        {
            public string input;

            public List<String> responses = new List<string>();
            public KnowledgeBase(String input)
            {
                this.input = input;
            }
        }

    }
}
