using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFriends
{
    public class Friends
    {
       public void Main() 
        {
            List<string> boys = new List<string>(3) { "Shiva", "Shankar", "Sundar" };
            List<string> girls = new List<string>(3) { "Anu", "Anju", "Suma" };
            List<string> schoolFriends = new List<string>(5) { "Shiva", "Shankar", "Ravi", "Anu", "Rama" };
            List<string> bestFriends = new List<string>(10);
            //Dictionary<int, string> indexes = new Dictionary<int, string>();
            var indexes = new Dictionary<int,string> ();
            List<string> schoolFriendsCopy = new List<string>(schoolFriends);
            for(int i = 0;i < schoolFriendsCopy.Count();i++)
            {
               indexes = GetBestFriend(schoolFriendsCopy[i],boys,girls);
                foreach (KeyValuePair<int, string> kvp in indexes)
                {
                    if (kvp.Value.Equals("girl"))
                    {
                        bestFriends.Add(girls[kvp.Key]);
                        schoolFriends.Remove(girls[kvp.Key]);
                        girls.Remove(girls[kvp.Key]);
                    }
                    else
                    {
                        bestFriends.Add(boys[kvp.Key]);
                        schoolFriends.Remove(boys[kvp.Key]);
                        boys.Remove(boys[kvp.Key]);
                    }
                }
            }
            //foreach (KeyValuePair<int, string> kvp in indexes)
            //{
            //    if (kvp.Value.Equals("girl"))
            //    {
            //        bestFriends.Add(girls[kvp.Key]);
            //        schoolFriends.Remove(girls[kvp.Key]);
            //        girls.Remove(girls[kvp.Key]);
            //    }
            //    else
            //    {
            //        bestFriends.Add(boys[kvp.Key]);
            //        schoolFriends.Remove(boys[kvp.Key]);
            //        boys.Remove(boys[kvp.Key]);
            //    }
            //}
            Console.WriteLine("List of Best Friends");
            DisplayList(bestFriends);
            Console.WriteLine("List of School Friends");
            DisplayList(schoolFriends);
            Console.WriteLine("List of Boys");
            DisplayList(boys);
            Console.WriteLine("List of Girls");
            DisplayList(girls);
        }

        private Dictionary<int, string> GetBestFriend(string friend, List<string> boys, List<string>girls)
        {
            Dictionary<int, string> indexes = new Dictionary<int, string>();
            if (boys.Contains(friend))
            {
                indexes.Add(boys.IndexOf(friend), "boy");
            }
            else if (girls.Contains(friend))
            {
                indexes.Add(girls.IndexOf(friend), "girl"); 
            }
            return indexes;
        }

        private void DisplayList(List<string> friends)
        {
            foreach(var friend in friends)
            {
                Console.Write($"{friend}, ");
            }
            Console.WriteLine();
        }
    }
}
