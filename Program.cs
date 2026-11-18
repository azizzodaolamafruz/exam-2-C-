// Main d = new Main();
// System.Console.WriteLine(d.Abs(-7.5));
// System.Console.WriteLine(d.Abs(-7));
// System.Console.WriteLine(d.Pow(2, 3));
// System.Console.WriteLine(d.Sqrt(16));
// System.Console.WriteLine(d.Max(3, 7));
// System.Console.WriteLine(d.Min(3, 7));



List<Post> posts = new List<Post>();

Post p1 = new Post();
p1.Title = "Post 1";
p1.Description = "Description 1";
p1.Publish();
p1.Like();
p1.Like();
p1.Comment("Nice post!");
posts.Add(p1);

Post p2 = new Post();
p2.Title = "Post 2";
p2.Description = "Description 2";
p2.Publish();
p2.Like();
p2.Comment("Great!");
posts.Add(p2);

Post p3 = new Post();
p3.Title = "Post 3";
p3.Description = "Description 3";
p3.Like();
p3.Like();
p3.Like();
posts.Add(p3);

Post p4 = new Post();
p4.Title = "Post 4";
p4.Description = "Description 4";
p4.Publish();
posts.Add(p4);

Post p5 = new Post();
p5.Title = "Post 5";
p5.Description = "Description 5";
p5.Like();
p5.Comment("Cool");
posts.Add(p5);

foreach (Post post in posts)
{
    Console.WriteLine($"{post.Title} – {post.Description} – number of Likes: {post.LikeCount}");
}