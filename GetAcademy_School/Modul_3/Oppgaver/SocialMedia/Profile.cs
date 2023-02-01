using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }  
        public string Address { get; set; }
        public string TwitterHandle { get; set; }
        private List<Profile> Friends { get; set; }

        public Profile(string name)
        {
            Name = name;    
            Friends = new List<Profile>();
        }

        public Profile(string name, string id)
        {
            Name = name;
            Id = id;
            Friends = new List<Profile>();
        }

        public Profile(string name, string id, string address)
        {
            Name = name;
            Id = id;
            Address = Address;
            Friends = new List<Profile>();
        }

        public Profile(string name, string id, string address, string twitterHandle)
        {
            Name = name;
            Id = id;
            Address = address;
            TwitterHandle = twitterHandle;
            Friends = new List<Profile>();
        }

        public void PrintProfileInfo()
        {
            Console.Clear();
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine("| Profile Info ");
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine($"| Name: {Name}");
            Console.WriteLine($"| Address: {Address}");
            Console.WriteLine($"| Twitter: {TwitterHandle}");
            Console.WriteLine($"| Friends: ");
            ShowFriends();
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine("Push Enter to return.");
        }
        public void ShowFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine("Your friends list");
                Console.WriteLine($"| {friend.Id}: {friend.Name} ");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
            Console.Clear();
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine($"{friendToAdd.Name} added to your friends list.");
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine();


        }

        public void RemoveFriend(Profile friendToRemove)
        {
            Friends.Remove(friendToRemove);
        }

        public void  CountFriends()
        {
            Console.WriteLine($"| Number of friends: {Friends.Count()}");
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine();


        }
    }
}
