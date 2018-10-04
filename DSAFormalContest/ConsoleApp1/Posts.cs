using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Posts
    {
        private static StringBuilder sb = new StringBuilder();
        private static Dictionary<string, User> allUsersPostsByName = new Dictionary<string, User>();
        private static Dictionary<string, HashSet<string>> subsbribeUsers = new Dictionary<string, HashSet<string>>();
        private static int counter = 1;

        static void Main(string[] args)
        {
            int numsOfCommands = int.Parse(Console.ReadLine());

            string[] inputLine;
            string command;
            for (int i = 0; i < numsOfCommands; i++)
            {
                inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                command = inputLine[0];

                switch (command)
                {
                    case "add":
                        AddCommand(inputLine[1]);
                        break;
                    case "subscribe":
                        SubscribeCommand(inputLine[1], inputLine[2]);
                        break;
                    case "post":
                        PostCommand(inputLine[1], inputLine[2]);
                        break;
                    case "listposts":
                        ListPostsCommand(inputLine[1]);
                        break;
                }
            }
            Console.Write(sb.ToString());
        }

        private static void ListPostsCommand(string user)
        {           

            var lastTen = allUsersPostsByName[user].MyPosts.TakeLast(10);
            sb.AppendLine($"{user}: {subsbribeUsers[user].Count} subscriptions");
            sb.AppendLine($"{string.Join("\r\n", lastTen)}");
        }

        private static void PostCommand(string user, string text)
        {            
            var currPost = new UserPost(text, counter);

            allUsersPostsByName[user].MyPosts.Add(currPost);

            sb.AppendLine($"{user} created post {counter}: {text}");
            counter++;
        }

        private static void SubscribeCommand(string user1, string user2)
        {
            subsbribeUsers[user1].Add(user2);

            foreach (var item in allUsersPostsByName[user2].MyPosts.Take(10))
            {
                allUsersPostsByName[user1].MyPosts.Add(item);
            }
            

            sb.AppendLine($"{user1} subscribed to {user2}");
        }

        private static void AddCommand(string userName)
        {
            if (!allUsersPostsByName.ContainsKey(userName))
            {
                allUsersPostsByName.Add(userName, new User());
                subsbribeUsers.Add(userName, new HashSet<string>());
            }
        }
    }

    public class User
    {
        public User()
        {
            this.MyPosts = new SortedSet<UserPost>();
        }

        public SortedSet<UserPost> MyPosts { get; set; }
    }
    public class UserPost : IComparable<UserPost>
    {
        // Constructor
        public UserPost(string text, int postNumber)
        {
            this.Text = text;
            this.PostNumber = postNumber;
        }

        // Properties
        public string Text { get; set; }

        public int PostNumber { get; set; }

        // Implement CompareTo method
        public int CompareTo(UserPost other)
        {
            var comparison = other.PostNumber.CompareTo(this.PostNumber);
            return comparison;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"- Post {this.PostNumber}: {this.Text}";
        }
    }
}
