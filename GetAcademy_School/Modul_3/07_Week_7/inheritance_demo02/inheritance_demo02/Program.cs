using inheritance_demo02;
using static System.Console;
using static System.Console;

List<Post> liPosts = new List<Post>();




Post post1 = new Post();
//Post post2 = new Post();
//Post post3 = new Post();
//Post post4 = new Post();
Post post5 = new Post("Thanks for not showing up to my god damn birthday !", true, "Andrea bravsloski");


WriteLine(post5.ToString());


WriteLine("----- Intermission -----");
ImagePost imagePost1 = new ImagePost("Check out my awesome new football !", "Liam Frederikson", "http://www.ikke.no", true);
WriteLine(imagePost1.ToString());










ReadLine();