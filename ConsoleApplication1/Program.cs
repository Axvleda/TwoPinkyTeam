using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Xml;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            _list();
        }

        static void _list()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("words.xml");
            Console.WriteLine(doc);
            
            var s = new[]
            {
                   "Lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "At", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "Stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "Lorem", "ipsum", "dolor", "sit", "amet", "Lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "At", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "Stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "Lorem", "ipsum", "dolor", "sit", "amet"
                            };

            foreach (var s1 in s)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (showComparison(s1,  s[i]))
                    {
                        Console.WriteLine($"                                      We found a Match! <{s1}> and <{s[i]}>");

                    }
                }
                {
                    
                }
            }
        }


        static void goofy()
        {
            const string first = "Sie tanzen auf der Straße.";
            const string second = "Sie tanzen auf der Strasse.";
            Console.WriteLine($"First sentence is <{first}>");
            Console.WriteLine($"Second sentence is <{second}>");
            
            String.Equals("weIß",  "weiss",  StringComparison.InvariantCultureIgnoreCase);
            bool equal = String.Equals(first,  second,  StringComparison.InvariantCulture);
            Console.WriteLine($"The two strings {(equal == true ? "are" : "are not")} equal.");
            showComparison(first,  second);

            string word = "coop";
            string words = "co-op";
            string other = "cop";

            showComparison(word,  words);
            showComparison(word,  other);
            showComparison(words,  other);
            showComparison("words",  "Words");
            showComparison("words",  "w0rds");
            showComparison("words",  "vvords");
            showComparison("words",  "woRDS");
        }


        static bool showComparison(string one,  string two)
        {
            bool b = false;
            int compareLinguistic = String.Compare(one,  two,  StringComparison.InvariantCulture);
            int compareOrdinal = String.Compare(one,  two,  StringComparison.Ordinal);
            if (compareLinguistic < 0)
                Console.WriteLine($"<{one}> is less than <{two}> using invariant culture");
            else if (compareLinguistic > 0)
                Console.WriteLine($"<{one}> is greater than <{two}> using invariant culture");
            else
            {
                Console.WriteLine($"<{one}> and <{two}> are equivalent in order using invariant culture");
                b = true;
            }
            
            if (compareOrdinal < 0)
                Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
            else if (compareOrdinal > 0)
                Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
            else
            {
                Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
                b = true;
            }

            return b;
        }
    }
}